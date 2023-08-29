using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateEnderecoDto
{
    [Required(ErrorMessage = "O Logradouro é obrigatório")]
    public string Logradouro { get; set; }
    [Required(ErrorMessage = "O Número é obrigatório")]
    public int Numero { get; set; }
}