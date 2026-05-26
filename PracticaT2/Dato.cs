using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaT2 {
    internal class Dato {
        public int Numero {  get; set; }
        public Dato(int numero) {
            this.Numero = numero;
        }

        public override string ToString() {
            return $"{Numero}";
        }
    }
}
