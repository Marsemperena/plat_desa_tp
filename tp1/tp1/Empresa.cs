using System;


namespace tp1
{
    class Empresa : Usuario 
        {
        public int cuit { get; set; }



        public string toString()
        {
            //modificar para empresa
            return "empresa "; // + this.cuit;
        }
    }




}

