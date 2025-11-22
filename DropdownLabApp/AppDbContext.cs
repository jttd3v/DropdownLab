using DropdownLabApp.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<DropDownItem> DropDownItems => Set<DropDownItem>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DropDownItem>().HasData(
            new DropDownItem { Id = 1, Name = "Safety" },
            new DropDownItem { Id = 2, Name = "Quality" },
            new DropDownItem { Id = 3, Name = "Environment" }
        );
    }
}