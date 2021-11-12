using System.Collections.Generic;

public class ClienteService : IClienteService
{
    public List<Cliente> Clientes { get; private set; }

    public ClienteService()
    {
        Clientes = new List<Cliente>();
    }
    
    public void AdicionarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
    }

    public void ListarClientes()
    {
        Clientes.ForEach(cliente => System.Console.WriteLine(cliente.ToString()));
    }

    public Cliente EditarCliente(Cliente cliente, string nome)
    {
        var editaCliente = Clientes.Find(c => c.Id == cliente.Id);
        System.Console.WriteLine(editaCliente);

        if(editaCliente is ClienteFisico)
        {
            var clienteFisico = editaCliente as ClienteFisico;
            clienteFisico.CorrigirNome(nome);
        }

        if(editaCliente is ClienteJuridico)
        {
            var clienteJuridico = editaCliente as ClienteJuridico;
            clienteJuridico.CorrigirRazaoSocial(nome);
        }
        

        return editaCliente;

    }

    public Cliente RemoverCliente(string email)
    {
        var removeCliente = Clientes.Find(c => c.Email.Equals(email));
        Clientes.Remove(removeCliente);
        return removeCliente;
    }
}