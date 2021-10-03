using System;
using System.Collections.Generic;
using dao;

namespace Slc_Mercado

{

    [Serializable]
   public class Carro
    {
        public int id { get; set; }
        public Dictionary<Producto, int> productos { get; set; }

        public Carro() { }
        public Carro(int id){
            this.id = id;
        }

       public bool agregarProducto(Producto producto,int cantidad){
            productos.Add(producto,cantidad);
           return true;
        }
        public void sacarProductos(Producto producto, int cantidad){
           /* if(this.productos.Where(k=>k.Key== producto && k.Value<= cantidad)){
                productos.Remove(producto);
            }else{
                this.productos[producto]=producto.Value - cantidad;
               
            }
           */
        }

        public  string toString()
        {
            return "Carro: " + this.id + " - " + this.productos.ToString();
        }

}
}
