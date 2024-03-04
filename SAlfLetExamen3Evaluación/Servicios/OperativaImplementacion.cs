using SAlfLetExamen3Evaluación.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SAlfLetExamen3Evaluación.Servicios
{
    /// <summary>
    /// clase que contendra toda la logia de nuestra aplicacion 
    /// SAV - 04-03-2024
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void anyadirVenta(List<VentaDtos> listaVentas)
        {
            listaVentas.Add(crearVenta(listaVentas));
        }

        /// <summary>
        /// con este metodo crearemos una venta para añadirla despues a la lista
        /// SAV - 04-03-2024
        /// </summary>
        /// <param name="listaVentas"></param>
        /// <returns></returns>
        private VentaDtos crearVenta(List<VentaDtos> listaVentas)
        {
            VentaDtos venta = new VentaDtos();


            Console.WriteLine("--------------------------------");
            Console.WriteLine("  CREAR VENTA");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Ingresa el importe de la venta");
            venta.DineroVenta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            venta.FechaVenta= DateTime.Now;

            venta.IdVenta = crearId(listaVentas);

            return venta;
        }

        /// <summary>
        /// con este metodo crearemos IDs automaticas
        /// SAV - 04-03-2024
        /// </summary>
        /// <param name="listaVentas"></param>
        /// <returns></returns>
        private int crearId(List<VentaDtos> listaVentas)
        {
            int id = 1;

            for (int i = 1; i < 100; i++)
            {
                foreach (var venta in listaVentas)
                {

                    if (i == venta.IdVenta)
                    {

                    }
                    else
                    {
                        id = i;
                        i = 100;
                        break;
                    }

                }

            }

            Console.WriteLine("el id seleccionado es:" + id);
            return id;
        }

        public void calculoVenta(List<VentaDtos> listaVentas)
        {
            Console.WriteLine("Ingresa la fecha que deseas. (dd-mm-yyyy)");

            DateTime fechaBuscar = Convert.ToDateTime(Console.ReadLine());
            
            int mayor = 0; 
            for (int x = 0; x <= listaVentas.Count - 1; x++)
            {
                if (listaVentas[x].FechaVenta.ToString().Equals(fechaBuscar.ToString())) { 
                    
                    mayor = x;

                }

            }

            int menor = 0;
            for (int x = 0; x <= listaVentas.Count - 1; x++)
            {
                if (listaVentas[x].FechaVenta.ToString().Equals(fechaBuscar.ToString()))
                {

                    menor = x;
                    break;
                }

            }



            double dinero = 0;


            for (int i = menor; i <= mayor; i++)
            {
                 dinero = dinero + listaVentas[i].DineroVenta;
            }
            

            int horas;
            int minutos;
            int segundo;

            TimeSpan diferencia = (listaVentas[0].FechaVenta - listaVentas[listaVentas.Count - 1].FechaVenta);

            horas = Convert.ToInt32(diferencia.TotalHours);

            minutos = Convert.ToInt32((diferencia.TotalHours - horas) * 60);

            double minutosTotates = (diferencia.TotalHours - horas) * 60;

            segundo = Convert.ToInt32((minutosTotates - minutos) * 60);

            Console.WriteLine("Total ventas: " + dinero +" euros");
            Console.WriteLine("Tiempo transcurrido: " + horas + " horas "+ minutos + " minutos " + segundo + " segundos");
        }

        public bool anyadirPedido(List<PedidoDtos> listaPedidos)
        {
            listaPedidos.Add(crearPedido(listaPedidos));
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Desea hacer mas pedido");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. si");
            Console.WriteLine("0. no");
            Console.WriteLine("--------------------------------");
            int seleccion = Convert.ToInt32(Console.ReadLine());

            bool continuar = false;
            switch (seleccion)
            {
                case 0:
                    continuar = false;
                    mostrarPedidos(listaPedidos);
                    break;

                case 1: 
                    continuar = true; 
                    break;

            }

            return continuar;
        }

        /// <summary>
        /// Con este metod crearemos un pedido para despues añadirlo a la lista
        /// SAV - 04-03-2024
        /// </summary>
        /// <param name="listaPedidos"></param>
        /// <returns></returns>
        private PedidoDtos crearPedido(List<PedidoDtos> listaPedidos) {
            
            PedidoDtos pedido = new PedidoDtos();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("  CREAR PEDIDO");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Ingresa el nombre del pedido");
            pedido.NombrePedido = Console.ReadLine();

            Console.WriteLine("Ingresa la cantidad del pedido");
            pedido.CantidadPedido = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la fecha en la que desea del pedido");
            pedido.FechaPedido = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("--------------------------------");

            pedido.IdPedido = crearIdPedido(listaPedidos);

            return pedido;

        }

        /// <summary>
        /// encargado de crear la id para el pedido 
        /// SAV - 04-03-2024
        /// </summary>
        /// <param name="listaPedidos"></param>
        /// <returns></returns>
        private int crearIdPedido(List<PedidoDtos> listaPedidos)
        {
            int id = 1;

            for (int i = 1; i < 100; i++)
            {
                foreach (var pedido in listaPedidos)
                {

                    if (i == pedido.IdPedido)
                    {

                    }
                    else
                    {
                        id = i;
                        i = 100;
                        break;
                    }

                }

            }

            Console.WriteLine("el id seleccionado es:" + id);
            return id;
        }

        /// <summary>
        /// muesta la lista por pantalla 
        /// SAV - 04-03-2024
        /// </summary>
        /// <param name="listaPedidos"></param>
        private void mostrarPedidos(List<PedidoDtos> listaPedidos)
        {
            foreach (PedidoDtos pedido in listaPedidos) {
                Console.WriteLine(pedido.ToString());
            }
        }

        public void VentasDia(List<VentaDtos> listaVentas)
        {
            string rutaFichero = "C:\\Users\\csi23-salflet\\source\\repos\\SAlfLetExamen3Evaluación\\Ficheros\\ddMMyyyy.txt";

            using (StreamWriter sw = new StreamWriter(rutaFichero))
            {
                sw.WriteLine("Mostrar ventas del día");
            }

            Console.WriteLine("Ingresa la fecha que deseas. (dd-mm-yyyy)");

            DateTime fechaBuscar = Convert.ToDateTime(Console.ReadLine());

            int mayor = 0;
            for (int x = 0; x <= listaVentas.Count - 1; x++)
            {
                if (listaVentas[x].FechaVenta.ToString().Equals(fechaBuscar.ToString()))
                {

                    mayor = x;

                }

            }

            int menor = 0;
            for (int x = 0; x <= listaVentas.Count - 1; x++)
            {
                if (listaVentas[x].FechaVenta.ToString().Equals(fechaBuscar.ToString()))
                {

                    menor = x;
                    break;
                }

            }

            for (int i = menor; i <= mayor; i++)
            {
                using (StreamWriter sw = new StreamWriter(rutaFichero, true))
                {
                    sw.WriteLine(listaVentas[i].ToString());
                }
            }

        }
    }
}
