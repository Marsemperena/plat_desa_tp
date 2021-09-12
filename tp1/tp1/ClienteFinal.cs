using System;


namespace tp1
{
    public class ClienteFinal : Usuario
    {
        public int cuit { get; set; }

        public ClienteFinal( int id, int cuit, int dni, string nombre, string apellido, string mail, string password) : base(id, dni, nombre, apellido, mail, password)
        {
            this.cuit = cuit;
        }

       public string toString()
        {
            return "Cliente Final - " + base.toString() + "cuit: " + cuit;
        }

    }
}


