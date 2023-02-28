using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Scaffold.Model;

namespace Scaffold.Data
{
    public class ScaffoldContext : DbContext
    {
        public ScaffoldContext (DbContextOptions<ScaffoldContext> options)
            : base(options)
        {
        }

        public DbSet<Scaffold.Model.Product> Product { get; set; } = default!;
    }
}
