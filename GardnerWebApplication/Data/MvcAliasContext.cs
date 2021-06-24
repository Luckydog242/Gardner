using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GardnerWebApplication.Models;

namespace GardnerWebApplication.Data
{
    public class MvcAliasContext : DbContext
    {
        public MvcAliasContext(DbContextOptions<MvcAliasContext> options)
            : base(options)
        {
        }

        public DbSet<Alias> Alias { get; set; }
    }
}
