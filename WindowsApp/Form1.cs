using Entidades;
using System;
using System.Collections.Generic;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEntities();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ShowEntities();
        }

        private void ShowEntity(object entity)
        {
            MessageBox.Show(entity.ToString());
        }

        private void LoadEntities()
        {
            entitiesList.Add(new Empresa("P1", "A1", "112233", "proveedor@proveedor.com", "555554444", "Calle A 123"));
            entitiesList.Add(new ClienteIndividuo("ClienteI", "Apellido", "33-22222222-1", "ClienteEmpresa@ClienteEmpresa.com", "555554444", "Calle B 123"));
            entitiesList.Add(new Vendedor("Pepe", "Argento", "112233", "Vendedor@Vendedor.com", "555554444", "Calle D 123"));
            entitiesList.Add(new Producto("Botella", "cosas", 10, 10, "P1", "Algo", "AlgoAlgo"));
            entitiesList.Add(new Factura("A", "1112321", DateTime.Now, "Alguien", "Mitre 750", "asfasf", "fdfdf", "compra de cosas", 100));
            entitiesList.Add(new Remito("2255", DateTime.Now, "AlguienMas", "Cerrito 1186", "ajjgd", "asdlasd", "detaillll", DateTime.Now, 55000));
        }

        private void ShowEntities()
        {
            foreach (object item in entitiesList)
            {
                ShowEntity(item);
            }
        }

    }
}
