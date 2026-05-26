using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
    internal class NodoABB {
        public int Dato { get; set; }
        public NodoABB Izquierda { get; set; }
        public NodoABB Derecha { get; set; }
        public NodoABB(int dato) {
            this.Dato = dato;
        }
        public override string ToString() {
            return Dato.ToString();
        }
    }
}
