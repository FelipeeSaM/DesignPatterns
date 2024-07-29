using Prototype.ConcretePrototype;

namespace Prototype {
    public class Program {
        static void Main(string[] args) {
            Soldado soldado = new Soldado();
            soldado.Nome = "Eu";
            soldado.Arma = "ak";
            soldado.Acessorio = new Acessorio { Nome = "bolsa" };

            Soldado soldado_clone1 = (Soldado)soldado.Clone();
            soldado_clone1.Nome = "Ele";
            soldado_clone1.Arma = "fuzil";
            soldado_clone1.Acessorio.Nome = "cinto";

            Soldado soldado_clone2 = (Soldado)soldado.Clone();
            soldado_clone2.Nome = "Nós";
            soldado_clone2.Arma = "arco";
            soldado_clone2.Acessorio.Nome = "oculos";

            Console.WriteLine("soldados:");
            Console.WriteLine($"Soldado original: nome - {soldado.Nome}, arma - {soldado.Arma}, acessorio - {soldado.Acessorio}.");
            Console.WriteLine($"Soldado 1: nome - {soldado_clone1.Nome}, arma - {soldado_clone1.Arma}, acessorio - {soldado_clone1.Acessorio}.");
            Console.WriteLine($"Soldado 1: nome - {soldado_clone2.Nome}, arma - {soldado_clone2.Arma}, acessorio - {soldado_clone2.Acessorio}.");
        }
    }
}
