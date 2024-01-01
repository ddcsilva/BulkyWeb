﻿using System.ComponentModel.DataAnnotations;

namespace Bulky.Models;

public class Produto
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Titulo { get; set; }

    public string Descricao { get; set; }

    [Required]
    public string ISBN { get; set; }

    [Required]
    public string Autor { get; set; }

    [Required]
    [Range(1, 1000)]
    [Display(Name = "Lista de Preço")]
    public double ListaPreco { get; set; }

    [Required]
    [Range(1, 1000)]
    [Display(Name = "Preço para 1-50")]
    public double Preco { get; set; }

    [Required]
    [Range(1, 1000)]
    [Display(Name = "Preço para 50+")]
    public double Preco50 { get; set; }

    [Required]
    [Range(1, 1000)]
    [Display(Name = "Preço para 100+")]
    public double Preco100 { get; set; }
}
