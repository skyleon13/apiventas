using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVentas.Models
{
    public class Ventas
    {
        [Key]
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public decimal Enganche { get; set; }
        public decimal Bonificacion { get; set; }
        public decimal Total { get; set; }
    }
}
