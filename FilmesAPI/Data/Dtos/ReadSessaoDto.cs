﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class ReadSessaoDto
{
    public int FilmeId { get; set; }
    public int CinameId { get; set; }

}