using Microsoft.EntityFrameworkCore;
using News.Models;



namespace News
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Visit> Visit { get; set; } 



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Visit>()
                .HasOne(v => v.Post) 
                .WithOne()
                .HasForeignKey<Visit>(v => v.PostId); 
        }

    }

}
