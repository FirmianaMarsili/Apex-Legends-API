using System;
using Newtonsoft.Json;

namespace Apex.Legends.API
{
    public class MaprotationResponse : ErrorBase
    {
        [JsonProperty("current")]
        public Current Current { get; set; }

        [JsonProperty("next")]
        public Next Next { get; set; }
    }
    public class Current
    {
        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("readableDate_start")]
        public DateTimeOffset ReadableDateStart { get; set; }

        [JsonProperty("readableDate_end")]
        public DateTimeOffset ReadableDateEnd { get; set; }

        [JsonProperty("map")]
        public string Map { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("DurationInSecs")]
        public int DurationInSecs { get; set; }

        [JsonProperty("DurationInMinutes")]
        public int DurationInMinutes { get; set; }

        [JsonProperty("asset")]
        public Uri Asset { get; set; }

        [JsonProperty("remainingSecs")]
        public int RemainingSecs { get; set; }

        [JsonProperty("remainingMins")]
        public int RemainingMins { get; set; }

        [JsonProperty("remainingTimer")]
        public string RemainingTimer { get; set; }
    }

    public class Next
    {
        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("readableDate_start")]
        public DateTimeOffset ReadableDateStart { get; set; }

        [JsonProperty("readableDate_end")]
        public DateTimeOffset ReadableDateEnd { get; set; }

        [JsonProperty("map")]
        public string Map { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("DurationInSecs")]
        public int DurationInSecs { get; set; }

        [JsonProperty("DurationInMinutes")]
        public int DurationInMinutes { get; set; }
    }

}
