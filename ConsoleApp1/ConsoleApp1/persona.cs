using System;


namespace ConsoleApp1
{
    public class persona : animal
    {
        public persona(int cantidadPatas) : base(cantidadPatas)
        {

        }

        public override string caminar()
        {
            return $"Yo avanzo en {cantidadPatas} patas";
        }

        public override string descripcion()
        {
            throw new NotImplementedException ();
        }


    }
}
