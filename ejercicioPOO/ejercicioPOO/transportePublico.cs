using System;


namespace ejercicioPOO
{
    public abstract class TransportePublico
    {
        private int pasajeros;
        
        public int getPasajeros()
        {
            return pasajeros;
        }
   
        public TransportePublico(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public abstract string cantidadPasajeros();



        public abstract string avanzar();


        public abstract string detenerse();
      
    }
}
