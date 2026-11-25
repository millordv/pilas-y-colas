using System;
using System.Collections.Generic;

namespace pilasycolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> impresion = new Queue<string>();
            impresion.Enqueue("Informe.docx");
            impresion.Enqueue("Foto.png");
            impresion.Enqueue("Tarea.pdf");

            while (impresion.Count > 0)
            {
                string documento = impresion.Dequeue();
                Console.WriteLine("Imprimiendo " + documento + " (faltan " + impresion.Count + ")");
            }
        }
    }
}
