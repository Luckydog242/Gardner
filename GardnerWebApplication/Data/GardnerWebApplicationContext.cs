using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GardnerWebApplication.Models;

namespace GardnerWebApplication.Data
{
    public class GardnerWebApplicationContext : DbContext
    {
        public GardnerWebApplicationContext (DbContextOptions<GardnerWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<GardnerWebApplication.Models.Blog> Blog { get; set; }

        public DbSet<GardnerWebApplication.Models.Author> Author { get; set; }

        public DbSet<GardnerWebApplication.Models.Alias> Alias { get; set; }
    }
}
