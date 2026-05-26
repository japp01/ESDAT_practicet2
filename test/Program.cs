using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
    internal class Program {
        static void Main(string[] args) {
            ArbolBB arbol = new ArbolBB();
            arbol.Insertar(50);
            arbol.Insertar(25);
            arbol.Insertar(75);
            arbol.Insertar(95);
            arbol.Insertar(15);
            arbol.Insertar(30);
            arbol.Insertar(60);
            arbol.Insertar(65);
            arbol.Insertar(51);

            arbol.InOrden();
            Console.WriteLine();
            Console.WriteLine(arbol.Intermedio());
        }
    }
}
