using System;

namespace SimpleFactory
{
    public class Pizzacalabresa : Pizza
    {
        public Pizzacalabresa()
        {
            Nome = "Pizza de calabresa";
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
