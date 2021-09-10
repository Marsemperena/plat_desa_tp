using System;

namespace tp1
{
    class ClienteFinal
    {
        int id { get; set };

        public ClienteFinal(int id)
        {
            this.id = id;
        }

        string override toString()
        {
            return "id: " + this.id;
        }
    }
}
