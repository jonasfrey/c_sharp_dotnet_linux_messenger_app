using System;
using System.Linq;

using O_simple_http_server;

using var BloggingContext = new BloggingContext();
using var o_database_context_class = new O_database_context_class();
// // Note: This sample requires the database to be created before running.
// Console.WriteLine($"Database path: {o_database_context_class.s_path_database}.");

// Create
// Console.WriteLine("Inserting a new blog");
// BloggingContext.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
// BloggingContext.SaveChanges();

// // Read
// Console.WriteLine("Querying for a blog");
// var blog = o_database_context_class.Blogs
//     .OrderBy(b => b.BlogId)
//     .First();

// // Update
// Console.WriteLine("Updating the blog and adding a post");
// blog.Url = "https://devblogs.microsoft.com/dotnet";
// blog.Posts.Add(
//     new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
// o_database_context_class.SaveChanges();

// // Delete
// Console.WriteLine("Delete the blog");
// o_database_context_class.Remove(blog);
// o_database_context_class.SaveChanges();


// // Note: This sample requires the database to be created before running.
// Console.WriteLine($"Database path: {o_database_context_class.s_path_database}.");


// Create
// Console.WriteLine("crud: create");
// o_database_context_class.Add(new O_person{s_name = "hans"});
// o_database_context_class.SaveChanges();



// // O_simple_http_server.O_http_server.f_listen();