using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAuthenticationCrud;

public class Premium
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Título é necessário")]
    [MaxLength(80, ErrorMessage ="Deve ter mais de 80 caracteres")]
    [MinLength(5, ErrorMessage ="Deve ter pelo menos 5 caracteres")]
    [DisplayName("Título")]
    public String Title { get; set; } = String.Empty;
    [DataType(DataType.DateTime)]
    [DisplayName("Início")]
    public DateTime StartDate { get; set; }
    [DataType(DataType.DateTime)]
    [DisplayName("Término")]
    public DateTime EndDate { get; set; }
    [Required]
    [DisplayName("Aluno")]
    public int StudentId { get; set; }

    public Student? Student { get; set; }

}
