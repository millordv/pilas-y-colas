using System;
using System.Collections.Generic;

namespace pilasycolas
{
    internal class Program
    {
        static bool EsPalindromo(string palabra)
        {
            Stack<char> pila = new Stack<char>();
            Queue<char> cola = new Queue<char>();

            foreach (char c in palabra)
            {
                pila.Push(c);
                cola.Enqueue(c);
            }

            while (pila.Count > 0)
            {
                if (pila.Pop() != cola.Dequeue())
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            string[] palabras = { "oso", "casa" };

            foreach (string p in palabras)
            {
                string resultado = EsPalindromo(p) ? "Es palíndromo" : "No es palíndromo";
                Console.WriteLine(p + " -> " + resultado);
            }
        }
    }
}
