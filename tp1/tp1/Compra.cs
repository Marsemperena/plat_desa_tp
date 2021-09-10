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
        public Dictionary <Producto;int> productos;
        public double total;

        public Compra(Usuario comprador, double total, List<Producto> productosMercado) {
            this.comprador = comprador;
            this.total = total;
            productos = new Dictionary<Producto, int>;
            foreach (Producto product in productosMercado) {
                i = 0;
                productos.add(product, product.getId());
            
            }

        
        
        }



    }
}
