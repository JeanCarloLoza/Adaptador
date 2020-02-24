using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ServicioEntidades : IServicio
    {
        public List<tienda> devolverTiendas() {
            List<tienda> lstTienda = new List<tienda>();
            tienda tienda = new tienda(1,"tienda 1",10);

            lstTienda.Add(tienda);
            tienda = new tienda(2, "tienda 2", 20);

            lstTienda.Add(tienda);
            tienda = new tienda(3, "tienda 3", 30);

            lstTienda.Add(tienda);

            return lstTienda;
        }
    }
}
