using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using GardnerWebApplication.Models;

namespace GardnerWebApplication.Data
{
    public class GardnerWebApplicationContext : DbContext
    {
        public GardnerWebApplicationContext(DbContextOptions<GardnerWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Alias> Alias { get; set; }

    }
}
