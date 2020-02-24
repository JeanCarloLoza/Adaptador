using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IServicio servicioEnt = new ServicioEntidades();
            IServicio servicioJson = new AdaptadorJson();

            Console.WriteLine("servicio 1");
            IProcesador procesador = new Procesador(servicioEnt);
            procesador.mostrarTiendas();

            Console.WriteLine("servicio 2");

            procesador = new Procesador(servicioJson);
            procesador.mostrarTiendas();

        }
    }
}
