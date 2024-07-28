using Factory.ConcreteProduct;

namespace Factory
{
    //ConcreteCreator
    public class PizzaFactoryRJ : PizzaFactory
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M"))
            {
                return new PizzaMussarelaRJ();
            }
            if (tipo.Equals("C"))
            {
                return new PizzaCalabresaRJ();
            }
            else return null;
        }
    }
}