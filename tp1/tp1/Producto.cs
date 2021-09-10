using System;
using Categoria;

namespace tp1
{
    class Profucto
    {
        public int ID;
        public string nombre { get; set; }
        public double precio { get; set; }
        public int cantidad  { get; set; }
        public Categoria cat { get; set; }

        public Producto(String nombre,double precio, int cantidad, Categoria categoria){

            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.categoria = categoria;
        
        
        
        }
    }
}