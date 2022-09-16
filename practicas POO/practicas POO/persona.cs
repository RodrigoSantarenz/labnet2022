using System;


namespace practicas_POO
{
    public class persona : Animal, IDialogos
    {
        public persona(int cantidadPatas) : base(cantidadPatas)
        {

        }
        public override string caminar()
        {
            return string.Format("hola soy una persona y camino con mis {0} pies ", cantidadPatas);
        }

        public string saludo()
        {
            return $"hola te estoy saludandoo!!";
        }
    }
}
