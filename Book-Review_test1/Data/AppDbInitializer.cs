using Book_Review_test1.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Review_test1.Data
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
                        Title = "In Search of Lost Time",
                        Rate = 9,
                        Author = "Marcel Proust",
                    },
                    new Book()
                    {
                        Title = "Ulysses",
                        Rate = 8,
                        Author = "	James Joyce",
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
