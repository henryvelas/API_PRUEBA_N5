using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_PRUEBA.Models;

namespace PRUEBA_API.Data
{
    public class PRUEBA_APIContext : DbContext
    {
        public PRUEBA_APIContext (DbContextOptions<PRUEBA_APIContext> options)
            : base(options)
        {
        }

        public DbSet<API_PRUEBA.Models.Permissions> Permissions { get; set; }

        public DbSet<API_PRUEBA.Models.PermissionsTypes> PermissionsTypes { get; set; }
    }
}
