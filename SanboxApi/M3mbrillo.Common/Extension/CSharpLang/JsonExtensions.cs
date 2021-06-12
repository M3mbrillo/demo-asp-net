using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace M3mbrillo.Common.Extension.CSharpLang
{
    public static class JsonExtensions
    {
        /// <summary>
        ///     Shortcut of JsonSerializer.Serialize(obj, options);
        /// </summary>
        public static string AsJsonEncode(this object obj, JsonSerializerOptions? options = null)
            => JsonSerializer.Serialize(obj, options);
    }
}
