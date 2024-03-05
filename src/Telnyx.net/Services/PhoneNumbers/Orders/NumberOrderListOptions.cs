﻿namespace Telnyx
{
    using Newtonsoft.Json;

    /// <summary>
    /// NumberOrderListOptions.
    /// </summary>
    public class NumberOrderListOptions : ListOptions
    {
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        /// 
        [JsonProperty("filter[status]")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets createdAtGt.
        /// </summary>
        [JsonProperty("filter[created_at][gt]")]
        public string CreatedAtGt { get; set; }

        /// <summary>
        /// Gets or sets createdAtLt.
        /// </summary>
        [JsonProperty("filter[created_at][lt]")]
        public string CreatedAtLt { get; set; }

        /// <summary>
        /// Gets or sets phoneNumbersPhoneNumber.
        /// </summary>
        [JsonProperty("filter[phone_numbers.phone_number]")]
        public string PhoneNumbersPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets customerReference.
        /// </summary>
        /// 
        [JsonProperty("filter[customer_reference]")]
        public string CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets requirementsMet.
        /// </summary>
        /// 
        [JsonProperty("filter[requirements_met]")]
        public bool? RequirementsMet { get; set; }
    }
}