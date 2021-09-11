using System;

namespace tp1
{
    class ClienteFinal
    {
        public int cuit { get; set; }

        public ClienteFinal(int cuit)
        {
            this.cuit = cuit;
        }

        string  toString()
        {
            return "cuit: " + this.cuit;
        }
    }
}


