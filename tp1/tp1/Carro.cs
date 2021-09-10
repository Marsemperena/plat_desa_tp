using System;

namespace tp1
{
    class Carro
    {
        int ID { get; set; }
        Dictionary<Producto, int> productos { get; set; };

        public Carro(int id; Dictionary<Producto, int> productos){
            this.ID = id;
            this.productos = productos;
    }


    string override toString()
    {
        return "Carro: " + this.ID + " - " + this.productos.toString();
    }

}
}
