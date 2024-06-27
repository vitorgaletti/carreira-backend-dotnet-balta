using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog;

class Program
{
    private const string CONNECTION_STRING =
        @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Encrypt=False";

    static void Main(string[] args)
    {
        var connection = new SqlConnection(CONNECTION_STRING);
        connection.Open();

        //CreateUsers(connection);
        ReadUsersWithRoles(connection);
        //ReadUsers(connection);
        //ReadRoles(connection);
        //ReadTags(connection);
        connection.Close();
    }

    private static void ReadUsersWithRoles(SqlConnection connection)
    {
        var repository = new UserRepository(connection);
        var items = repository.GetWithRoles();

        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
            foreach (var role in item.Roles)
            {
                Console.WriteLine($"- {role.Name}");
            }
        }
    }
    
    private static void CreateUsers(SqlConnection connection)
    {
        var user = new User()
        {
            Email = "email@balta.io",
            Bio = "bio",
            Image = "imagem",
            Name = "Name",
            PasswordHash = "hash",
            Slug = "slug"
        };
        
        var repository = new Repository<User>(connection);
        repository.Create(user);
    }

    private static void ReadRoles(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
    }

    private static void ReadTags(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
    }
}