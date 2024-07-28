using AbstractFactory.Fabricas;

namespace AbstractFactory {
    internal class Program {
        static void Main(string[] args) {
            Client donoDePosto = new Client(new RoupaElegante());
            Console.WriteLine($"Dono de posto diz: {donoDePosto.DescreverRoupa()} \n");

            Client estudanteVagabundo = new Client(new RoupaCasual());
            Console.WriteLine($"Estudante diz: {estudanteVagabundo.DescreverRoupa()}");
        }
    }
}
