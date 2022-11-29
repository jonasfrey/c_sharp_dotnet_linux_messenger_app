using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

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
}

public class Blog
{
    public int BlogId { get; set; }= default!;
    public string Url { get; set; }= default!;

    public List<Post> Posts { get; } = new();
}

public class Post
{
    public int PostId { get; set; } = default!;
    public string Title { get; set; }= default!;
    public string Content { get; set; }= default!;

    public int BlogId { get; set; }= default!;
    public Blog Blog { get; set; }= default!;
}