using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Apex.Legends.API
{
    public class CraftingResponse : ErrorBase
    {
        [JsonProperty("bundle")]
        public string Bundle { get; set; }

        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public long? Start { get; set; }

        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public long? End { get; set; }

        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("bundleType")]
        public string BundleType { get; set; }

        [JsonProperty("bundleContent")]
        public BundleContent[] BundleContent { get; set; }
    }
    public class BundleContent
    {
        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("itemType")]
        public ItemType ItemType { get; set; }
    }
    public class ItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("asset")]
        public string Asset { get; set; }

        [JsonProperty("rarityHex")]
        public string RarityHex { get; set; }
    }
}
