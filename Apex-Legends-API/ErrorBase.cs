using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Legends.API
{
    public class ErrorBase
    {
        [JsonProperty("Error")]
        public string ErrorMessage
        {
            get;
            set;
        }
        public string Exception
        {
            get;
            set;
        }


        public bool Success => string.IsNullOrEmpty(ErrorMessage);


    }
    public static class Converter
    {
        public static T FromJson<T>(string json) where T : ErrorBase
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json, Settings);
            }
            catch (Exception ex)
            {               
                ErrorBase errorBase = new ErrorBase()
                {
                    ErrorMessage = json,
                    Exception = ex.ToString()
                };
                return (T)errorBase;
            }
        }

        public static T[] ArrayFromJson<T>(string json) where T : ErrorBase
        {
            try
            {
                return JsonConvert.DeserializeObject<T[]>(json, Settings);
            }
            catch (Exception ex)
            {
                ErrorBase errorBase = new ErrorBase()
                {
                    ErrorMessage = json,
                    Exception = ex.ToString()
                };
                return null;
            }
        }

        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
