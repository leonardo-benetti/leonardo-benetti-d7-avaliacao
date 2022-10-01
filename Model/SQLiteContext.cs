using System;
using Microsoft.EntityFrameworkCore;

namespace leonardo_benetti_d7_avaliacao.Model;

public class SQLiteContext : DbContext
{
    public SQLiteContext(DbContextOptions<SQLiteContext> options) : base(options)
    {
        Database.EnsureCreated();
    }


    public DbSet<User> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                UserName = "admin@email.com",
                Password = "admin123"
            }
        );
        base.OnModelCreating(modelBuilder);
    }

}
