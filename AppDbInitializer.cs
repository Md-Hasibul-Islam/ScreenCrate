using ScreenCrate.Data.Static;
using ScreenCrate.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenCrate.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Universal Pictures",
                            Logo = "https://yt3.googleusercontent.com/_xmrueXlQyPmO379bSt2BjirLWXxNOUoQn1jV0DpOlxxeCGlx9Z2L9HxfoWMgdsdIyGFh17W1A=s900-c-k-c0x00ffffff-no-rj",
                            Description = "Universal Pictures is an American film production and distribution company and owned by NBCUniversal, which is a division of Comcast."
                        },
                        new Cinema()
                        {
                            Name = "20th Century Studios",
                            Logo = "https://yt3.googleusercontent.com/ytc/AOPolaSW93Toyy9PPXfZ2SbIhfHjDP_c2_v0rHkslcvKjw=s900-c-k-c0x00ffffff-no-rj",
                            Description = "20th Century Studios is an American film studio currently owned by The Walt Disney Studios, a subsidiary of the Disney Entertainment division of The Walt Disney Company."
                        },
                        new Cinema()
                        {
                            Name = "Paramount Pictures",
                            Logo = "https://yt3.googleusercontent.com/PONSj7yNZXmRc_whSU8ihBrDAAeoWMXPXaeAdYYLldEXK4YjXPFw0Uiox6KdDOcujYqhjHSd=s900-c-k-c0x00ffffff-no-rj",
                            Description = "Paramount Pictures Corporation is an American film and television production and distribution company and the namesake division of Paramount Global."
                        },
                        new Cinema()
                        {
                            Name = "Marvel Studios",
                            Logo = "https://yt3.googleusercontent.com/fGvQjp1vAT1R4bAKTFLaSbdsfdYFDwAzVjeRVQeikH22bvHWsGULZdwIkpZXktcXZc5gFJuA3w=s900-c-k-c0x00ffffff-no-rj",
                            Description = "Marvel Studios, LLC is an American film and television production company that is a subsidiary of Walt Disney Studios, a division of Disney Entertainment, which is owned by the Walt Disney Company."
                        },
                        new Cinema()
                        {
                            Name = "Warner Bros.",
                            Logo = "https://yt3.googleusercontent.com/Dd84-7pxMM5DvXGwsEoLv5NMdyeEJnGxhe0rtDuJslFN3YUKCOhN5R7n8--B6g33kPNV2Pv8Q28=s900-c-k-c0x00ffffff-no-rj",
                            Description = "Warner Bros. Entertainment Inc. is an American film and entertainment studio headquartered at the Warner Bros. Studios complex in Burbank, California, and a subsidiary of Warner Bros. Discovery."
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Cillian Murphy",
                            Bio = "Cillian Murphy is an Irish actor. He made his professional debut in Enda Walsh's 1996 play Disco Pigs, a role he later reprised in the 2001 screen adaptation.",
                            ProfilePictureURL = "https://image-pastemagazine-com-public-bucket.storage.googleapis.com/wp-content/uploads/2022/06/18213620/PEAKY-BLINDERS-cilian-murphy-square.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Florence Pugh",
                            Bio = "Florence Pugh is an English actress. She made her acting debut in 2014 in the drama film The Falling.",
                            ProfilePictureURL = "https://media1.popsugar-assets.com/files/thumbor/Yc8IFQbfEwtyUMJEYF0-WmQeqe8/150x148:3327x3325/fit-in/500x500/filters:format_auto-!!-:strip_icc-!!-/2020/01/24/051/n/44344577/a34ec0be5e2b8865a56ae5.41932378_/i/Florence-Pugh.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Robert Downey Jr.",
                            Bio = "Robert John Downey Jr. is an American actor. His career has been characterized by critical and popular success in his youth.",
                            ProfilePictureURL = "https://i.pinimg.com/736x/1b/8f/49/1b8f490193bbd7cf4d091f5e12a59f6e.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Scarlett Johansson",
                            Bio = "Scarlett Ingrid Johansson is an American and Danish actress. She has featured multiple times on the Forbes Celebrity 100 list.",
                            ProfilePictureURL = "https://assets.vogue.com/photos/58dedea1c83a5e7c386dc9bc/1:1/w_354%2Cc_limit/00-square-scarlett-johansson-5-things.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Shah Rukh Khan",
                            Bio = "Shah Rukh Khan, also known by the initialism SRK, is an Indian actor and film producer who works in Hindi films. Referred to in the media as the 'Baadshah of Bollywood' and 'King Khan'.",
                            ProfilePictureURL = "https://yt3.googleusercontent.com/ytc/AOPolaQHzyS6-MMuDGqmbuMv8NbEiXFdN44YYJ8MLl49=s900-c-k-c0x00ffffff-no-rj"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Jon Favreau",
                            Bio = "Jonathan Kolia Favreau is an American filmmaker and actor. As an actor, Favreau has appeared in films such as Rudy, Daredevil, Swingers and many more.",
                            ProfilePictureURL = "https://pyxis.nymag.com/v1/imgs/2c3/c65/3f8359a905efbc04b0d0b8b9a8dea69317-08-jon-favreau.rsquare.w330.jpg"

                        },
                        new Producer()
                        {
                            FullName = "Denis Villeneuve",
                            Bio = "Denis Villeneuve OC CQ RCA is a Canadian filmmaker. He is a four-time recipient of the Canadian Screen Award for Best Direction.",
                            ProfilePictureURL = "https://pyxis.nymag.com/v1/imgs/05d/d00/de60ba1cb52c672517678d5673802b4e14-21-dennis-villeneuve.rsquare.w330.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Cate Shortland",
                            Bio = "Cate Shortland is an Australian director and screenwriter. She received international acclaim for her 2004 romantic drama film Somersault.",
                            ProfilePictureURL = "https://pyxis.nymag.com/v1/imgs/31e/263/4839194c0959744df0e27421855459a3f8-12-cate-shortland.rsquare.w330.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Greta Gerwig",
                            Bio = "Greta Celeste Gerwig is an American actress, screenwriter, and director. She first garnered attention after working on and appearing in several mumblecore films.",
                            ProfilePictureURL = "https://pyxis.nymag.com/v1/imgs/34b/5b0/f4e2f45ff69acdbcc14dd296eafd770ea7-09-greta-gerwig.rsquare.w700.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Christopher Nolan",
                            Bio = "Christopher Edward Nolan CBE is a British and American filmmaker. Known for his Hollywood blockbusters with complex storytelling.",
                            ProfilePictureURL = "https://pyxis.nymag.com/v1/imgs/cfc/3c9/e101d421b91bdd880e04edd8f9d36a343b-christopher-nolan.rsquare.w330.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Oppenheimer",
                            Description = "Oppenheimer is a 2023 biographical thriller film written and directed by Christopher Nolan, based on the story of American scientist J. Robert Oppenheimer and his role in the development of the atomic bomb.",
                            Price = 79.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMDBmYTZjNjUtN2M1MS00MTQ2LTk2ODgtNzc2M2QyZGE5NTVjXkEyXkFqcGdeQXVyNzAwMjU2MTY@._V1_.jpg",
                            MovieURL = "~/MovieResources/Oppenheimer.mp4",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            MovieURL = "~/MovieResources/test_video.mp4",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            MovieURL = "~/MovieResources/test_video.mp4",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            MovieURL = "~/MovieResources/test_video.mp4",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            MovieURL = "~/MovieResources/test_video.mp4",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Animation
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            MovieURL = "~/MovieResources/test_video.mp4",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@screencrate.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Admin@123");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@screencrate.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "User@123");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
