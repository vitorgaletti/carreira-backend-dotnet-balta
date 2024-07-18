#nullable disable

using System.ComponentModel.DataAnnotations;

namespace Blog.Models;

public class Tag
{
    public int Id { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; }
    
    [MaxLength(100)]
    public string Slug { get; set; }

    public List<Post> Posts { get; set; }
}