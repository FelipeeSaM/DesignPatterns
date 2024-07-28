using Factory;
using System;

namespace Factory
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactory CriarPizzaria(string local)
        {
            PizzaFactory pizzaria;
            switch (local)
            {
                case "S":
                    pizzaria = new PizzaFactorySP();
                    break;
                case "R":
                    pizzaria = new PizzaFactoryRJ();
                    break;
                default:
                    throw new ApplicationException($"A pizzaria {local} não foi criada");
            }
            return pizzaria;
        }
    }
}
