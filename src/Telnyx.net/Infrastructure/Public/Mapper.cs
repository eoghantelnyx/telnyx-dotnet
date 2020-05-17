namespace Telnyx
{
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Telnyx.net.Entities;

    /// <summary>
    /// Mapper class for object.
    /// </summary>
    /// <typeparam name="T">Class.</typeparam>
    public static class Mapper<T>
    {
        /// <summary>
        /// Root Object.
        /// </summary>
        private class RootObject
        {
            /// <summary>
            /// Gets data.
            /// </summary>
            [JsonProperty("data")]
            public T Data { get; private set; }
        }

        /// <summary>
        /// Map collection from JSON.
        /// </summary>
        /// <param name="json">Json string.</param>
        /// <param name="token">Token string.</param>
        /// <param name="telnyxResponse">Telnyx Response.</param>
        /// <returns>List of object.</returns>
        public static List<T> MapCollectionFromJson(string json, string token = "data", TelnyxResponse telnyxResponse = null)
        {
            var jObject = JObject.Parse(json);

            var allTokens = jObject.SelectToken(token);

            return allTokens.Select(tkn => MapFromJson(tkn.ToString(), null, telnyxResponse)).ToList();
        }

        /// <summary>
        /// Map collection from JSON.
        /// </summary>
        /// <param name="telnyxResponse">Telnyx response.</param>
        /// <param name="token">Token.</param>
        /// <returns>List of object.</returns>
        public static List<T> MapCollectionFromJson(TelnyxResponse telnyxResponse, string token = "data")
        {
            return MapCollectionFromJson(telnyxResponse.ResponseJson, token, telnyxResponse);
        }

        /// <summary>
        /// The ResponseJson on a list method is the entire list (as json) returned from Telnyx.
        /// </summary>
        /// <param name="json">The JSON string.</param>
        /// <param name="parentToken">Selects the token that matches the object path.</param>
        /// <param name="telnyxResponse">Telnyx response to nested properties for TelnyxList.</param>
        /// <returns>Mapper.</returns>
        public static T MapFromJson(string json, string parentToken = "data", TelnyxResponse telnyxResponse = null)
        {
            var jsonToParse = string.IsNullOrEmpty(parentToken) ? json : JObject.Parse(json).SelectToken(parentToken)?.ToString();

            T result = default;
            if (!string.IsNullOrWhiteSpace(jsonToParse))
            {
                result = JsonConvert.DeserializeObject<T>(jsonToParse);
            }

            // If necessary, we might need to apply the Telnyx response to nested properties for TelnyxList<T>
            ApplyTelnyxResponse(json, telnyxResponse, result);

            return result;
        }

        /// <summary>
        /// The ResponseJson on a list method is the entire list (as json) returned from Telnyx.
        /// </summary>
        /// <param name="json">The JSON string.</param>
        /// <param name="parentToken">Selects the token that matches the object path.</param>
        /// <param name="telnyxResponse">Telnyx response to nested properties for TelnyxList.</param>
        /// <returns>Mapper.</returns>
        public static T MapFromJsonError(string json, string parentToken = "error", TelnyxResponse telnyxResponse = null)
        {
            return MapFromJson(json, parentToken, telnyxResponse);
        }
        public static T MapFromJsonErrors(string json, string parentToken = "errors", TelnyxResponse telnyxResponse = null)
        {
            return MapFromJson(json, parentToken, telnyxResponse);
        }
        /// <summary>
        /// Map from JSON to object.
        /// </summary>
        /// <param name="telnyxResponse">Telnyx response in object.</param>
        /// <param name="parentToken">Selects the token that matches the object path.</param>
        /// <returns>Telnyx object.</returns>
        public static T MapFromJson(TelnyxResponse telnyxResponse, string parentToken = null)
        {
            return MapFromJson(telnyxResponse.ResponseJson, parentToken, telnyxResponse);
        }

        private static void ApplyTelnyxResponse(string json, TelnyxResponse telnyxResponse, object obj)
        {
            if (telnyxResponse == null || obj == null)
            {
                return;
            }

            var tResponseType = obj.GetType().GetRuntimeProperties()
                .Where(x => x.PropertyType.Equals(telnyxResponse.GetType()));

            if (tResponseType != null && tResponseType.Any())
            {
                tResponseType.ToList().ForEach(x => x.SetValue(obj, telnyxResponse));
            }
            if (obj.GetType().Equals(typeof(TelnyxList<T>)))
            {
                var objList = obj as TelnyxList<T>;
                objList.Url = telnyxResponse.Url;
            }

            telnyxResponse.ObjectJson = json;
        }
    }
}
