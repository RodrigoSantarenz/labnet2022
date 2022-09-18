using System;

namespace Preactica2Unidad2
{
    public class Logic
    {
      public static void HaceCalor(int num)
        {
            if ( num > 15)
            {
                Console.WriteLine("talindo");
            }
            else
            {
                throw new HaceFrioExeption();
            }
        }
    }
}
