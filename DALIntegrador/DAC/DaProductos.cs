using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALIntegrador.DAC
{
    public class DaProductos
    {
        private static SqlConnection conn = null;
        private static SqlCommand command = null;
        private static SqlDataReader reader = null;
        private static string SQL = string.Empty;
        public DaProductos()
        {
            conn = ServiceDB.Conexion();
            conn.Open();
        }
        public List<Producto> traerTodos()
        {
            string SQL;
            List<Producto> Lista = new List<Producto>();
            SQL = "SELECT Productos.Id, Productos.Nombre, Productos.Descripcion, Productos.PrecioCosto, Productos.Margen, Productos.Id_Proveedor, Productos.Id_Categoria, Productos.Id_Subcategoria, Categorias.Nombre AS Categoria, Subcategorias.Nombre AS Subcategoria, Proveedores.Id_Empresa, Empresas.Nombre AS Empresa";
            SQL = SQL + " " + "FROM Productos";
            SQL = SQL + " " + "INNER JOIN Categorias ON Productos.Id_Categoria = Categorias.Id";
            SQL = SQL + " " + "INNER JOIN Subcategorias ON Productos.Id_Subcategoria = Subcategorias.Id AND Categorias.Id = Subcategorias.Id_Categoria";
            SQL = SQL + " " + "INNER JOIN Proveedores ON Productos.Id_Proveedor = Proveedores.Id";
            SQL = SQL + " " + "INNER JOIN Empresas ON Proveedores.Id_Empresa = Empresas.Id";
            SQL = SQL + " " + "ORDER BY Categoria, Subcategoria, Productos.Nombre";
            command = new SqlCommand(SQL, conn);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Empresa objProveedor = new Empresa(Convert.ToInt32(reader["Id_Empresa"]), reader["Empresa"].ToString());
                    Categoria objCategoria = new Categoria(Convert.ToInt32(reader["Id_Categoria"]), reader["Categoria"].ToString());
                    Categoria objSubcategoria = new Categoria(Convert.ToInt32(reader["Id_Subcategoria"]), reader["SubCategoria"].ToString());
                    Producto Item = new Producto(Convert.ToInt32(reader["Id"]), reader["Nombre"].ToString(), reader["Descripcion"].ToString(), Convert.ToDecimal(reader["PrecioCosto"]), Convert.ToDouble(reader["Margen"]), objProveedor, objCategoria, objSubcategoria);
                    Lista.Add(Item);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return Lista;
        }

        public List<Producto> traerTodos(string ciudad)
        {
            return null;
        }
    }
}
