using Factory.ConcreteProduct;

namespace Factory
{
    //ConcreteCreator
    public class PizzaFactorySP : PizzaFactory
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M"))
            {
                return new PizzaMussarelaSP();
            }
            if (tipo.Equals("C"))
            {
                return new PizzaCalabresaSP();
            }
            else return null;
        }
    }
}
