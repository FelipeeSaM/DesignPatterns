using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;

namespace Decorator {
    internal class Program {
        static void Main(string[] args) {
            #region explicação
            // definição:
            /*
             * atribui responsabilidades adicionais a um objeto de forma dinâmica sem afetar
             * o comportamento de outros objetos da mesma classe;
             * fornece uma alternativa flexível à herança para estender uma funcionalidade;
             * permite estender (decorar) de forma dinâmica (em tempo de execução) as características
             * (propriedades e comportamentos) de uma classe qualquer;
             * Um objeto tem uma referência com outro objeto e delega a ele alguma funcionalidade;
             */

            // quando usar
            /*
             * quando houver necessidade de anexar ou remover comportamento de apenas algumas instâncias
             * de uma classe, ao invés de todas as instâncias da classe;
             * quando a extensão através de herança for impraticável (múltiplas);
             * quando tempos uma classe que não pode ser herdada, por estarmos já herdando de alguma outra classe; <<<<
             * quando queremos adicionar responsabilidades a objetos individuais de forma dinâmica 
             * e transparente, sem afetar outros objetos;
             * quando não podemos usar herança;
             */

            // vantagens
            /*
             * mais flexível que herança, pois adiciona responsabilidade em tempo de execução, e não em tempo de
             * compilação, como a herança faz;
             * pode ter qualquer número de decoradores e em qualquer ordem;
             * estende a funcionalidade de um objeto sem afetar outros objetos;
             */
            #endregion

            IPizza pizza = new Pizza();

            Console.WriteLine(pizza.Opcionais());
            Console.WriteLine($"Preco R$ {pizza.Preco()}\n");
            Console.WriteLine("Tecle algo para aplicar o padrão Decorator");
            Console.ReadKey();

            Console.WriteLine("------ Aplicando o Decorator ------------------");

            IPizza pizza2 = new Pizza();
            IPizza massaEspecial = new MassaEspecialDecorator(pizza2);
            IPizza baconDecorator = new BaconDecorator(massaEspecial);
            IPizza bordaDecorator = new BordaRecheadaDecorator(baconDecorator);

            //Exibe Tipo e Preco
            Console.WriteLine(bordaDecorator.Opcionais());
            Console.WriteLine($"Preco Total R$ : {bordaDecorator.Preco()}\n");
            Console.ReadKey();
        }
    }
}
