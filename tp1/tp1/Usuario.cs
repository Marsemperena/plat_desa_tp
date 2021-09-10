using System;

namespace tp1
{
    public abstract class Usuario
    {
            public int id { get; set; }
            public int dni { get; set; }
            public string nombre { get; set; }
            public string mail { get; set; }
            public string password { get; set; }
            
    }
    
    public Usuario(int id, int dni, string nombre, string mail, string password)
    {
        this.id = id;
        this.dni = dni;
        this.nombre = nombre;
        this.mail = mail;
        this.password = password;
        
    }
}
}
