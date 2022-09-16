using System;


namespace practicas_POO
{
    public abstract class Animal
    {
       public Animal(int cantidadPatas)
        {
            this.cantidadPatas = cantidadPatas;
        }

        public int cantidadPatas { get; }

        public abstract string caminar();


        //public int patas { get; set; }
        //private int patas;

        /*public int getPatas()
        {
            return patas;
        }*/
    }
}
