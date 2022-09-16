using System;
using System.Collections.Generic;

namespace practicas_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {



            List<Animal> list = new List<Animal>();

            list.Add(new persona(2));
            list.Add(new gato(4));

            foreach (var item in list)
            {
                Console.WriteLine(item.caminar());
               
            }

            persona miPerosona = new persona(2);
            Console.WriteLine(miPerosona.saludo());
            
            Console.Read();

        }
    }
}
