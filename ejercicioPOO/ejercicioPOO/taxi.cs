using System;



namespace ejercicioPOO
{
    public class Taxi : TransportePublico
    {

        public override string avanzar()
        {
            throw new NotImplementedException();
        }

        public override string detenerse()
        {
            throw new NotImplementedException();
        }


        public Taxi(int pasajeros) : base(pasajeros)
        {
            
        }


        public override string cantidadPasajeros()
        {
            return String.Format($"Taxi: la cantidad de pasajeros es de {getPasajeros()}");
        }
      
    }
}
