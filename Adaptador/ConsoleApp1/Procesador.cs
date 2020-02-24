using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Procesador : IProcesador
    {
        IServicio servicio;

        public Procesador(IServicio servicio)
        {
            this.servicio = servicio;
        }
        public void mostrarTiendas()
        {
            List<tienda> lstTienda = servicio.devolverTiendas();
            foreach (var t in lstTienda)
            {
                Console.WriteLine(string.Format("La tienda {0} con id {1} vendio {2} productos",
                    t.nombreSucursal, t.idSucursal, t.numeroVentas));
            }
        }
        //var json = JsonConvert.DeserializeObject<tienda>(cJSON);

    }
}
