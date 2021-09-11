using System;

using System.Collections.Generic;

namespace tp1
{
    class Compra
    {
        public int id { get; set; }
        public Usuario comprador { get; set; }
        public Dictionary <Producto,int> productos;
        public double total;

        public Compra(Usuario comprador, double total, Dictionary<Producto,int> productosCarrito) {
            this.comprador = comprador;
            productos = productosCarrito;

            foreach (KeyValuePair<Producto, int> kvp in productosCarrito)
            {
                //total += kvp.Key.getPrecio() * kvp.Value; //getPrecio tira error
            }


        }

        string  toString()
        {
            return "ID: "+ this.id + "- Usuario: " + this.comprador.ToString() + "- Productos: " + this.productos.ToString() + "- Total: " + total;
        }



    }
}
