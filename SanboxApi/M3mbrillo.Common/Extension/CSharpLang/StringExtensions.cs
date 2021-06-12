using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace M3mbrillo.Common.Extension.CSharpLang
{
    public static class StringExtensions
    {
        /// <summary>
        ///     Shortcut of string.IsNullOrEmpty(str);
        /// </summary>
        public static bool IsNullOrEmpty(this string str)
            => string.IsNullOrEmpty(str);

        /// <summary>
        ///     Shortcut of string.IsNullOrWhiteSpace(str);
        /// </summary>
        public static bool IsNullOrWhiteSpace(this string str)
            => string.IsNullOrWhiteSpace(str);
    }
}
