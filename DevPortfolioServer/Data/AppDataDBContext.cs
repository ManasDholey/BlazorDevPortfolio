using DevPortfolioShared.Models;
using Microsoft.EntityFrameworkCore;

namespace DevPortfolioServer.Data
{
    public class AppDataDBContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public AppDataDBContext(DbContextOptions<AppDataDBContext> dbContextOptions):base(dbContextOptions) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Category[] categories = new Category[3];
            for (int i = 1; i < 4; i++)
            {
                categories[i - 1] = new Category
                {
                    CategoryId = i,
                    ThumbnailImagePath = "uploads/plaseholder.jpg",
                    Name = $"Category {i}",
                    Description = $"A description of a Category {i}"
                };
            }
            modelBuilder.Entity<Category>().HasData(categories);
        }

    }
}
