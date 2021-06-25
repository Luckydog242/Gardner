using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GardnerWebApplication.Data;
using System;
using System.Linq;

namespace GardnerWebApplication.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GardnerWebApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GardnerWebApplicationContext>>()))
            {
                //Create placeholders so that only necessary models are seeded within the context
                bool noAuthors = true;
                bool noAliases = true;

                // Look for any authors
                if (context.Author.Any())
                {
                    noAuthors = false;   // DB has been seeded witih Authors. Skip
                }
                // Look for any authors
                if (context.Alias.Any())
                {
                    noAliases = false;   // DB has been seeded with Aliases. Skip
                }

                //Return if DB has already been seeded
                if (!(noAuthors) && !(noAliases))
                {
                    return;             //DB has been fully seeded.
                }

                if (noAuthors)
                {
                    context.Author.AddRange(
                        new Author
                        {
                            Title = "Head",
                            FirstName = "Drew",
                            LastName = "Battison"
                        },
                        new Author
                        {
                            Title = "Editor",
                            FirstName = "Luke",
                            LastName = "Smith"
                        },
                        new Author
                        {
                            Title = "Editor",
                            FirstName = "Dawson",
                            LastName = "Cooper"
                        }
                    );
                }

                if (noAliases)
                {
                    context.Alias.AddRange(
                        new Alias
                        {
                            AliasName = "Drew Battison",
                            FirstName = "Drew",
                            LastName = "Battison"
                        },
                        new Alias
                        {
                            AliasName = "Team 1",
                            FirstName = "Luke",
                            LastName = "Smith"
                        },
                        new Alias
                        {
                            AliasName = "Team 1",
                            FirstName = "Dawson",
                            LastName = "Cooper"
                        }
                    );
                }
                context.SaveChanges();
            }
        }
    }
}
