using System;
using System.ComponentModel.DataAnnotations;

public class Endereco
{
    [Required]
    public Guid Id { get; }
    [Required]    
    public string Cep { get; private set; }
    [Required]
    public string Logradouro { get; private set; }
    [Required]
    public string Numero { get; private set; }
    [Required]
    public string Complemento { get; private set; }
    [Required]
    public string Referencia { get; private set; }
    [Required]
    public string Cidade { get; private set; }
    [Required]
    public string Estado { get; private set; }
}