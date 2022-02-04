using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiVentas.Models;

namespace ApiVentas.Data
{
    public class ApiVentasContext : DbContext
    {
        public ApiVentasContext (DbContextOptions<ApiVentasContext> options)
            : base(options)
        {
        }

        public DbSet<ApiVentas.Models.Clientes> Clientes { get; set; }

        public DbSet<ApiVentas.Models.Productos> Productos { get; set; }

        public DbSet<ApiVentas.Models.Configuracion> Configuracion { get; set; }

        public DbSet<ApiVentas.Models.Ventas> Ventas { get; set; }
    }
}
