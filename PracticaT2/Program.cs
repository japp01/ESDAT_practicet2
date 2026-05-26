using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaT2 {
    internal class Program {
        static void Main(string[] args) {
            ArbolBB arbol = new ArbolBB();
            arbol.Insertar(10);
            arbol.Insertar(7);
            arbol.Insertar(15);
            arbol.Insertar(8);
            arbol.Insertar(1);
            arbol.Insertar(1);

            arbol.PosOrden();
        }
    }
}
