using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAlfLetExamen3Evaluación.Servicios
{
    /// <summary>
    /// clase que contendra la logica de los diferentes metodos
    ///  SAV - 04-03-2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuSeleccion()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("     SELECCION DE MENU");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Empleado");
            Console.WriteLine("2. Gerencia");
            Console.WriteLine("0. Cerrar");
            Console.WriteLine("----------------------------");

            int seleccion = Convert.ToInt32(Console.ReadLine());
            return seleccion;
        }

        public int menuSeleccionEmpleado()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("     MENU EMPLEADO");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Añadir venta");
            Console.WriteLine("2. Calculo total de ventas");
            Console.WriteLine("0. Cerrar");
            Console.WriteLine("----------------------------");

            int seleccion = Convert.ToInt32(Console.ReadLine());
            return seleccion;
        }

        public int menuSeleccionGerencia()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("     MENU GERENCIA");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Crear pedido proveedor");
            Console.WriteLine("2. Ventas del dia (fichero)");
            Console.WriteLine("0. Cerrar");
            Console.WriteLine("----------------------------");

            int seleccion = Convert.ToInt32(Console.ReadLine());
            return seleccion;
        }
    }
}
