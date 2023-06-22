﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Telnyx.net.Entities.Enum.AuthenticationProviders;
using Telnyx.net.Services.PhoneNumbers.Orders.Comments;

namespace Telnyx.net.Entities.AuthenticationProviders
{
    public class SettingsRequestObject
    {
        [JsonProperty("idp_cert_fingerprint")]
        public string IdPCertFingerprint { get; set; }

        [JsonProperty("idp_cert_fingerprint_algorithm")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FingerprintAlgorithm IdPCertFingerprintAlgorithm { get; set; } = FingerprintAlgorithm.Sha1;

        [JsonProperty("idp_entity_id")]
        public string IdPEntityId { get; set; }

        [JsonProperty("idp_sso_target_url")]
        public string IdPSSOTargetUrl { get; set; }

        /// <summary>
        /// The URL for the identity provider metadata file to populate the settings automatically. If the settings attribute is provided, that will be used instead.
        /// </summary>
        [JsonProperty("settings_url")]
        public string SettingsUrl { get; set; }
    }
}
