using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAuthenticationCrud;

public class Student
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Por favor, informe o nome")]
    [MaxLength(80, ErrorMessage ="Máximo de 80 caracteres")]
    [MinLength(5, ErrorMessage ="Min de 5 caracteres")]
    [DisplayName("Name")]
    public string Name { get; set; } = String.Empty;
    [Required(ErrorMessage = "Informe um E-mail")]
    [EmailAddress(ErrorMessage = "Informe um E-mail válido")]
    [DisplayName("E-mail")]
    public string Email { get; set; } = String.Empty; 

    public List<Premium> Premiums {get; set; } = new();

}
