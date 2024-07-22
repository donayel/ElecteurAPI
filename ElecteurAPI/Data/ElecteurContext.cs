using Microsoft.EntityFrameworkCore;
using ElecteurAPI.Models;
using System.Collections.Generic;

namespace ElecteurAPI.Data
{
    public class ElecteurContext : DbContext
    {
        public ElecteurContext(DbContextOptions<ElecteurContext> options) : base(options) { }

        public DbSet<Electeur> Electeurs { get; set; }
    }
}
