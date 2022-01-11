using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using scapfolding.Models;

namespace scapfolding.Data
{
    public class scapfoldingContext : DbContext
    {
        public scapfoldingContext (DbContextOptions<scapfoldingContext> options)
            : base(options)
        {
        }

        public DbSet<scapfolding.Models.Student> Student { get; set; }
    }
}
