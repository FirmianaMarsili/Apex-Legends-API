using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Legends.API
{
    /// <summary>
    /// 需要付费提升用户等级来使用api
    /// </summary>
    public class Store : ResponseBase<StoreResponse>
    {
        public string Method => "store";
    }
}
