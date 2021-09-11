using System;

namespace tp1
{
    class Categoria
    {
         int ID { get; set; }
        string nombre { get; set; }



public Categoria(int id, string nombre)
        {
            this.ID = id;
            this.nombre = nombre;
        }

       public string  toString()
        {
            return "Categoria: " + this.ID + " - " + this.nombre;
        }
    }
}
