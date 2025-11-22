using DropdownLabApp.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<DropdownItem> DropdownItems => Set<DropdownItem>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DropdownItem>().HasData(
            new DropdownItem { Id = 1, Name = "Safety" },
            new DropdownItem { Id = 2, Name = "Quality" },
            new DropdownItem { Id = 3, Name = "Environment" }
        );
    }
}