using System;


namespace ConsoleApp2
{
    internal class coche : veiculo
    {
        public coche(string nombreCoche) : base(nombreCoche)
        {

        }
        
        public void acelerar()
        {
            Console.WriteLine("acelerandooooo");
        }

        public void frenar()
        {
            Console.WriteLine("quereeeee");
        }

        public override void conducir()
        {
            Console.WriteLine("puedo manejar papa");
        }
    }
}
