using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class tienda
    {
        public int idSucursal;
        public string nombreSucursal;
        public int numeroVentas;

        public tienda(int id,string nombre, int ventas)
        {
            idSucursal = id;
            nombreSucursal = nombre;
            numeroVentas = ventas;
        }
    }
}
