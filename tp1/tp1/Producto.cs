using System;


namespace tp1
{
    public class Producto
    {
        public int id;
        public string nombre { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        public Categoria cat { get; set; }
        
        public Producto(String nombre,double precio, int cantidad, Categoria categoria){

            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.cat = categoria;
        
        }

        public  string toString()
        {
            return "Producto: id " + this.id + " - nombre " + this.nombre + " - precio " + this.precio + " - cantidad " + this.cantidad + " - categoria " + this.cat.toString();
        }
    }
}