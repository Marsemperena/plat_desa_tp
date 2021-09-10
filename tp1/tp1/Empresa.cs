using System;


namespace tp1
{
    class Empresa : Usuario 
        {
            
        }



    string override toString()
    {
        //modificar para empresa
        return "Producto: " + this.ID + " - nombre " + this.nombre + " - precio " + this.precio + " - cantidad " + this.cantidad + " - categoria " + this.categoria;
    }
}

