#nullable  disable

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Blog.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    [MaxLength(100)]
    public string Email { get; set; }
    
    [JsonIgnore]
    [MaxLength(100)]
    public string PasswordHash { get; set; }
    
    [MaxLength(100)]
    public string Image { get; set; }
    public string Slug { get; set; }
    
    [MaxLength(100)]
    public string Bio { get; set; }
    
    public IList<Post> Posts { get; set; }
    public IList<Role> Roles { get; set; }
}