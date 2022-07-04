using System;

namespace Excepciones
{
    public class BlancoException:Exception
    {
        public BlancoException()
            : base("Cadena en blanco")
        {
        }
    }
}
