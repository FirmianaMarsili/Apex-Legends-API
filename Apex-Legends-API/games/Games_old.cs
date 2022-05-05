using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Legends.API
{
    public class Games_old : ResponseBase<Games_oldResponse>
    {
        public string Method => "bridge";

        public string UID { get; set; }

        public Platform Platform { get; set; }

        public int History => 1;

        public Action Action { get; set; }
    }
}
