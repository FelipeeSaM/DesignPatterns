using Flyweight.ConcreteFlyweight;
using Flyweight.FlyweightFactory;
using System.Diagnostics;

namespace Flyweight {
    internal class Program {
        static void Main(string[] args) {
            #region explicação
            // Definição:
            /*
             * Usado para criar muitos objetos pequenos relacionados sem invocar muito trabalho de 
             * sobrecarga ao fazer isso, melhorando assim o desempenho e a capacidade de manutenção;
             * 
             * Permite que os programas suportem grandes quantidades de objetos, mantendo o baixo
             * consumo de memória;
             * 
             * Compartilha partes do estado do objeto entre vários objetos, assim ele economiza memória 
             * armazenando em cache os mesmos dados usados por objetos diferentes;
             */
            /*
             * O objeto possui duas partes:
             * O estado intrínseco, que é constante e é armazenado com o próprio objeto flyweight na memória;
             * O estado extrínseco, que não é constante e precisa ser calculado em tempo de execução, e não é guardado em memória;
             * O padrão permite que muitas instâncias de um objeto compartilhem seu estado intrínseco, o que reduz
             * o custo associado à criação
             */

            // Quando usar:
            /* 
             * Quando muitos objetos semelhantes serão usados, e o custo de armazenamento for alto;
             * Quando pudermos compartilhar estado entre objetos;
             * Quando alguns objetos compartilhados facilmente substituiriam muitos objetos não compartilhados;
             * Quando precisamos economizar memória usada
             */

            // Vantagens e desvantagens:
            /*
             * Reduz o uso de memória compartilhando objetos pesados;
             * Favorece o cache de dados, permitindo um menor tempo de resposta;
             * Aumenta o desempenho ao reduzir o número de objetos pesados na memória;
             * Cons:
             * Pode introduzir custos de tempo de execução associados à transferência, localização e/ou computação do estado extrínseco,
             * especialmente se ele antes foir armazenado como estado intrínseco;
             * Não tem muita aplicabilidade (segundo o GOF);
             */
            #endregion
            Stopwatch oi = Stopwatch.StartNew();
            Console.WriteLine("\n### Círculos Amarelos ");
            for(int i = 0; i < 3; i++) {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Amarelo");
                circulo.Desenhar();
            }
            Console.WriteLine("\n### Círculos Verdes ");
            for(int i = 0; i < 3; i++) {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Verde");
                circulo.Desenhar();
            }
            Console.WriteLine("\n### Círculos Azuis");
            for(int i = 0; i < 3; ++i) {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Azul");
                circulo.Desenhar();
            }
            Console.WriteLine("\n### Círculos Vermelhos");
            for(int i = 0; i < 3; ++i) {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Vermelho");
                circulo.Desenhar();
            }
            Console.WriteLine("\n### Círculos Pretos");
            for(int i = 0; i < 3; ++i) {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Preto");
                circulo.Desenhar();
            }
            Console.WriteLine(oi.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
