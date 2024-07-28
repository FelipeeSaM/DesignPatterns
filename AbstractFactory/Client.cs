using AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    class Client {
        private readonly Camisa _camisa;
        private readonly Calca _calca;

        public Client(FabricaRoupas fabrica)
        {
            _camisa = fabrica.CriarCamisa();
            _calca = fabrica.CriarCalca();
        }

        public string DescreverRoupa() {
            return $"Estou usando camisa do tipo {_camisa.GetType().Name}, e calça do tipo {_calca.GetType().Name}.";
        }
    }
}
