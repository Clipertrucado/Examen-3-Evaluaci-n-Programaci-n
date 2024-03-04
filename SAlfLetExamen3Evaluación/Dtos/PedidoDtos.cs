using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAlfLetExamen3Evaluación.Dtos
{
    internal class PedidoDtos
    {
        //declaracion de variables
        int idPedido;
        string nombrePedido = "aaaaa";
        int cantidadPedido = 99999;
        DateTime fechaPedido;

        //metodo get y set
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string NombrePedido { get => nombrePedido; set => nombrePedido = value; }
        public int CantidadPedido { get => cantidadPedido; set => cantidadPedido = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }

        /// <summary>
        /// constructor con todas la variavles 
        /// SAV - 04-03-2024
        /// </summary>
        /// <param name="idPedido"></param>
        /// <param name="nombrePedido"></param>
        /// <param name="cantidadPedido"></param>
        /// <param name="fechaPedido"></param>
        public PedidoDtos(int idPedido, string nombrePedido, int cantidadPedido, DateTime fechaPedido)
        {
            this.idPedido = idPedido;
            this.nombrePedido = nombrePedido;
            this.cantidadPedido = cantidadPedido;
            this.fechaPedido = fechaPedido;
        }

        /// <summary>
        /// constructor vacio 
        /// SAV - 04-03-2024
        /// </summary>
        public PedidoDtos()
        {
        }

        /// <summary>
        /// metodo toString 
        /// SAV - 04-03-2024
        /// </summary>
        /// <returns></returns>
        override
        public String ToString()
        {

            return "";
        }
    }

    
}
