using System;


namespace tp1
{
    public class ClienteFinal : Usuario
    {
        public int cuil { get; set; }

        public ClienteFinal( int id, int cuil, int dni, string nombre, string apellido, string mail, string password) : base(id, dni, nombre, apellido, mail, password)
        {
            this.cuil = cuil;
        }

       public string toString()
        {
            return "Cliente Final - " + base.toString() + " - cuil: " + cuil;
        }

    }
}


