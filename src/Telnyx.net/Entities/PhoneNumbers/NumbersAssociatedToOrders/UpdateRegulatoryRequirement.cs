﻿namespace Telnyx.net.Entities.PhoneNumbers.NumbersAssociatedToOrders
{
    using Newtonsoft.Json;

    public class UpdateRegulatoryRequirement
    {
        [JsonProperty("field_value")]
        public string FieldValue { get; set; }

        [JsonProperty("requirement_id")]
        public string RequirementId { get; set; }
    }
}
