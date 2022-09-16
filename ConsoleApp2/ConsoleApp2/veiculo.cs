using System;

namespace ConsoleApp2
{
    internal class veiculo
    {
        private string nombreVeiculo;
        public veiculo (string nombre)
        {
            nombreVeiculo = nombre;
        }

        

        public void arrancarMotor()
        {
            Console.WriteLine("Zúmbale mambo pa' que mi gata prenda lo' motore'");
        }

        public void paraMotor()
        {
            Console.WriteLine("para la maquina");
        }

        public virtual void conducir()
        {
            Console.WriteLine("me tienen que manejar");
        }

    }
}
