using M3mbrillo.Common.DataAccess.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SandboxApi.Database.Models
{
    [Table(nameof(ProductoRepository))]

    public class Producto 
        : DapperEntity<Producto>
    {

        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string ProductName { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
