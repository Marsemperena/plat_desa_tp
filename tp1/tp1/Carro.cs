using System;
using System.Collections.Generic;

namespace tp1
{
    class Carro
    {
        int id { get; set; }
        Dictionary<Producto, int> productos { get; set; };

        public Carro(int id){
            this.id = id;
        }
        public bool agregarProducto(Producto producto,int cantidad){
            //productos.add(producto,cantidad);
            return true;
        }
        public sacarProductos(){
            
        }

        public override string toString()
        {
            return "Carro: " + this.id + " - " + this.productos.toString();
        }

}
}
