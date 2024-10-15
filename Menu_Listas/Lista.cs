using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Listas
{
    internal class Lista
    {

        private Nodo inicio;
        private int contador;

        public Lista()
        {
            inicio = null;
            contador = 0;
        }

        public void Add(int num)
        {
            Nodo nuevo = new Nodo(num);
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Nodo actual = inicio;
                while (actual.Sig != null)
                {
                    actual = actual.Sig;
                }
                actual.Sig = nuevo;
            }
            contador++;
        }

        public int Count()
        {
            return contador;
        }

        public int Find(int pos)
        {
            Nodo act;
            act = inicio;
            int poss = 0;
            if (act == null)
            {
                Console.WriteLine("Lista vacia.");
            }
            else
            {
                while (act != null)
                {
                    if (act.Sig != null)
                    {
                        act = act.Sig; poss++;
                        if (poss == pos)
                        {
                            return act.Valor;
                        }
                    }
                }
            }
            return -1;
        }

        public void Imprimir()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Nodo act;
                act = inicio;
                while (act != null)
                {
                    Console.Write($"{act.Valor}" + " " + "->" + " ");
                    act = act.Sig;
                }
            }
        }

    }
}
