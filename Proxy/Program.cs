using Proxy;

namespace Proxy {
    internal class Program {
        static void Main(string[] args) {
            #region explicação
            // Definição:
            /*
             * Foirnece um objeto que atua como um substituto para um objetop de serviço real usado por um 
             * cliente para controla o acesso a ele;
             * 
             * Permite encapsular a instância de uma classe complexa usando uma instância de outra classe 
             * que possui a mesma interface;
             * 
             * Significa 'no lugar de', ou 'em nome de'
             */

            // Tipos:
            /*
             * Proxy virtual:
             * É um espaço reservado para objetos que consomem muitos recursos para serem criados. Neste
             * contexto, o objeto real só é criado quando um cliente primeiro solicita acesso ou acessa o objeto;
             * 
             * Proxy remoto:
             * Fornece a representação local para um objeto que reside em um endereço/espaço diferente;
             * 
             * Proxy de proteção:
             * Controla o acesso a um objeto principal. Aqui o objeto proxy verifica se o chamador tem as permissões
             * de acesso necessárias antes de encaminha a solicitação;
             */

            // Quando usar:
            /* 
             * Quando precisa-se criar objetos sob demanda, quando suas operações forem solicitadas;
             * Quando temos uma classe com dados sensíveis, onde é necessario fornecer controle de acesso
             * ao objeto original;
             * Quando devemos permitir o acesso a um objeto remoto usando um objeto local (referenciando o remoto)
             */
            #endregion

            Console.WriteLine("### Exemplo de implementação do padrão Proxy ###\n");

            //acesso Programador
            Console.WriteLine("\nFuncionário com perfil 'Programador' acessando " +
                "a Pasta Compartilhada Proxy");

            Funcionario funci1 = new Funcionario("Macoratti", "123456", "Programador");
            PastaCompartilhadaProxy pastaProxy = new PastaCompartilhadaProxy(funci1);
            pastaProxy.OperacaoDeLeituraGravacao();

            //acesso Usuario
            Console.WriteLine("\nFuncionário com perfil 'Usuario' acessando a Pasta " +
                "Compartilhada Proxy");

            Funcionario funci2 = new Funcionario("Amanda", "123456", "Usuario");
            PastaCompartilhadaProxy pastaProxy2 = new PastaCompartilhadaProxy(funci2);
            pastaProxy2.OperacaoDeLeituraGravacao();

            //acesso Ceo
            Console.WriteLine("\nFuncionário com perfil 'Ceo' acessando a " +
                "Pasta Compartilhada Proxy");

            Funcionario funci3 = new Funcionario("Bill Gates", "876543", "Ceo");
            PastaCompartilhadaProxy pastaProxy3 = new PastaCompartilhadaProxy(funci3);
            pastaProxy3.OperacaoDeLeituraGravacao();

            Console.Read();
        }
    }
}
