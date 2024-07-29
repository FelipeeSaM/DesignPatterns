using Builder.ConcreteBuilder;
using Builder.Director;

namespace Builder {
    internal class Program {
        static void Main(string[] args) {
            //Director

            // a diferença deste para o abstract é que ele implementa o objeto passo a passo,
            // enquanto que o abstract monta famílias de objetos.
            var pizzaria = new Pizzaria(new Pizzacalabresa());
            pizzaria.MontaPizza();
            var pizza1 = pizzaria.GetPizza();
            pizza1.PizzaConteudo();

            pizzaria = new Pizzaria(new PizzaMussarela());
            pizzaria.MontaPizza();
            var pizza2 = pizzaria.GetPizza();
            pizza2.PizzaConteudo();

            Console.ReadKey();
        }
    }
}
