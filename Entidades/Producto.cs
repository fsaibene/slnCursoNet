using System;

namespace Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA {
            get { return Convert.ToDouble(PrecioBruto) * 0.21; }
        }

        public decimal PrecioBruto
        {
            get { return Convert.ToDecimal(1 + Margen) + PrecioCosto; }
        }

        public decimal PrecioVenta {
            get { return PrecioBruto + Convert.ToDecimal(1 + IVA); }
        }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }

        public Producto(string nombre, string descripcion, decimal precioCosto, double margen, string proveedor, string categoria, string subCategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = PrecioCosto;
            Margen = Margen;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subCategoria;
        }

        public override string ToString()
        {
            return "Producto:\nNombre: " + Nombre + "\nDescripcion:" + Descripcion + "\nPrecio: "+ PrecioVenta.ToString();
        }
    }
}
