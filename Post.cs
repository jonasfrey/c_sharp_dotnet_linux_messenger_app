
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("A_o_post")]
public class Post
{
    public int PostId { get; set; } = default!;
    public string Title { get; set; }= default!;
    public string Content { get; set; }= default!;

    public int BlogId { get; set; }= default!;
    public Blog Blog { get; set; }= default!;
}