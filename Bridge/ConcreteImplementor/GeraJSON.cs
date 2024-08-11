using Bridge.Domain;
using Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bridge.ConcreteImplementor {
    public class GeraJSON : IGeraArquivo {
        private string nomeArquivo = "SalarioFuncionario.json";

        public void GravaArquivo(Funcionario funcionario) {
            var funcionarioSerializado = JsonSerializer.Serialize(funcionario);

            File.WriteAllText(nomeArquivo, funcionarioSerializado);

            Console.WriteLine($"Salário para o Funcionário : {funcionario.Nome} " +
                $"gerado com sucesso em : {nomeArquivo} \n");
        }
    }
}
