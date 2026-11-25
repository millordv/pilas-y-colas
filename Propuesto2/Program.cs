using System;
using System.Collections.Generic;

namespace pilasycolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Ana");
            fila.Enqueue("Luis");
            fila.Enqueue("Marta");
            fila.Enqueue("Pedro");

            while (fila.Count > 0)
            {
                Console.WriteLine("Atendido: " + fila.Dequeue());
            }

            Console.WriteLine("Quedan: " + fila.Count);
        }
    }
}
