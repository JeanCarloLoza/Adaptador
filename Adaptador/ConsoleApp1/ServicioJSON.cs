using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ServicioJSON
    {
        public string devolverTiendas()
        {
            string cJSON = "[{\"idSucursal\":1, \"nombreSucursal\":\"tienda 1\", \"numeroVentas\":10},"+
                "{\"idSucursal\":2, \"nombreSucursal\":\"tienda 2\", \"numeroVentas\":20},"+
                "{\"idSucursal\":3, \"nombreSucursal\":\"tienda 3\", \"numeroVentas\":30}" +
                "]";

            return cJSON;
        }
    }
}
