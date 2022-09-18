using System;


namespace Preactica2Unidad2
{
    public class DivisorPorCero
    {
        public static void DivisorCero(int y)
        {
            try
            {
                Console.Write("Ingrese un numero: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine(num1 / 0);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finalizo");
            }
            Console.WriteLine("");
        }
 
    }
}
