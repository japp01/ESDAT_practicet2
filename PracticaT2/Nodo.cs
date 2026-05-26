using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaT2 {
    internal class Nodo {
        public Dato Valor { get; set; }
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }

        public Nodo(int numero) {
            this.Valor = new Dato(numero);
        }
        public override string ToString() {
            return Valor.ToString();
        }
    }
}
