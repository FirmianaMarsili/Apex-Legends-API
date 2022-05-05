using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Legends.API
{
    /// <summary>
    /// 查询匹配记录
    /// 需要充值来提升用户等级来使用这个API
    /// </summary>
    public class Games : ResponseBase<GamesResponse>
    {
        public string Method => "games";

        public string UID { get; set; }

        public Mode? Mode { get; set; }

        public long? Start { get; set; }
        public long? End { get; }
        public int? Limit { get; set; }
    }
}
