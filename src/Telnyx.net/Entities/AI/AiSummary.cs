﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Telnyx.net.Entities.AI.AiSummarize
{
    public class AiSummary : TelnyxEntity
    {
        [JsonProperty("summary")]
        public string SummaryText { get; set; }
    }
}
