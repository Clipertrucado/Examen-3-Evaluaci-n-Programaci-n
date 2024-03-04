using SAlfLetExamen3Evaluación.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAlfLetExamen3Evaluación.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// creamos la cabecera del metod que contendra la logica para añadir una venta
        /// SAV - 04-03-2024
        /// </summary>
        /// <param name="listaVentas"></param>
        public void anyadirVenta(List<VentaDtos> listaVentas);

        /// <summary>
        /// creamos la cabecera del metod que contendra la logica para calcular las ventas
        /// SAV - 04-03-2024
        /// </summary>
        /// <param name="listaVentas"></param>
        public void calculoVenta(List<VentaDtos> listaVentas);

        /// <summary>
        /// creamos la cabecera del metod que contendra la logica para añadir un pedido
        /// SAV - 04-03-2024
        /// </summary>
        /// <param name="listaPedidos"></param>
        public bool anyadirPedido(List<PedidoDtos> listaPedidos);

        /// <summary>
        /// creamos la cabecera del metod que contendra la logica para añadir las ventas del dia al fichero
        /// SAV - 04-03-2024
        /// </summary>
        /// <param name="listaVentas"></param>
        public void VentasDia(List<VentaDtos> listaVentas);
    }
}
