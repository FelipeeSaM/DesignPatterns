﻿using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent {
    public class Pizza : IPizza {
        public decimal Preco() {
            var preco = 10.00M;
            return preco;
        }

        public string Opcionais() {
            var pizza = "Pizza padrão ou normal";
            return pizza;
        }
    }
}
