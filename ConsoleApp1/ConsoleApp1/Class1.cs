using System;


namespace ConsoleApp1
{
    public abstract class animal
    {

        public int cantidadPatas { get; set; }

        public animal (int cantidadPatas)
        {

            this.cantidadPatas = cantidadPatas;

        }

        public abstract string caminar();

        public abstract string descripcion();


    }
}
