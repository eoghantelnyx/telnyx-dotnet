﻿namespace Telnyx.net.Services.Messaging.Messaging_Profiles.Metrics
{
    using Newtonsoft.Json;

    public class MetricsOptions : BaseOptions
    {
        /// <summary>
        /// The timeframe for which you'd like to retrieve metrics.
        /// <para>Default: "24h".</para>
        /// <para>Options: [
        /// "1h",
        /// "3h",
        /// "24h",
        /// "3d",
        /// "7d",
        /// "30d"
        /// ].</para>
        /// </summary>
        [JsonProperty("time_frame")]
        public string TimeFrame { get; set; } = "24h";
    }
}
