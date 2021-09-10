using System;


namespace tp1
{
    class Empresa : Usuario 
        {
        public int cuit { get; set; };
        }



    string override toString()
    {
        //modificar para empresa
        return "Producto: " + this.ID + " - nombre " + this.nombre + " - precio " + this.precio + 
        " - cantidad " + this.cantidad + " - categoria " + this.categoria;
    }
}

