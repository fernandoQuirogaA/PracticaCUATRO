using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaligadaDOBLE
{
    class Lista
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void insertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.Write(" Ingrese El Dato Que Contendra El Nuevo Nodo: ");
            nuevo.Dato = int.Parse(Console.ReadLine());
            if(primero == null) {
                primero = nuevo;
                primero.Siguiente = null;
                primero.Atras = null;
                ultimo = primero;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Atras = ultimo;
                ultimo = nuevo;
            }
            Console.Write("\n Nuevo Nodo Ingresado Con Exito");
        }


        public void buscarNodo()
        {
            Nodo actual = new Nodo();
            actual = primero;
            bool encontrado = false;
            Console.Write(" Ingresa El Dato Del Nodo A Buscar: ");
            int nodoBuscado = int.Parse(Console.ReadLine());
            while (actual != null && encontrado == false)
            {
                if(actual.Dato == nodoBuscado)
                {
                    Console.WriteLine("\n Nodo Con El Dato ({0}) Encontrado \n", actual.Dato);
                    encontrado = true;
                }
                actual = actual.Siguiente;
            }
            if (!encontrado)
            {
                Console.WriteLine("\n NODO NO ENCONTRADO\n");
            }
        }

        public void desplegarListaPU()
        {
            Nodo actual = new Nodo();
            actual = primero;
            while (actual != null)
            {
                Console.WriteLine(" " + actual.Dato);
                actual = actual.Siguiente;
            }
        }


        public void desplegarListaUP()
        {
            Nodo actual = new Nodo();
            actual = ultimo;
            while(actual != null)
            {
                Console.WriteLine(" " + actual.Dato);
                actual = actual.Atras;
            }

        }
    }
}
