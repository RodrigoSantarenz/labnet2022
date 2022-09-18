using System;

namespace Preactica2Unidad2
{
    public class HaceFrioExeption : Exception
    {
        public HaceFrioExeption(): base($"Hace un ofri") { }
    }
}
