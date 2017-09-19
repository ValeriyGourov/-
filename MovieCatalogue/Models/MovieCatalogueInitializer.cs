using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieCatalogue.Models
{
    public class MovieCatalogueInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

            context.Movies.AddRange(new[] {
                new Movie
                {
                    Title = "When Harry Met Sally",
                    Description = "Описание When Harry Met Sally",
                    ReleaseYear = 1989,
                    Genre = "Romantic Comedy",
                    Director = "Director One",
                    InitialUser = "InitialUser 1"
                },

                new Movie
                {
                    Title = "Ghostbusters",
                    Description = "Описание Ghostbusters",
                    ReleaseYear = 1984,
                    Genre = "Comedy",
                    Director = "Director Two",
                    Poster = "Poster 2",
                    InitialUser = "InitialUser 2"
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    Description = "Описание Ghostbusters 2",
                    ReleaseYear = 1986,
                    Genre = "Comedy",
                    Director = "Director Two",
                    Poster = "Poster 2",
                    InitialUser = "InitialUser 2"
                },

                new Movie
                {
                    Title = "Rio Bravo",
                    Description = "Описание Rio Bravo",
                    ReleaseYear = 1959,
                    Genre = "Western",
                    Director = "Director Three",
                    Poster = "Poster 3",
                    InitialUser = "InitialUser 1"
                }
            });
            context.SaveChanges();
        }
    }
}