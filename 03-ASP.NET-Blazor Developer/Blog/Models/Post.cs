#nullable disable

using System.ComponentModel.DataAnnotations;

namespace Blog.Models;

public class Post
{
    public int Id { get; set; }
    
    [MaxLength(100)]
    public string Title { get; set; }
    
    [MaxLength(100)]
    public string Summary { get; set; }
    
    [MaxLength(100)]
    public string Body { get; set; }
    
    [MaxLength(100)]
    public string Slug { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public Category Category { get; set; }
    public User Author { get; set; }

    public List<Tag> Tags { get; set; }
}