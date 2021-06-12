using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.Extension.Newtonsoft
{
    public static class JsonExtensions
    {
        public static string ToJson(this object value)
        {
            if (value == null) return null;

            try
            {
                string json = JsonConvert.SerializeObject(value/*, _settings*/);
                return json;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static T ToObj<T>(this string value)
        {
            try
            {
                var obj = JsonConvert.DeserializeObject<T>(value/*, _settings*/);
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
