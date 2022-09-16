

using System;

namespace mamiferos
{
     class perros : mamiferos
    {
        public perros(string nombrePerro) : base(nombrePerro)
        {

        }

        public void presentarme(string nombrePerro)
        {
            Console.WriteLine("guau guau soy " + nombrePerro);
        }

        public void ladrar()
        {
            Console.WriteLine("gua gua");
        }

        public override void caminar()
        {
            Console.WriteLine("camino en 4 patas");
        }

    }
}
