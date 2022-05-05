using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Legends.API
{
    public class Crafting : ResponseBase<CraftingResponse>
    {
        public string Method => "crafting";

        public new async Task<CraftingResponse[]> GetResponseAsync()
        {            
            string response = await GetResponseBaseAsync(GetPaeameter());            
            return Converter.ArrayFromJson<CraftingResponse>(response);
        }
    }
}
