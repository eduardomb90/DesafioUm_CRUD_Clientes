using System;

namespace DesafioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteService clientes = new ClienteService();
            Cliente cliente = new ClienteFisico("Eduardo", "08369525161", new DateTime(1990,10,23), new Endereco("51020190", "Rua Rangel", "12", null, "Igreja de Belem", 
                                                "Recife", "PE"), "edu@email.com");

            
            clientes.AdicionarCliente(cliente);
            clientes.ListarClientes();

        }
    }
}
