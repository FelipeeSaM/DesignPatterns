using Composite.Composite;
using Composite.Leaf;

namespace Composite {
    internal class Program {
        static void Main(string[] args) {
            #region explicação
            // definição:
            /*
             * compõe objetos em estruturas semelhantes a uma árvore para representar hierarquias parte-todo;
             * permite que os clientes tratem objetos individuais e composições de objetos de maneira uniforme (como um único objeto);
             */

            // é composto por:
            /*
             * component:
             *  Interface que descreve operações comuns a elementos simples ou complexos da árvore;
             *  
             * leaf:
             *  um único objeto que não possui subelementos;
             *  
             * composite:
             *  um objeto que possui subelementos;
             */

            // quando usar: 
            /*
             * usar árvore para resolver problema;
             * representar hierarquia todo-parte de objetos;
             * queremos que os clientes ignorem a diferença entre composições de objetos e objetos individuais;
             */
            #endregion

            Organizacao organizacao = new Organizacao { Nome = "JcmSoft Inc." };
            //
            Organizacao departamentoTI = new Organizacao { Nome = " TI " };
            departamentoTI.Add(new Funcionario { Id = 1001, Nome = "Maria", Horas = 8 });
            departamentoTI.Add(new Funcionario { Id = 1002, Nome = "Miguel", Horas = 6 });
            departamentoTI.Add(new Funcionario { Id = 1005, Nome = "Samuel", Horas = 8 });
            //
            Organizacao departamentoContabilidade = new Organizacao { Nome = " Contabilidade " };
            departamentoContabilidade.Add(new Funcionario { Id = 1003, Nome = "Beatriz", Horas = 7 });
            departamentoContabilidade.Add(new Funcionario { Id = 1004, Nome = "Paulo", Horas = 5 });
            //
            organizacao.Add(departamentoTI);
            organizacao.Add(departamentoContabilidade);
            organizacao.GetHoraTrabalhada();
            //
            Console.ReadKey();

        }
    }
}
