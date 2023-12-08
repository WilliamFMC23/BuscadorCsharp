using Projecto.Bussines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscador
{
    public partial class Form1 : Form
    {
        //Variable global para el servicio.
        ClientesService srvClientes = new ClientesService();
        public string cCadenaBuscar = "Hacer una búsqueda...";
        public Form1()
        {
            InitializeComponent();
            txtBuscar.Text = cCadenaBuscar;
            txtBuscar.ForeColor = SystemColors.GrayText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.ToLower();
            DataRow[] filasFiltradas = srvClientes.obtenerTablaClientes().Select($"Nombre LIKE '%{textoBusqueda}%'");
            DataTable dataTableFiltrado = srvClientes.obtenerTablaClientes().Clone();
            foreach (DataRow fila in filasFiltradas)
            {
                dataTableFiltrado.ImportRow(fila);
            }
            visorDatos.DataSource = dataTableFiltrado;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(cCadenaBuscar))
            {
                visorDatos.DataSource = srvClientes.obtenerTablaClientes();
                txtBuscar.Text = "";
                txtBuscar.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = cCadenaBuscar;
                txtBuscar.ForeColor = SystemColors.GrayText;
                visorDatos.DataSource = srvClientes.obtenerTablaClientes();
            }
        }

        private void visorDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = visorDatos.Rows[e.RowIndex];
            txtID.Text = filaSeleccionada.Cells["ID"].Value.ToString();
            txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            txtEdad.Text = filaSeleccionada.Cells["Edad"].Value.ToString();
        }

        private void btbActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = visorDatos.Rows[visorDatos.CurrentRow.Index];
            string cMensaje = srvClientes.ActualizarCliente(txtNombre.Text, txtEdad.Text, filaSeleccionada.Cells["ID"].Value.ToString());
            //Refrescar Grid.
            visorDatos.DataSource = srvClientes.obtenerTablaClientes();
            MessageBox.Show(cMensaje, "Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            visorDatos.DataSource = srvClientes.obtenerTablaClientes();
        }
    }
}
