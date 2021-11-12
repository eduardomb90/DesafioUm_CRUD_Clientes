using System;
using System.ComponentModel.DataAnnotations;

public class ClienteJuridico : Cliente
{
    [Required]
    public string RazaoSocial { get; private set; }
    [Required]
    public string NomeFantasia { get; private set; }
    [Required]
    public string Cnpj { get; private set; }

    
    public void CorrigirRazaoSocial(string razao)
    {
        RazaoSocial = razao;
    }
    public ClienteJuridico(string razao, string fantasia, string cnpj, Endereco endereco,string email) : base(endereco, email)
    {
        if(!(razao.Equals(string.Empty) &&
            fantasia.Equals(string.Empty) &&
            ValidaCNPJ.IsCnpj(cnpj)))
            {
                RazaoSocial = razao;
                NomeFantasia = fantasia;
                Cnpj = cnpj;        
            }
            else{
                throw new ArgumentNullException("Os argumentos nao podem ser vazios!"); 
            }
    }

    public override string ToString()
    {
        return $"Razão Social: {RazaoSocial} \nNome Fantasida: {NomeFantasia}\n CNPJ: {Cnpj}";
    }
}