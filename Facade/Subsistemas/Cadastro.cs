using System;

namespace Facade.Subsistemas
{
    public class Cadastro
    {
        public void CadastrarCliente(Cliente cliente)
        {
            Console.WriteLine($"Cadastro do cliente {cliente.Nome} concluído.");
        }
    }
}
