using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AdaptadorJson : IServicio
    {
        ServicioJSON srvJson = new ServicioJSON();
        public List<tienda> devolverTiendas()
        {

            List<tienda> respuesta = JsonConvert.DeserializeObject<List<tienda>>(srvJson.devolverTiendas());

            return respuesta;
        }
    }
}
