using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Legends.API
{
    /// <summary>
    /// 统计数据
    /// </summary>
    public class Bridge : ResponseBase<BridgeResponse>
    {
        public string Method => "bridge";

        /// <summary>
        /// 	The player's username （only origin）
        /// </summary>
        public string Player { get; set; }
        public string UID { get; set; }
        public Platform? Platform { get; set; }
        public string Version => "5";
        /// <summary>
        ///  get the clubs the player is in
        /// </summary>
        public bool? EnableClubsBeta { get; set; }
        //any value
        public string SkipRank { get; set; }
        //any value
        public string Merge { get; set; }
        //any value
        public string RemoveMerged { get; set; }
       
    }
}
