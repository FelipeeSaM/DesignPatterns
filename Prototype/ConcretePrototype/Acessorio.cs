using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.ConcretePrototype {
    public class Acessorio : ICloneable {
        public string Nome { get; set; }

        public object Clone() {
            return (Acessorio)this.MemberwiseClone();
        }

        public override string ToString() {
            return Nome;
        }
    }
}
