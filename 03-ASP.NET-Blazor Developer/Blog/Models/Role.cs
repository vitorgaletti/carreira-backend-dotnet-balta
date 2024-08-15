#nullable disable

using System.ComponentModel.DataAnnotations;

namespace Blog.Models;

public class Role
{
    public int Id { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; }
    
    [MaxLength(100)]
    public string Slug { get; set; }

    public IList<User> Users { get; set; }
}