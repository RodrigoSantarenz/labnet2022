using System;


namespace mamiferos
{
    class mamiferos
    {
        private string nombreServivo;
        
        public mamiferos(string nombre)
        {
            nombreServivo = nombre;
        }
       
        public void  respirar()
        {
            Console.WriteLine("puedo respirar");
        }

        public virtual void caminar()
        {

        }

    }
}
