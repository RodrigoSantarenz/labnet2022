using PracticaBF.Data;
using PracticaBF.Entities;
using PracticasBF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program :  BaseLogic
    {
        static void Main(string[] args)
        {
            LinqIntermedia linq = new LinqIntermedia();

            int continuar;
            do
            {
                try
                {
                    Console.WriteLine("Los ejercicios van del 1 al 13\nElija el numero de ejercicio que desea ver");
                    Console.WriteLine();
                    int seleccion = int.Parse(Console.ReadLine());

                    switch (seleccion)
                    {
                        case 1:

                            Console.Clear();
                            linq.Ejercicio1();

                            break;

                        case 2:

                            Console.Clear();
                            linq.Ejercicio2();

                            break;

                        case 3:

                            Console.Clear();
                            linq.Ejercicio3();

                            break;

                        case 4:

                            Console.Clear();
                            linq.Ejercicio4();

                            break;

                        case 5:

                            Console.Clear();
                            linq.Ejercicio5();

                            break;

                        case 6:

                            Console.Clear();
                            linq.Ejercicio6();

                            break;

                        case 7:

                            Console.Clear();
                            linq.Ejercicio7();

                            break;

                        case 8:

                            Console.Clear();
                            linq.Ejercicio8();

                            break;
                        case 9:

                            Console.Clear();
                            linq.Ejercicio9();

                            break;

                        case 10:

                            Console.Clear();
                            linq.Ejercicio10();

                            break;

                        case 11:

                            Console.Clear();
                            linq.Ejercicio11();

                            break;

                        case 12:

                            Console.Clear();
                            linq.Ejercicio12();

                            break;

                        case 13:

                            Console.Clear();
                            linq.Ejercicio13();

                            break;

                        default:

                            Console.WriteLine("Ingreso un valor incorrecto");

                            break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Solo numeros.");
                }
                 
                

                Console.WriteLine();

                Console.WriteLine("Ingrese 1 para cotinuar - Ingrese 0 para salir");
                continuar = int.Parse(Console.ReadLine());

                Console.Clear();
            }
            while (continuar != 0);
        }
    } 
}

