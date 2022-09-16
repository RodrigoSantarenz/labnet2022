using System;


namespace ConsoleApp1
{
    internal class perro : animal
    {
        public perro (int cantidadPatas): base(cantidadPatas)
        {


        }

        public override string caminar()
        {
            return string.Format("yo avanzo en {0} patas", cantidadPatas);
        }

        public override string descripcion()
        {
            throw new NotImplementedException();
        }
    }
}
