using Microsoft.EntityFrameworkCore;
using RepoPatternUserService.Domain.Entity;

namespace RepoPatternUserService.DAL;

public class UserServiceDbContext : DbContext
{
    public UserServiceDbContext(DbContextOptions<UserServiceDbContext> options) : base(options)
    { }

    public DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasIndex(u => u.PassportSerNum)
            .IsUnique();
    
        modelBuilder.Entity<User>()
            .HasIndex(u => u.PINFL)
            .IsUnique();
        
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();
        
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();
    }
}