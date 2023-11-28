using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }
            

            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Airpods Max Space",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 19900,
                    PictureUrl = "/images/headphones/airpods_max_space.webp",
                    Brand = "Apple",
                    Type = "Headphones",
                    QuantityInStock = 19
                },
                new Product
                {
                    Name = "Airpods Pro",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 4900,
                    PictureUrl = "/images/headphones/airpods_pro.webp",
                    Brand = "Apple",
                    Type = "Headphones",
                    QuantityInStock = 31
                },
                new Product
                {
                    Name = "Pixel Earbuds",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 3900,
                    PictureUrl = "/images/headphones/pixel_earbuds.webp",
                    Brand = "Google",
                    Type = "Headphones",
                    QuantityInStock = 5
                },
                new Product
                {
                    Name = "Samsung Buds",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 3000,
                    PictureUrl = "/images/headphones/samsung_buds.webp",
                    Brand = "Samsung",
                    Type = "Headphones",
                    QuantityInStock = 15
                },
                new Product
                {
                    Name = "Sony Wh 100 XM4",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/headphones/sony_wh_1000xm4.webp",
                    Brand = "Sony",
                    Type = "Headphones",
                    QuantityInStock = 12
                },
                new Product
                {
                    Name = "Apple 13 Midnight",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 49900,
                    PictureUrl = "/images/phones/apple13_midnight.webp",
                    Brand = "Samsung",
                    Type = "Smartphones",
                    QuantityInStock = 15
                },
                new Product
                {
                    Name = "Google Pixel 8a",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 39900,
                    PictureUrl = "/images/phones/google_pixel_8a.webp",
                    Brand = "Google",
                    Type = "Smartphones",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Iphone 14 Gold",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 60000,
                    PictureUrl = "/images/phones/iphone14.webp",
                    Brand = "Apple",
                    Type = "Smartphones",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Samsung S23",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 40000,
                    PictureUrl = "/images/phones/samsung_s23.webp",
                    Brand = "Samsung",
                    Type = "Smartphones",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Sony Xperia 1V",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 29900,
                    PictureUrl = "/images/phones/sony_xperia_1v.webp",
                    Brand = "Sony",
                    Type = "Smartphones",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Apple Watch 8",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 19900,
                    PictureUrl = "/images/watches/apple_watch_8.webp",
                    Brand = "Apple",
                    Type = "Watches",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Apple Watch SE 2023",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20900,
                    PictureUrl = "/images/watches/apple_watch_se_2023.webp",
                    Brand = "Apple",
                    Type = "Watches",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Google Pixel Watch",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 11800,
                    PictureUrl = "/images/watches/google_pixel_watch.webp",
                    Brand = "Google",
                    Type = "Watches",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Samsung Galaxy Watch 5",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 9900,
                    PictureUrl = "/images/watches/samsung_galaxy_watch 5.webp",
                    Brand = "Samsung",
                    Type = "Watches",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Playstation 5 Dual Sense",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 70000,
                    PictureUrl = "/images/playStation/ps5_dual_sense.webp",
                    Brand = "Sony",
                    Type = "Playstation",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Playstation 5 Blu Ray Spider-Man 2",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 79900,
                    PictureUrl = "/images/playStation/ps5_blu-ray_spider-man_2.webp",
                    Brand = "Sony",
                    Type = "Playstation",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Xbox Series S",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 59900,
                    PictureUrl = "/images/playStation/xbox_series_s.webp",
                    Brand = "Microsoft",
                    Type = "Playstation",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Xbox Series X",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 69900,
                    PictureUrl = "/images/playStation/xbox_series_x.webp",
                    Brand = "Microsoft",
                    Type = "Playstation",
                    QuantityInStock = 100
                },
            };
            
            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}