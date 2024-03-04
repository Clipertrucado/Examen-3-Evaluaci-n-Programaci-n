using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAlfLetExamen3Evaluación.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// mostrara el manu Principal de la aplicacion
        ///  SAV - 04-03-2024
        /// </summary>
        /// <returns></returns>
        public int menuSeleccion();

        /// <summary>
        /// mostrara el manu de empleados de la aplicacion
        ///  SAV - 04-03-2024
        /// </summary>
        /// <returns></returns>
        public int menuSeleccionEmpleado();

        /// <summary>
        /// mostrara el manu de gerencia de la aplicacion
        ///  SAV - 04-03-2024
        /// </summary>
        /// <returns></returns>
        public int menuSeleccionGerencia();


    }
}
