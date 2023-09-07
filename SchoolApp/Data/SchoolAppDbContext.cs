using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Model;

namespace SchoolApp.Data
{
    public class SchoolAppDbContext : DbContext
    {
        public SchoolAppDbContext (DbContextOptions<SchoolAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolApp.Model.RainBowSchool> RainBowSchool { get; set; } = default!;
    }
}
