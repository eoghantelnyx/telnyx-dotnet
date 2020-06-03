﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Telnyx.net.Entities.Enum;

namespace Telnyx.net.Entities.Connections.ConnectionsService
{
    public class Connection : TelnyxEntity
    {
        /// <summary>
        /// Defaults to true
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; } = true;
        /// <summary>
        /// `Latency` directs Telnyx to route media through the site with the lowest round-trip time to the user's connection. Telnyx calculates this time using ICMP ping messages. This can be disabled by specifying a site to handle all media
        /// </summary>
        [JsonProperty("anchorsite_override")]
        public AnchorsiteOverride? AnchorsiteOverride { get; set; }

        [JsonProperty("connection_name")]
        public string ConnectionName { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("outbound_voice_profile_id")]
        public string OutboundVoiceProfileId { get; set; }

        [JsonProperty("record_type")]
        public RecordTypeEnum? RecordType { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("webhook_api_version")]
        public WebhookAPIVersion? WebhookApiVersion { get; set; }

        [JsonProperty("webhook_event_failover_url")]
        public string WebhookEventFailoverUrl { get; set; }

        [JsonProperty("webhook_event_url")]
        public string WebhookEventUrl { get; set; }
    }
  

}
