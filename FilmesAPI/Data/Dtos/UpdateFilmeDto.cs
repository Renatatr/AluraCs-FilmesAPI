using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class UpdateFilmeDto
{
    [Required(ErrorMessage = "O Título do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O Genero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A Duração do filme é obrigatório")]
    [Range(70, 600, ErrorMessage = "Deve ter entre 70 e 600min")]
    public int Duracao { get; set; }
}