using System;


namespace tp1
{
    public  class Usuario
    {
        public int id { get; set; }
        public int dni { get; set; }
        public string nombre { get; set;}
        public string apellido { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public Carro MiCarro { get; set; }

        public Usuario() { }
        public Usuario(int id, int dni, string nombre, string apellido, string mail, string password)
        {
            this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.password = password;

        }

            public string toString()
        {
            return "Usuario: " + this.id + " - dni " + this.dni + " - nombre " + this.nombre + " - apellido " + this.apellido + " - mail " + this.mail; // " - Carro :" + MiCarro.toString();
        }
    }


}

