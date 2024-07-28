using System;

namespace SimpleFactory
{
    public sealed class SimpleFactory
    {
        public static Pizza CriaPizza(string tipo)
        {
            Pizza pizza;
            switch (tipo)
            {
                case "C":
                    pizza = new PizzaCalabreza();
                    break;
                case "M":
                    pizza = new PizzaMussarela();
                    break;
                default:
                    throw new ApplicationException($"A pizza de '{tipo}' não foi criada");
            }
            return pizza;
        }
    }
}
