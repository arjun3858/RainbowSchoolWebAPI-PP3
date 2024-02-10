using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainbowSchoolWebAPI.Models;

namespace RainbowSchoolWebAPI.Data
{
    public class RainbowSchoolDataDbContext : DbContext
    {
        public RainbowSchoolDataDbContext (DbContextOptions<RainbowSchoolDataDbContext> options)
            : base(options)
        {
        }

        public DbSet<RainbowSchoolWebAPI.Models.Students> Students { get; set; } = default!;

        public DbSet<RainbowSchoolWebAPI.Models.Subjects>? Subjects { get; set; }

        public DbSet<RainbowSchoolWebAPI.Models.Marks>? Marks { get; set; }
    }
}
