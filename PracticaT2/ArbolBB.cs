using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaT2 {
    internal class ArbolBB {
        public Nodo Raiz {  get; set; }
        public ArbolBB() {
            this.Raiz = null;
        }

        public void Insertar(int n) {
            if(this.Raiz == null) { //arbol vacio
                this.Raiz = new Nodo(n);
                return;
            }

            Nodo padre = null;
            Nodo actual = Raiz;

            while(actual != null) { //buscamos al padre del hijo a insertar
                padre = actual;
                if (actual.Valor.Numero > n) {
                    actual = actual.Izquierda;
                } else if (actual.Valor.Numero < n) {
                    actual = actual.Derecha;
                } else 
                    return; //cuando el nodo ya existe
            }

            //agregamos el nuevo nodo
            Nodo nuevo = new Nodo(n);
            if (padre.Valor.Numero > n) {
                padre.Izquierda = nuevo;
            } else {
                padre.Derecha = nuevo;
            }
        }

        public void PreOrden() {
            PreOrden(Raiz);
        }
        private void PreOrden(Nodo r) {
            if (r != null) {
                Console.Write(r.ToString() + " ");
                PreOrden(r.Izquierda);
                PreOrden(r.Derecha);
            }
        }
        public void InOrden() {
            InOrden(Raiz);
        }
        private void InOrden(Nodo r) {
            if (r != null) {
                InOrden(r.Izquierda);
                Console.Write(r.ToString() + " ");
                InOrden(r.Derecha);
            }
        }
        public void PosOrden() {
            PosOrden(Raiz);
        }
        private void PosOrden(Nodo r) {
            if (r != null) {
                PosOrden(r.Izquierda);
                PosOrden(r.Derecha);
                Console.Write(r.ToString() + " ");
            }
        }
    }
}
