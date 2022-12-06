using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("A_o_blog")]
public class Blog
{
    public int BlogId { get; set; }= default!;
    public string Url { get; set; }= default!;

    public List<Post> A_o_post { get; } = new();
}