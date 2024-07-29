using Factory;

namespace Factory {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("========= Pizzaria ======\n");
            Console.WriteLine("Informe o local (S)São Paulo  (R)Rio de Janeiro");
            var localEscolhido = Console.ReadLine().ToUpper();

            Console.WriteLine("Escolha a pizza (M)ussarela  (C)calabresa");
            var pizzaEscolhida = Console.ReadLine().ToUpper();

            try {
                PizzaFactory pizzaria =
                    PizzaSimpleFactory.CriarPizzaria(localEscolhido);

                var pizza = pizzaria.MontaPizza(pizzaEscolhida);

                Console.WriteLine(pizza.Preparar());
                Console.WriteLine("\nPizza concluida com sucesso");
            }
            catch(Exception ex) {
                Console.WriteLine("Erro :" + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
