using System;


namespace ConsoleApp2
{
    internal class avion : veiculo
    {
        public avion (string nombreDeAvion) : base(nombreDeAvion)
        {

        }

        public override void conducir()
        {
            Console.WriteLine("alguien me tiene que manejar");
        }

        public void volar()
        {
            Console.WriteLine("puedo volar xd");
        }

    }
}
