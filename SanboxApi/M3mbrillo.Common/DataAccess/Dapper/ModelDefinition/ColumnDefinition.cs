using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Dapper.ModelDefinition
{
    public class ColumnDefinition
    {
        public string ColumnName { get; set; }

        public string SqlType { get; set; }

        public bool IsPrimaryKey { get; set; }

        public int Lenght { get; set; }

        public int Prec { get; set; }

        public int Scale { get; set; }

        public bool IsNulleable { get; set; }
    }
}
