using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton {
    public class PadraoSingleton {
        private static PadraoSingleton instance = null;
        private static object lockObjeto = new object();
        private static int contador = 0;

        public PadraoSingleton()
        {
            contador++;
            Console.WriteLine($"Instância: {contador}");
        }

        public static PadraoSingleton Instance() {
            if(instance == null) {
                lock (lockObjeto) {
                    if(instance == null) 
                        instance = new PadraoSingleton();
                }
            }
            return instance;
        }
    }
}
