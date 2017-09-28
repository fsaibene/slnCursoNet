using System;

namespace Entidades
{
    public class Factura : DocumentoComercial
    {
        public string Tipo { get; set; }

        public Factura(string tipo, string numero, DateTime fecha, string cliente, string direccion, string condicionIva, string condicionVenta, string detalle, decimal total)
        {
            Tipo = tipo;
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Direccion = direccion;
            CondicionIVA = condicionIva;
            CondicionVenta = condicionVenta;
            Detalle = Detalle;
            Total = total;
        }

        public override string ToString()
        {
            return "Factura:\nTipo: " + Tipo + "\nNumero:" + Numero;
        }
    }
}
