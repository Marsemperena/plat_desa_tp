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
            productos.Add(producto,cantidad);
           return true;
        }
        public void sacarProductos(Producto producto, int cantidad){
            if(this.productos.Where(k=>k.Key== producto && k.Value<= cantidad)){
                productos.Remove(producto);
            }else{
                this.productos.Where(k => k.Key == producto) k.Value == k.Value - cantidad;
               
            }
        }

        public  string toString()
        {
            return "Carro: " + this.id + " - " + this.Productos.ToString();
        }

}
}
