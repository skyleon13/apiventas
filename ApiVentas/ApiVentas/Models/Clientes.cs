using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVentas.Models
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPat { get; set; }
        public string ApellidoMat { get; set; }
        public string Rfc { get; set; }
    }
}
