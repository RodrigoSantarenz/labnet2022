using System;


namespace ejercicioPOO
{
    public class Omnibus : TransportePublico
    {


        public override string avanzar()
        {
            throw new NotImplementedException();
        }

        public override string detenerse()
        {
            throw new NotImplementedException();
        }

        public Omnibus(int pasajeros) : base(pasajeros)
        {

        }
    
        public override string cantidadPasajeros()
        {
            return String.Format($"Omnibus: la cantidad de pasajeros es de {getPasajeros()}");

        }

    } 
}
