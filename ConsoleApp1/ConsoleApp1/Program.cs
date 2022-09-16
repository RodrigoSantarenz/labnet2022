using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<animal> animales = new List<animal>
            {
                new persona (2),
                new perro (4)
            };


            foreach (var item in animales)
            {
                Console.WriteLine(item.caminar());
            }

            Console.Read();

        }
    }
}
