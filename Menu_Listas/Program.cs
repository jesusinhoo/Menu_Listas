using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista miLista= new Lista();
            int wh = 5;
            while (wh == 5)
            {
                Console.Clear();
                Console.WriteLine("===========MENU LISTAS==========");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Selecciona una opcion: ");
                Console.WriteLine("1.- Insertar Nodo.");
                Console.WriteLine("2.- Imprimir Tamaño.");
                Console.WriteLine("3.- Buscar Nodo.");
                Console.WriteLine("4.- Borrar Nodo.");
                Console.WriteLine("5.- Modificar Nodo.");
                Console.WriteLine("6.- Buscar Valo.");
                Console.WriteLine("7.- Imprimir Lista.");
                Console.WriteLine("8.-  Salir");
                int opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    Console.WriteLine("Agrega un nodo: ");
                    int nodo = int.Parse(Console.ReadLine());   
                    miLista.Add(nodo);
                    //  Console.Clear();
                }
                else if (opc == 2)
                {
                    Console.WriteLine("El tamaño de la lista es de: " + miLista.Count());
                    Console.ReadKey();
                }
                else if (opc == 3)
                {
                    Console.WriteLine("Da la pocision: ");
                    int pos = int.Parse(Console.ReadLine());
                    Console.WriteLine("El valor es: "+miLista.Find(pos));
                    Console.ReadKey();
                }
                else if (opc == 4)
                {

                }
                else if (opc == 5)
                {

                }
                else if (opc == 6)
                {

                }
                else if (opc == 7)
                {
                    Console.Clear() ;
                    miLista.Imprimir(); 
                    Console.ReadKey();
                }
                else if (opc == 8)
                {
                    Console.WriteLine("Saliendo...");
                    wh = 1; 
                    Console.ReadKey();
                }
            }
        }
    }
}
