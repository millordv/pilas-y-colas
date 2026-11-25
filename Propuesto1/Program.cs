using System;
using System.Collections.Generic;

namespace pilasycolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pila = new Stack<int>();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Número " + i + ": ");
                int numero = int.Parse(Console.ReadLine());
                pila.Push(numero);
            }

            Console.WriteLine("Al revés:");
            while (pila.Count > 0)
            {
                Console.WriteLine(pila.Pop());
            }
        }
    }
}
