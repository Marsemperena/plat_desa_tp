using System;

namespace tp1
{
    public class Categoria
    {
         public int id { get; set; }
        string nombre { get; set; }



public Categoria(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

       public string  toString()
        {
            return "Categoria: " + this.id + " - " + this.nombre;
        }
    }
}
