using System;
using System.Collections.Generic;

namespace pilasycolas
{
    internal class Program
    {
        static bool EstaBalanceada(string texto)
        {
            Stack<char> pila = new Stack<char>();

            foreach (char c in texto)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    pila.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (pila.Count == 0)
                        return false;

                    char abierto = pila.Pop();

                    if (c == ')' && abierto != '(')
                        return false;
                    if (c == ']' && abierto != '[')
                        return false;
                    if (c == '}' && abierto != '{')
                        return false;
                }
            }

            return pila.Count == 0;
        }

        static void Main(string[] args)
        {
            string[] pruebas = { "{[(1+2)*3]}", "{[(1+2])}" };

            foreach (string p in pruebas)
            {
                string r = EstaBalanceada(p) ? "Balanceada" : "No balanceada";
                Console.WriteLine(p + " -> " + r);
            }
        }
    }
}
