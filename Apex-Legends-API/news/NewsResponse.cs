using Newtonsoft.Json;
using System;

namespace Apex.Legends.API
{
    public class NewsResponse : ErrorBase
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("img")]
        public Uri Img { get; set; }

        [JsonProperty("short_desc")]
        public string ShortDesc { get; set; }
    }  
}
