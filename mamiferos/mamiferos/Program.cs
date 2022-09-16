using System;


namespace mamiferos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            perros miPerro = new perros("sparky");
            Humano miHumano = new Humano("carlos");

            miPerro.presentarme("mora");
            miPerro.ladrar();
            miPerro.respirar();

            Console.WriteLine();

            miHumano.presentarme("carlos");
            miHumano.pensar();
            miHumano.respirar();
            //miHumano.caminar();
            //miPerro.caminar();

            mamiferos miMamifero = new perros("gordo");

            //miMamifero.caminar();

            //mamiferos miMaifero = new Humano("alberto");

            //miMaifero.caminar();

           


            Console.Read();
        }
    }
}
