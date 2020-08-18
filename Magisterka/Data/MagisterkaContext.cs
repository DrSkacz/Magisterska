using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Magisterka.Models
{
    public class MagisterkaContext : DbContext
    {
        public MagisterkaContext (DbContextOptions<MagisterkaContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Magisterka.Models.Baza> Baza { get; set; }
    }
}
