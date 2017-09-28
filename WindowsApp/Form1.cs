using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        List<object> entitiesList;
        public Form1()
        {
            InitializeComponent();
            entitiesList = new List<object>();
            LoadEntities();
        }

        private void ShowEntity(object entity)
        {
            MessageBox.Show(entity.ToString());
        }

        private void LoadEntities()
        {
            entitiesList.Add(new Proveedor("P1", "A1", "112233", "proveedor@proveedor.com", "555554444", "Calle A 123"));
            entitiesList.Add(new ClienteEmpresa("ClienteE", "33-22222222-1", "1122332", "ClienteEmpresa@ClienteEmpresa.com", "555554444", "Calle B 123"));
            entitiesList.Add(new ClienteIndividuo("ClienteI", "Apellido", "33-22222222-1", "ClienteEmpresa@ClienteEmpresa.com", "555554444", "Calle B 123"));
            entitiesList.Add(new Vendedor("Pepe", "Argento", "112233", "Vendedor@Vendedor.com", "555554444", "Calle D 123"));
            entitiesList.Add(new Producto("Botella", "cosas", 10, 10, "P1", "Algo", "AlgoAlgo"));
            entitiesList.Add(new Factura("A", "1112321", DateTime.Now, "Alguien", "Mitre 750", "asfasf", "fdfdf", "compra de cosas", 100));
            entitiesList.Add(new Remito("2255", DateTime.Now, "AlguienMas", "Cerrito 1186", "ajjgd", "asdlasd", "detaillll", DateTime.Now, 55000));

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (object item in entitiesList)
            {
                ShowEntity(item);
            }
        }
    }
}
