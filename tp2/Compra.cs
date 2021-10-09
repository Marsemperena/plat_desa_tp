using System;

using System.Collections.Generic;
using tp1;

namespace Slc_Mercado
{
    public class Compra
    {
        public int id { get; set; }
        public Usuario comprador { get; set; }
        public Dictionary <Producto,int> productos;
        public double total { get; set; }

        public Compra(int id,Usuario comprador, Dictionary<Producto,int> productosCarrito) {
            this.comprador = comprador;
            this.productos = productosCarrito;
            foreach (KeyValuePair<Producto, int> kvp in productosCarrito)
            {
                this.total += kvp.Key.precio * kvp.Value; 

            }


        }

        public string toString()
        {
            return "ID: "+ this.id + "- Usuario: " + this.comprador.ToString() + "- Productos: " + this.productos.ToString() + "- Total: " + this.total;
        }

        internal double calcularCompra()
        {
            double suma = 0;
            foreach (KeyValuePair<Producto, int> kvp in productos)
            {
                suma += kvp.Key.precio * kvp.Value; //revisar getter

            }

            return suma;
        }
    }
}
