using System;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Legends.API
{
    public enum Platform
    {
        PC,
        PS4,
        X1
    }

    public enum Mode {
        BATTLE_ROYALE,
        ARENAS,
        UNKNOWN
    }

    public enum Action { 
        info,
        get,
        delete,
        add
    }
    public class ResponseBase<T> where T : ErrorBase
    {
        public string Auth => "";

        private const string Host = "https://api.mozambiquehe.re/";

        private static HttpClient httpClient = new()
        {
            BaseAddress = new(Host),
            Timeout = new TimeSpan(0, 0, 10)
        };
        public async Task<string> GetResponseBaseAsync(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }

        public string GetPaeameter()
        {
            var sb = new StringBuilder();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(this))
            {
                object value = property.GetValue(this);
                if (property.Name == "Method")
                {
                    sb.Insert(0, $"{value}?");
                }
                else
                {
                    if (value != null)
                    {
                        sb.Append($"{property.Name.ToLower()}={value}&");
                    }
                }
                
            }
            return sb.ToString().Trim('&');
        }

        public async Task<T> GetResponseAsync()
        {
            string response = await GetResponseBaseAsync(GetPaeameter());            
            return Converter.FromJson<T>(response);
        }
    }
}
