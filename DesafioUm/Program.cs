using System;

namespace DesafioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            IClienteService clientes = new ClienteService();
            Cliente cliente = new ClienteFisico("Eduardo", "08969625470", new DateTime(1990,10,23), new Endereco("51020190", "Rua Rangel", "12", null, "Igreja de Belem", 
                                                "Recife", "PE"), "edu@email.com");

        }
    }
}
