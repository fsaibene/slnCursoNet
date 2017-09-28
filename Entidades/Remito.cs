using System;

namespace Entidades
{
    public class Remito :DocumentoComercial
    {
        public DateTime FechaEntrega { get; set; }

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
