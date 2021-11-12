using System;
using System.ComponentModel.DataAnnotations;

public class ClienteFisico : Cliente
{
    [Required]
    public string Nome { get; private set; }
    [Required]
    public string Cpf { get; private set; }
    [Required]
    public DateTime Nascimento { get; private set; }
    public int Idade { get; }
    
    public ClienteFisico(string nome, string cpf, DateTime anoNascimento, Endereco endereco, string email) : base(endereco, email)
    {
        if(!(nome.Equals(string.Empty) &&
            cpf.Equals(string.Empty)))
            {
                Nome = nome;
                
                if(ValidaCPF.IsCpf(cpf))
                    Cpf = cpf;
                
                Nascimento = anoNascimento;
                Idade = CalculaIdade(anoNascimento);
            }
        
    }

    public void CorrigirNome(string nome)
    {
        Nome = nome;
    }

    private int CalculaIdade(DateTime anoNascimento)
    {
        var anos = DateTime.Now.Year - anoNascimento.Year;

        if(DateTime.Now.DayOfYear > anoNascimento.DayOfYear)
            return anos--;

        return anos; 
    }

    public override string ToString()
    {
        return $"Nome: {Nome} \nCPF: {Cpf}";
    }
}