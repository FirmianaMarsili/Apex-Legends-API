using System.Threading.Tasks;

namespace Apex.Legends.API
{

    public class News : ResponseBase<NewsResponse>
    {
        public string Method => "news";

        /// <summary>
        /// https://docs.microsoft.com/en-us/openspecs/office_standards/ms-oe376/6c085406-a698-4e12-9d4d-c3b0ee3dbc4a
        /// </summary>
        public string Lang { get; set; } = "zh-TW";

        public new async Task<NewsResponse[]> GetResponseAsync()
        {
            string response = await GetResponseBaseAsync(GetPaeameter());            
            return Converter.ArrayFromJson<NewsResponse>(response);
        }
    }
}
