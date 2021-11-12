using System.Collections.Generic;

public class ClienteService : IClienteService
{
    public List<Cliente> Clientes { get; private set; }

    public void AdicionarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
    }

    public void ListarClientes()
    {
        Clientes.ForEach(cliente => System.Console.WriteLine(cliente));
    }

    public Cliente EditarCliente(Cliente cliente)
    {
        var editaCliente = Clientes.Find(c => c.Id == cliente.Id);
        
    }

    public Cliente RemoverCliente(string email)
    {
        var removeCliente = Clientes.Find(c => c.Email.Equals(email));
        Clientes.Remove(removeCliente);
        return removeCliente;
    }
}