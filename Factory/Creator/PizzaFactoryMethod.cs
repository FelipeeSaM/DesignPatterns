﻿namespace Factory
{
    //Creator
    public abstract class PizzaFactory
    {
        public Pizza MontaPizza(string tipo)
        {
            Pizza pizza;
            pizza = CriarPizza(tipo);
            return pizza;
        }
        protected abstract Pizza CriarPizza(string tipo);
    }
}
