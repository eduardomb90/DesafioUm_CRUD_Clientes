using System;
using System.Collections.Generic;

public interface IClienteService
{
    void AdicionarCliente(Cliente cliente);
    Cliente EditarCliente(Cliente cliente);
    Cliente RemoverCliente(string nome);
    void ListarClientes();

}