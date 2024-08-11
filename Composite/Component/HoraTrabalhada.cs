using System;

namespace Composite.Component {
    //representa o Component
    public abstract class HoraTrabalhada {
        public HoraTrabalhada() { }
        public string Nome { get; set; }
        public abstract int GetHoraTrabalhada();
        public virtual void Add(HoraTrabalhada component) {
            throw new NotImplementedException();
        }
        public virtual void Remove(HoraTrabalhada component) {
            throw new NotImplementedException();
        }
    }
}
