using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GardnerWebApplication.Models;

namespace GardnerWebApplication.Data
{
    public class MvcAuthorContext : DbContext
    {
        public MvcAuthorContext(DbContextOptions<MvcAuthorContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Author { get; set; }
    }
}
