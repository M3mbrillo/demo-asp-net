using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.Logger.Abstract
{
    /// <summary>
    /// Behavior for any "Logger".
    /// </summary>
    public interface ILogger
    {
        void Debug(string message, [CallerFilePathAttribute] string filePath = "", [CallerMemberName] string memberName = "");
        void Trace(string message, [CallerFilePathAttribute] string filePath = "", [CallerMemberName] string memberName = "");
        void Warn(string message, [CallerFilePathAttribute] string filePath = "", [CallerMemberName] string memberName = "");
        void Error(string message, [CallerFilePathAttribute] string filePath = "", [CallerMemberName] string memberName = "");
        void Error(Exception ex, [CallerFilePathAttribute] string filePath = "", [CallerMemberName] string memberName = "");
    }
}
