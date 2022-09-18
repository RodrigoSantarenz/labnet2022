using System;

namespace Preactica2Unidad2
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese 1 para ejercicio 1\nIngrese 2 para ejercicio 2\nIngrese 3 para ejercicio 3\nIngrese 0 para salir");
                Console.WriteLine("");
                int seleccion = int.Parse(Console.ReadLine());
                do
                {

                    switch (seleccion)
                    {
                        case 1:
                            DivisorPorCero.DivisorCero(0);
                            break;

                        case 2:
                            Divisor.Division(0, 0);
                            break;

                        case 3:
                            try
                            {
                                Console.Write("Ingresa un numero: ");
                                int num = int.Parse(Console.ReadLine());
                                Logic.HaceCalor(num);

                            }
                            catch (HaceFrioExeption e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Ingrese 1 para ejercicio 1\nIngrese 2 para ejercicio 2\nIngrese 3 para ejercicio 3\nIngrese 0 para salir");
                    seleccion = int.Parse(Console.ReadLine());
                
                }

                while (seleccion != 0);
            }

            catch(FormatException)
            {
                Console.WriteLine("era solo 1, 2 y 3, tal vez 0");
            }
 
            Console.Read();
        }
    }
}
