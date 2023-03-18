using AgileMiniApi.Data.DbModels;

using Microsoft.EntityFrameworkCore;

namespace AgileMiniApi.Data;

public class DataBaseContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<TaskDb> Tasks { get; set; }

    public DataBaseContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=AgileMini.db");
    }
}