using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System;
// using System.Data.Entity;
// using System.Data.Entity.ModelConfiguration;
public class BloggingContext : DbContext
{
    // public DbSet<Blog> Blogs { get; set; }
    public DbSet<Blog> a_o_blog { get; set; }
    // public DbSet<Post> Posts     { get; set; }
    public DbSet<Post> a_o_post     { get; set; }

    public string DbPath { get; }

    public BloggingContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");

    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   
        // Console.WriteLine("a-a-a-a--a-a-");
        // Console.WriteLine("a-a-a-a--a-a-");
        // Console.WriteLine("a-a-a-a--a-a-");
        // Console.WriteLine("a-a-a-a--a-a-");
        // Console.WriteLine("a-a-a-a--a-a-");
        // Console.WriteLine("a-a-a-a--a-a-");
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Blog>().ToTable("A_o_blog");
        modelBuilder.Entity<Post>().ToTable("A_o_post");
    }

    
}


