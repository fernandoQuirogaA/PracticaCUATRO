using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaligadaDOBLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int opcionMenu = 0;
            do
            {
                Console.WriteLine("\n |....................................|");
                Console.WriteLine(" |         # L I S T A / D O B L E #    |");
                Console.WriteLine(" |......................................|");
                Console.WriteLine(" | 1. Insertar   |   5. Desplegar P.U   |");
                Console.WriteLine(" | 2. Buscar     |   6. Desplegar U.P   |");
                Console.WriteLine(" | 3. Modificar  |   7. Salir           |");
                Console.WriteLine(" | 4. Eliminar   |                      |");
                Console.WriteLine(" |......................................|");
                Console.Write(" Escoja Una Opcion: ");
                opcionMenu = int.Parse(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("\n\n INSERTAR NODO EN LA LISTA \n");
                        l.insertarNodo();
                        break;
                    case 2:
                        Console.WriteLine("\n\n INSERTAR NODO EN LA LISTA \n");
                        l.buscarNodo();
                        break;
                    case 3:
                        Console.WriteLine("\n\n INSERTAR NODO EN LA LISTA \n");
                       // l.modificarNodo();
                        break;
                    case 4:
                        Console.WriteLine("\n\n INSERTAR NODO EN LA LISTA \n");
                       // l.eliminarNodo();
                        break;
                    case 5:
                        Console.WriteLine("\n\n INSERTAR NODO EN LA LISTA \n");
                        l.desplegarListaPU();
                        break;
                    case 6:
                        Console.WriteLine("\n\n INSERTAR NODO EN LA LISTA \n");
                        l.desplegarListaUP();
                        break;
                    case 7:
                        Console.WriteLine("\n\n Programa Finalizado \n");
                        break;
                    default:
                        Console.WriteLine("\n\n Opcion No Valida \n");
                        break;

                }

            }
            while (opcionMenu != 7);
        }
    }
}
