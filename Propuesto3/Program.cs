using System;
using System.Collections.Generic;

namespace pilasycolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 13;
            int copia = numero;
            Stack<int> pila = new Stack<int>();

            while (copia > 0)
            {
                pila.Push(copia % 2);
                copia = copia / 2;
            }

            string binario = "";
            while (pila.Count > 0)
            {
                binario += pila.Pop();
            }

            Console.WriteLine(numero + " en binario: " + binario);
        }
    }
}
