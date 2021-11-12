using System;
using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Required]
    public Guid Id { get; }
    [Required]
    public Endereco Endereco { get; private set; }
    
    [Required(ErrorMessage = "Informe o seu email")]
    [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Informe um email válido...")]
    public string Email { get; private set; }
    public Contato[] Contatos { get; set; }

    public Cliente(Endereco endereco, string email)
    {
        if(email.Equals(string.Empty))
        {
            Id = Guid.NewGuid();
            Email = email;
        }

        Contatos = new Contato[3];
    }
}