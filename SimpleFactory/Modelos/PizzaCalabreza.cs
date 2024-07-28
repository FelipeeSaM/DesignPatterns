using System;

namespace PizzaSimpleFactory
{
    public class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza()
        {
            Nome = "Pizza de Calabreza";
        }
        public override void Preparar()
        {
            Console.WriteLine($"Preparando pizza de {Nome}");
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo} min.");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando pizza de {Nome}");
        }
    }
}
