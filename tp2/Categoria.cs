using System;


namespace tp1
{
    [Serializable]
    public class Categoria
    {
         public int id { get; set; }
        public string nombre { get; set; }



public Categoria(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

       public string  toString()
        {
            return "Categoria: " + this.id + " - Nombre: " + this.nombre;
        }
    }
}
