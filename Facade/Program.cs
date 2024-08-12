using Facade1.Facade;
using Facade1.Subsistemas;

namespace Facade {
    internal class Program {
        static void Main(string[] args) {
            // definição:
            /*
             * Fornece uma interface unificada (fachada) para um conjunto de interfaces em um sistema;
             * Define uma interface de nível superior que torna o subsistema mais fácil de usar;
             */

            // quando usar:
            /*
             * Quando queremos simplificar uma sequencia de operações complexas;
             * Quando queremos simplificar a interface com o usuário;
             * Quando queremos fornecer uma interface única e uniforme para as diversas funcionalidades do subsistema;
             * Quando queremos criar sistemas em camadas. Uma fachada provê o ponto de entrada para cada camada do subsistema;
             */

            // Cria uma instância do Facade
            MeuFacade concedeCreditoFacade = new MeuFacade();

            // Cria uma instância de um  novo Cliente informando o nome
            Cliente cliente1 = new Cliente("Eu mesmo");

            //Utiliza o Facade para verificar condições de concessão ou não
            bool resultado = concedeCreditoFacade.ConcederEmprestimo(cliente1, 199000.00);

            //exibe o resultado
            Console.WriteLine($"O empréstimo pleiteado pelo cliente {cliente1.Nome} foi " + (resultado ? "Aprovado" : "Negado"));

            //aguarda
            Console.ReadKey();
        }
    }
}
