using System;
using Carro;

namespace tp1
{
    public abstract class Usuario
    {
        public int id { get; set; };
        public int dni { get; set; };
        public string nombre { get; set; };
        public string mail { get; set; };
        public string password { get; set; };
        public Carro MiCarro;
    }
    
    public Usuario(int id, int dni, string nombre, string mail, string password)
    {
        this.id = id;
        this.dni = dni;
        this.nombre = nombre;
        this.mail = mail;
        this.password = password;  
    }

    string override toString()
    {
        return "Usuario: " + this.id + " - dni " + this.dni + " - nombre " + this.nombre + " - mail " + this.mail + " - password " + this.password + " - Carro :" + MiCarro.toString();
    }
}
}
