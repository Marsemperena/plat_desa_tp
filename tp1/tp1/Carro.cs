using System;

namespace tp1
{
    class Carro
    {
        int id { get; set; }
        Dictionary<Producto, int> productos { get; set; };

        public Carro(int id){
            this.id = id;
        }
        public agregarProducto(Producto producto,int cantidad){
            productos.add(producto,cantidad);
        }
        public sacarProductos(){
            
        }

        string override toString()
        {
            return "Carro: " + this.ID + " - " + this.productos.toString();
        }

}
}
