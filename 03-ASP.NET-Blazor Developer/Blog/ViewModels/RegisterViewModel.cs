using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels;

public class RegisterViewModel
{
    [Required(ErrorMessage = "O nome é obrigatório")]
    public required string Name { get; set; }
    
    [Required(ErrorMessage = "O E-mail é obrigatório")]
    [EmailAddress(ErrorMessage = "O e-mail é inválido")]
    public required string Email { get; set; }
}