using System;
using System.Collections.Generic;

namespace tp1
{
   public class Carro
    {
        public int id { get; set; }
        public Dictionary<Producto, int> productos { get; set; }

        public Carro(int id){
            this.id = id;
        }

       public bool agregarProducto(Producto producto,int cantidad){
            Producto prod1 = buscarProducto(producto);
            if (prod1!=null)
            {
                this.productos[prod1] = prod1.cantidad + cantidad;
            }
            else
            {
                productos.Add(producto, cantidad);
            }
           return true;
        }
        public bool sacarProductos(Producto producto, int cantidad){
            foreach(KeyValuePair<Producto,int> prod in productos)
            {
                if (prod.Key == producto) { 
                    if (prod.Value <= cantidad)
                    {
                        productos.Remove(producto);
                    }
                    else
                    {
                        this.productos[prod.Key] = prod.Value - cantidad;
                    }
                    return true;
                }
            }
            return false;
        }

        private Producto buscarProducto(Producto producto)
        {
            foreach (KeyValuePair<Producto, int> prod in productos)
            {
                if (prod.Key == producto)
                {
                    return prod.Key;
                }
            }
            return null;
        }
        public void mostrarTodosLosProductos()
        {
            foreach (KeyValuePair<Producto, int> prod in productos)
            {
                    prod.Key.ToString();
            }
        }

        /*public  string toString()
        {
            return "Carro: " + this.id + " - " + this.productos.ToString();
        }*/

    }
}
