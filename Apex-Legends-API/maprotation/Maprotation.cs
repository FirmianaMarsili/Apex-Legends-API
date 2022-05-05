using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Legends.API
{
    /// <summary>
    /// 地图轮换
    /// </summary>
    public class Maprotation : ResponseBase<MaprotationResponse>
    {
        public string Method => "maprotation";

        /// <summary>
        /// 1 for battle royale pubs only, 2 for all modes.
        /// </summary>
        public int? Version { get; set; }
    }
}
