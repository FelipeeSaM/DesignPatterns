using Bridge.Domain;
using Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstraction {
    public abstract class AbstractionGeraArquivo {
        protected IGeraArquivo geraArquivo;
        protected AbstractionGeraArquivo(IGeraArquivo geraArquivo) {
            this.geraArquivo = geraArquivo;
        }

        public virtual void GravaArquivo(Funcionario funcionario) {
            geraArquivo.GravaArquivo(funcionario);
        }

    }
}
