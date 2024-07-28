using AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    abstract class FabricaRoupas {
        public abstract Camisa CriarCamisa();
        public abstract Calca CriarCalca();
    }
}
