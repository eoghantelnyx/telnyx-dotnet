﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Telnyx.net.Entities.Wireless.SimCards
{
    public class SimCardDataUsageNotificationOption : ListOptions
    {
        [JsonProperty("filter[sim_card_id]")]
        public Guid SimCardId { get; set; }
    }
}
