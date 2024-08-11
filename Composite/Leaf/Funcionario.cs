using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leaf {
    //Representa o Leaf
    public class Funcionario : HoraTrabalhada {
        public int Id { get; set; }
        public int Horas { get; set; }
        public override int GetHoraTrabalhada() {
            Console.WriteLine($"O Funcionário {Id}-{Nome} registrou {Horas} trabalhadas");
            return Horas;
        }
    }
}
