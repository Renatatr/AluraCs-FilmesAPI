using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Endereco
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O Logradouro é obrigatório")]
    public string Logradouro { get; set; }
    [Required(ErrorMessage = "O Número é obrigatório")]
    public int Numero { get; set; }

    public virtual Cinema Cinema { get; set; } // não coloca o CinemaId porque o endereço continua existindo sem a necessidade de existir um cinema vinculado
}