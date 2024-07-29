using Builder.Builder;
using Builder.Product;

namespace Builder.Director
{
    public class Pizzaria
    {
        private readonly PizzaBuilder builder;
        public Pizzaria(PizzaBuilder builder)
        {
            this.builder = builder;
        }

        //Construct
        public void MontaPizza()
        {
            builder.CriaPizza();
            builder.PreparaMassa();
            builder.IncluiIngredientes();
        }

        public Pizza GetPizza()
        {
            return builder.GetPizza();
        }
    }
}
