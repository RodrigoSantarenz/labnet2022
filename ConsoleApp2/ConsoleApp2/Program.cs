using System;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            coche audi = new coche("audi");
            avion boening = new avion("boening 747");

            audi.arrancarMotor();
            boening.volar();

            

            Console.Read();
        }
    }
}
