public class Blog
{
    public int BlogId { get; set; }= default!;
    public string Url { get; set; }= default!;

    public List<Post> Posts { get; } = new();
}