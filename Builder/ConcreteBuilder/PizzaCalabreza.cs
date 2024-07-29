using Builder.Builder;
using Builder.Product;
using System.Collections.Generic;

namespace Builder.ConcreteBuilder
{
    public sealed class Pizzacalabresa : PizzaBuilder
    {
        public override void PreparaMassa()
        {
            pizza.TipoMassa = TipoMassa.Grossa;
            pizza.TipoBorda = TipoBorda.Normal;
            pizza.Tamanho = Tamanho.Grande;
        }
        public override void IncluiIngredientes()
        {
            pizza.Ingredientes = new List<string> { "calabresa em fatias", 
                "Molho de tomate" }; 
        }
    }
}
