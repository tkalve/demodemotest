using DemoDemo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoDemo.Data;

public class DemoContext : DbContext
{
    public DbSet<Thing> Things { get; set; }
    public DbSet<User> Users { get; set; }

    public string DbPath { get; }

    public DemoContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "demoapp.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}