using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAlfLetExamen3Evaluación.Dtos
{
    internal class VentaDtos
    {
        //declaracion de variables
        int idVenta;
        double dineroVenta = 99999;
        DateTime fechaVenta;

        //metodo get y set
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public double DineroVenta { get => dineroVenta; set => dineroVenta = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }

        /// <summary>
        /// constructor con todas la variavles 
        /// SAV - 04-03-2024
        /// </summary>
        /// <param name="idVenta"></param>
        /// <param name="dineroVenta"></param>
        /// <param name="fechaVenta"></param>
        public VentaDtos(int idVenta, double dineroVenta, DateTime fechaVenta)
        {
            this.idVenta = idVenta;
            this.dineroVenta = dineroVenta;
            this.fechaVenta = fechaVenta;
        }

        /// <summary>
        /// constructor vacio 
        /// SAV - 04-03-2024
        /// </summary>
        public VentaDtos()
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
            string contenido = $"Venta nuemero: {idVenta}\n"+
                                $"Euros: {dineroVenta} euros\n" +
                                $"Instante de compra: {fechaVenta.ToString()}\n"+
                                "-------------------------------------------------";

            return contenido;
        }
    }
}
