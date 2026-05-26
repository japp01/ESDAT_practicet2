using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace test {
    internal class ArbolBB {
        public NodoABB Raiz {  get; set; }
        private int count;
        public void Insertar(int valor) {
            NodoABB nuevo = new NodoABB(valor);

            if (Raiz == null) { // arbol vacio
                Raiz = nuevo;
                count++;
                return;
            } 
            
            NodoABB padre = null;
            NodoABB temp = Raiz;

            while(temp != null) { // buscamos el padre del hijo a insertar
                padre = temp;

                if(valor < temp.Dato) {
                    temp = temp.Izquierda;
                }else if(valor > temp.Dato) {
                    temp = temp.Derecha;
                } else  // cuando el nodo ya existe
                    return; 
            }

            if (valor < padre.Dato)  // agregando el nodo
                padre.Izquierda = nuevo;
            else
                padre.Derecha = nuevo;
            count++;
        }

        public int Intermedio() {
            int x = 0;
            int valor = -1;
            bool encontrado = false;
            
            return Intermedio(Raiz,ref valor, ref x, ref encontrado);
        }
        private int Intermedio(NodoABB nodo,ref int valor, ref int x, ref bool encontrado) {
            if (encontrado)
                return valor;

            if (x == count/2 + 1) {               
                valor = nodo.Dato;
                encontrado = true;
            }
            if (x < count/2 + 1) {
                if(nodo.Izquierda != null)
                    valor = Intermedio(nodo.Izquierda, ref valor, ref x, ref encontrado);
                x++;
                if(nodo.Derecha != null)
                    valor = Intermedio(nodo.Derecha, ref valor, ref x, ref encontrado);
            }
            return valor;
        }


        public void OtroInsertar(int valor) => Raiz = OtroInsertar(Raiz, valor);
        private NodoABB OtroInsertar(NodoABB nodo, int valor) {
            if (nodo == null)
                return new NodoABB(valor);
            
            if(valor < nodo.Dato)
                nodo.Izquierda = OtroInsertar(nodo.Izquierda, valor);
            else if(valor > nodo.Dato)
                nodo.Derecha = OtroInsertar(nodo.Derecha, valor);

            return nodo;
        }

        public bool Buscar(int valor, out NodoABB tmp) {
            tmp = Raiz;

            while(tmp != null) {
                if (tmp.Dato == valor)
                    return true;
                else if (valor < tmp.Dato)
                    tmp = tmp.Izquierda;
                else
                    tmp = tmp.Derecha;
            }
            return false;
        }

        public void PreOrden() => PreOrden(Raiz);
        private void PreOrden(NodoABB nodo) {
            if (nodo != null) {
                Console.Write(nodo.ToString() + " ");
                PreOrden(nodo.Izquierda);
                PreOrden(nodo.Derecha);
            }
        }
        public void InOrden() => InOrden(Raiz);
        private void InOrden(NodoABB nodo) {
            if (nodo != null) {
                InOrden(nodo.Izquierda);
                Console.Write(nodo.ToString() + " ");
                InOrden(nodo.Derecha);
            }
        }
        public int Count() => count;
    }
}
