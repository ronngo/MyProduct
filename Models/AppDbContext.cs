
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProduct.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Gạo" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Thịt" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Hoa Quả" });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Gạo Lứt Huế",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Price = 15.5M,
                Stock = 500,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/12/26/17/28/food-1932466__340.jpg",
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Thịt ba chỉ Huế",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Price = 15.5M,
                Stock = 500,
                ImageUrl = "https://cdn.pixabay.com/photo/2017/02/15/10/39/salad-2068220__340.jpg",
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Gạo Lào",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Price = 15.5M,
                Stock = 500,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/03/10/18/44/top-view-1248955__340.jpg",
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Mít trộn Huế",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Price = 15.5M,
                Stock = 500,
                ImageUrl = "https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png",
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Gạo Thơm xứ Quảng",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Price = 15.5M,
                Stock = 500,
                ImageUrl = "https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png",
                CategoryId = 1
            });
        }
    }
}