using Microsoft.EntityFrameworkCore;
using News.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<User> User{ get; set; }    
    public DbSet<Post> Post{ get; set; }    
    public DbSet<Category> Category { get; set; }    

}
