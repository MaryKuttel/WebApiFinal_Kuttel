using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SWProvincias_Kuttel.Models;

namespace SWProvincias_Kuttel.Data
{
    public class DBPaisFinalContext : DbContext
    {
        public DBPaisFinalContext(DbContextOptions<DBPaisFinalContext> options) : base(options) { }

        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Provincia> Provincias { get; set;}
    }
}
