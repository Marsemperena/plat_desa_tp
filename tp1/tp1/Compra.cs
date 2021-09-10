using System;
using Usuario;
using Producto;
using Mercado;

namespace tp1
{
    class Compra
    {
        public int id { get; set; };
        public Usuario comprador { get; set; };
        public Dictionary <Producto,int> productos;
        public double total;

        public Compra(Usuario comprador, double total, Dictionary<Producto,int> productosCarrito) {
            this.comprador = comprador;
            productos = productosCarrito;

            foreach (KeyValuePair<Producto, int> kvp in productosCarrito)
            {
                total += kvp.Key.getPrecio() * kvp.Value;
            }


        }

        string override toString()
        {
            return "ID: "this.id + "- Usuario: " this.comprador.toString() + "- Productos: " this.productos + "- Total: " + total;
        }



    }
}
