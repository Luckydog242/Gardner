using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GardnerWebApplication.Models;

namespace GardnerWebApplication.Data
{
    public class MvcBlogContext : DbContext
    {
        public MvcBlogContext(DbContextOptions<MvcBlogContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Alias> Alias { get; set; }

    }
}
