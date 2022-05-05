using Newtonsoft.Json;

namespace Apex.Legends.API
{
    public class PredatorResponse : ErrorBase
    {
        [JsonProperty("RP")]
        public Ap Rp { get; set; }

        [JsonProperty("AP")]
        public Ap Ap { get; set; }
    }

    public class Ap
    {
        [JsonProperty("PC")]
        public Pc Pc { get; set; }

        [JsonProperty("PS4")]
        public Pc Ps4 { get; set; }

        [JsonProperty("X1")]
        public Pc X1 { get; set; }

        [JsonProperty("SWITCH")]
        public Pc Switch { get; set; }
    }

    public class Pc
    {
        /// <summary>
        /// 最后一名猎杀的排名，同分数取最低排名（会超过750）
        /// </summary>
        [JsonProperty("foundRank")]
        public int FoundRank { get; set; }

        /// <summary>
        /// 达到猎杀所需的最低分数
        /// </summary>
        [JsonProperty("val")]
        public int Val { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("updateTimestamp")]
        public int UpdateTimestamp { get; set; }

        [JsonProperty("totalMastersAndPreds")]
        public int TotalMastersAndPreds { get; set; }
    }
}
