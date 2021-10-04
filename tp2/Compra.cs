using System;

using System.Collections.Generic;

namespace Slc_Mercado
{
    public class Compra
    {
        public int id { get; set; }
        public Usuario comprador { get; set; }
        public Dictionary <Producto,int> productos;
        public double total { get; set; }

        public Compra(Usuario comprador, double total, Dictionary<Producto,int> productosCarrito) {
            this.comprador = comprador;
            this.productos = productosCarrito;
            this.total = total;

            foreach (KeyValuePair<Producto, int> kvp in productosCarrito)
            {
                this.total += kvp.Key.precio * kvp.Value; //revisar getter

            }


        }

        string  toString()
        {
            return "ID: "+ this.id + "- Usuario: " + this.comprador.ToString() + "- Productos: " + this.productos.ToString() + "- Total: " + this.total;
        }



    }
}
