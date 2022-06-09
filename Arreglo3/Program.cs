using System;
using System.Collections.Generic;

namespace Arreglo3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World Cod-ex!");
            int contador1 = 0;
            int contador2 = 0;
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            for(int i=0; i<lista.Count; i++)
            {
                contador1 = contador1 + 1;
                Console.WriteLine("La lista es : " + lista[i]);
            }
            Console.WriteLine("Hay " + contador1 + " elementos");

            Console.WriteLine("******************************");

            lista.Add(9);
            lista.Add(12);
            lista.Add(0);
            lista.Remove(3);
            Console.WriteLine("******************************");
            foreach(int nuevaLista in lista){
                contador2 = contador2 + 1;
                Console.WriteLine("La nueva lista es: " + nuevaLista);
            }
            Console.WriteLine("Añadidos son "+lista[7]);
            Console.WriteLine("Añadidos son " + lista[8]);
            Console.WriteLine("Añadidos son " + lista[9]);
            Console.WriteLine("Cantidad de elementos en la nueva lista es = " + contador2);
        }
       
    }
}
