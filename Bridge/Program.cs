using Bridge.ConcreteImplementor;
using Bridge.Domain;
using Bridge.RefinedAbstration;

namespace Bridge {
    internal class Program {
        static void Main(string[] args) {
            #region explicação
            // quando usar:
            /*
             * quando queremos ocultar os detalhes de implementação do cliente;
             * quando queremos evitar o forte acoplamento entre a abstração e a sua implementação;
             * quando queremos alterar a implementação sem compilar a abstração;
             * quando queremos compartilhar uma implementação entre vários objetos e isso deve ser escondido do cliente;
             */

            // pros e contras:
            /* 
             * estimula o uso de um código fracamento acoplado;
             * aumenta a capacidade de manutenção e reutilização do código e reduz a duplicação;
             * ajuda a promover o princípio open-closed;
             * facilita a extensibilidade
             */
            #endregion

            // RedefinedAbstraction recebe via construtor em tempo de execução 
            // o tipo especifico de formato para gerar o arquivo
            // e usa a classe base AbstractionGeraArquivo para obter uma instância
            // de IGeraArquivo (Bridge)
            CalculaSalario calculaSalario = new CalculaSalario(new GeraXML());

            //define os dados do funcionário
            Funcionario funcionario = new Funcionario {
                Id = 101,
                Nome = "Eu mesmo",
                SalarioBase = 3000,
                Incentivo = 2000
            };

            //processa o salario
            calculaSalario.ProcessaSalarioFuncionario(funcionario);

            //altera o valor do incentivo em tempo de execução
            funcionario.Incentivo = 2500;

            //altera o formato para gerar o arquivo em tempo de execução
            calculaSalario = new CalculaSalario(new GeraJSON());

            calculaSalario.ProcessaSalarioFuncionario(funcionario);

            Console.ReadKey();
        }
    }
}
