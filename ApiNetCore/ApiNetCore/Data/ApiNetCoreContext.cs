using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiNetCore.Modelo;

namespace ApiNetCore.Data
{
    public class ApiNetCoreContext : DbContext
    {
        public ApiNetCoreContext (DbContextOptions<ApiNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ApiNetCore.Modelo.Contacto> Contacto { get; set; }
    }
}
