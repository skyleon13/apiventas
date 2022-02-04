using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVentas.Models
{
    public class Configuracion
    {
        [Key]
        public int IdConfiguracion { get; set; }
        public decimal Tasa { get; set; }
        public int Enganche { get; set; }
        public int Plazo { get; set; }
    }
}
