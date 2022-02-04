using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVentas.Models
{
    public class Productos
    {
        [Key]
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
    }
}
