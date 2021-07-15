using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using My_Book_API.Data.Models;

namespace My_Book_API.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st Book",
                        Description = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https......",
                        DareAdded = DateTime.Now
                    }, new Book()
                    {
                        Title = "2nd Book",
                        Description = "2nd Book Description",
                        IsRead = false,
                        Genre = "Autobiography",
                        Author = "Second Author",
                        CoverUrl = "https......",
                        DareAdded = DateTime.Now
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}