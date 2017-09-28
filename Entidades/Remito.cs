using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Remito
    {
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal Total { get; set; }

        public Remito(string numero, DateTime fecha, string cliente, string direccion, string condicionIva, string condicionVenta, string detalle, DateTime fechaEntrega, decimal total)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Direccion = direccion;
            CondicionIVA = condicionIva;
            CondicionVenta = condicionVenta;
            Detalle = detalle;
            FechaEntrega = fechaEntrega;
            Total = total;
        }

        public override string ToString()
        {
            return "Remito:\nFecha: " + Fecha.ToString() + "\nNumero:" + Numero;
        }
    }
}
