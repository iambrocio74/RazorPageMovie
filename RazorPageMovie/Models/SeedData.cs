using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Data;

namespace RazorPageMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) 
        {
            using (var context = new RazorPageMovieContext1(
                serviceProvider.GetRequiredService<
                DbContextOptions<RazorPageMovieContext1>>()))
                {
                    if (context == null || context.Movie == null) {
                        throw new ArgumentNullException("NUll RazorPageMovieContext");
                    }

                    if (context.Movie.Any()) {
                        return;
                    }

                context.Movie.AddRange(
                    new Movie{
                        Title = "When Harry net Sally",
                        ReleaseDate = DateTime.Parse("1982-02-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },

                    new Movie{
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-03-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "G"
                    },

                    new Movie{
                        Title = "GhostBusters 2",
                        ReleaseDate = DateTime.Parse("1989-02-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating= "G"
                    },
                    new Movie
                    {
                        Title = "Río Bravo",
                        ReleaseDate = DateTime.Parse("1959-04-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "NA"
                    }
                );
                context.SaveChanges();
               
                }
        }
    }
}
