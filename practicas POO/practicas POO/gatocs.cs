using System;


namespace practicas_POO
{
    public class gato : Animal
    {
        public gato(int cantidadPatas) : base(cantidadPatas)
        {
        }

        public override string caminar()
        {
            return $"soy un gato y camino con mis {cantidadPatas} patas";
        }
    }
}
