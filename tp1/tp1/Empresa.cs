using System;


namespace tp1
{
    class Empresa : Usuario 
        {
        public int cuit { get; set; }
        }



    string override toString()
    {
        //modificar para empresa
        return "empresa" + this.cuit;
    }
}

