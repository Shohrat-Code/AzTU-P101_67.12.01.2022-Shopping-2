using Azen.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<CustomUser>().Property(p => p.Email).IsRequired(true);
            //builder.Entity<CustomUser>().HasKey(p=>p.Email).;
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ColorToProduct> ColorToProducts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FAQ> FAQs{ get; set; }
        public DbSet<FAQCategory> FAQCategories { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<ProductTagToProduct> ProductTagToProducts{ get; set; }
        public DbSet<Review> Reviews{ get; set; }
        public DbSet<Setting> Settings{ get; set; }
        public DbSet<Size> Sizes{ get; set; }
        public DbSet<SizeColorToProduct> SizeColorToProducts{ get; set; }
        public DbSet<Subscribe> Subscribes{ get; set; }
        public DbSet<TagToBlog> TagToBlogs{ get; set; }
        public DbSet<Sale> Sales{ get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
    }
}
