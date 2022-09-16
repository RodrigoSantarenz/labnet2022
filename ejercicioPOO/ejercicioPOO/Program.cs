using System;
using System.Collections.Generic;

namespace ejercicioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese 1 para Taxi\ningrese 2 para Omnibus\n");
            int respuesta = int.Parse(Console.ReadLine());
            
            //taxi
            
            if (respuesta == 1)
            {
                Console.WriteLine("ingrese cantidad de pasajeros");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese cantidad de pasajeros");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese cantidad de pasajeros");
                int num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese cantidad de pasajeros");
                int num4 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese cantidad de pasajeros");
                int num5 = int.Parse(Console.ReadLine());

                List<TransportePublico> transportePublicos = new List<TransportePublico>
            {
               new Taxi(num1),
               new Taxi(num2),
               new Taxi(num3),
               new Taxi(num4),
               new Taxi(num5),
             
            };
                foreach (var item in transportePublicos)
                {
                    Console.WriteLine(item.cantidadPasajeros());
                }
            }
           
            //omnibus
            
            else if (respuesta == 2)
            {
                Console.WriteLine("ingrese cantidad de pasajeros");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese cantidad de pasajeros");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese cantidad de pasajeros");
                int num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese cantidad de pasajeros");
                int num4 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese cantidad de pasajeros");
                int num5 = int.Parse(Console.ReadLine());

                List<TransportePublico> transportePublicos = new List<TransportePublico>
            {
               new Omnibus(num1),
               new Omnibus(num2),
               new Omnibus(num3),
               new Omnibus(num4),
               new Omnibus(num5),
            };

                foreach (var item in transportePublicos)
                {
                    Console.WriteLine(item.cantidadPasajeros());
                }
            }

            Console.Read();
        }
    }
}
