namespace Singleton {
    internal class Program {
        static void Main(string[] args) {
            Parallel.Invoke(
                () => AcessoThread1(),
                () => AcessoThread2()
                );
            Console.ReadLine();
        }

        private static void AcessoThread1() {
            PadraoSingleton s1 = PadraoSingleton.Instance();
            Console.WriteLine("Thread 1");
        }

        private static void AcessoThread2() {
            PadraoSingleton s1 = PadraoSingleton.Instance();
            Console.WriteLine("Thread 2 ");
        }
    }
}
