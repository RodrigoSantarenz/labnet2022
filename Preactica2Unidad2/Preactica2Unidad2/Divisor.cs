using System;

namespace Preactica2Unidad2
{
    public class Divisor
    {
        public static void Division(double y, double x)
        {
            try
            {

                Console.Write("Ingrese un divisor: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese un dividendo: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (num2 == 0)
                {
                    int num1Int = (int)Math.Floor(num1);
                    int num2Int = (int)Math.Floor(num2);
                    Console.WriteLine(num1Int / num2Int);
                }
                else
                {
                    Console.WriteLine(num1 / num2);
                }
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("¿Dividir por 0? ¿Tienes idea de lo loco que se oye eso?");
            }
            catch (FormatException)
            {
                Console.WriteLine("Las letras no se pueden divir y la nada tampoco, creo...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("¿Finalizo con exito? ¿Lo hizo?");
            }

            Console.WriteLine("");
        }
    }
}

