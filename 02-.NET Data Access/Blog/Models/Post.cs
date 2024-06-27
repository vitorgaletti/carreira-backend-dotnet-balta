#nullable disable
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models;

[Table("[Post]")]
public class Post
{
    public int Id { get; set; }

    public string Name { get; set; }
    
}