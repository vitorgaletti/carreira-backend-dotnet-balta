using Blog.Data;

namespace Blog;

internal abstract class Program
{
    private static void Main(string[] args)
    {
        using var context = new BlogDataContext();
    }
}