using System;

namespace mamiferos
{
     class Humano : mamiferos
    {

        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }

        public void presentarme(string nombreHumno)
        {
            Console.WriteLine("hola soy " + nombreHumno);
        }
      
        public void pensar()
        {
            Console.WriteLine("puedo pensar");
        }

        public override void caminar()
        {
            Console.WriteLine("camino en 2 patas");
        }

        
    }
}
