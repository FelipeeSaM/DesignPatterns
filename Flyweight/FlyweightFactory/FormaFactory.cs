using Flyweight.ConcreteFlyweight;
using Flyweight.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.FlyweightFactory {
    //FlyweightFactory
    public class FormaFactory {
        private static Dictionary<string, IForma> formas = new Dictionary<string, IForma>();

        // cria e gerencia objetos
        public static IForma GetForma(string chave) {
            IForma forma;
            if(formas.ContainsKey(chave)) {
                return formas[chave];
            } else {
                if(chave == "circulo") {
                    forma = new Circulo();
                    formas.Add("circulo", forma);
                } else {
                    throw new Exception("Este tipo de objeto não pode ser criado");
                }
            }
            return forma;
        }
    }
}
