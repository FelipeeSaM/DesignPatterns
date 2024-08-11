using Bridge.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementor {
    public interface IGeraArquivo {
        void GravaArquivo(Funcionario funcionario);
    }
}
