
using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Fabricas {
    class RoupaElegante : FabricaRoupas {
        public override Calca CriarCalca() {
            return new CalcaEsporteFino();
        }

        public override Camisa CriarCamisa() {
            return new CamisaPolo();
        }
    }
}
