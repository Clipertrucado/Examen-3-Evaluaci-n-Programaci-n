using SAlfLetExamen3Evaluación.Dtos;
using SAlfLetExamen3Evaluación.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SAlfLetExamen3Evaluación.Controladores
{
    /// <summary>
    /// clase principal del programa 
    /// SAV - 04-03-2024
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// metodo que contendra los pasos que se tiene que seguir durante la ejecucion de la app
        ///  SAV - 04-03-2024
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //declaramos las llistas y las copias del nuestras interfaces
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            List<PedidoDtos> listaPedidos = new List<PedidoDtos>();
            List<VentaDtos> listaVentas = new List<VentaDtos>();


            // con este bool y el while conseguiremos que nos mantengamos hasta que se diga lo contrario en el swhich
            bool cerrar = true;

            while (cerrar)
            {
                //llamamos al menu principal 
                int seleccion = mi.menuSeleccion();
                switch (seleccion) { 
                    case 0:
                        cerrar = false;
                    break;
                    
                    case 1:
                        //llamamos al menu de empleados 
                        int seleccionEmpleado = mi.menuSeleccionEmpleado();
                        switch (seleccionEmpleado) {
                            case 0:
                                break;

                            case 1:
                                
                                oi.anyadirVenta(listaVentas);
                                break;

                            case 2:
                                oi.calculoVenta(listaVentas);
                                break;
                        }
                    break;
                    
                    case 2:
                        //llamamos la menu de gerencia 
                        int seleccionGerencia = mi.menuSeleccionGerencia(); 
                        switch (seleccionGerencia)
                        {
                            case 0:
                                break;

                            case 1:

                                bool continuar = true;
                                while (continuar) { 
                                    continuar = oi.anyadirPedido(listaPedidos);
                                }
 
                                break;

                            case 2:

                                oi.VentasDia(listaVentas);

                                break;
                        }
                    break; 
                     
                
                
                
                }
            }
        }

        

    }
}
