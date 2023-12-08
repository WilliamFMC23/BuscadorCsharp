using Projecto.Bussines;
using Projecto.Data.Models;
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
        //Variable global;
        List<Cliente> lstClientes = new List<Cliente>();
        public string cCadenaBuscar = "Hacer una búsqueda...";
        public Form1()
        {
            InitializeComponent();
            txtBuscar.Text = cCadenaBuscar;
            txtBuscar.ForeColor = SystemColors.GrayText;
            visorDatos.DataSource = srvClientes.obtenerTablaClientes();
            visorDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            visorDatos.AllowUserToResizeRows = false;
            visorDatos.AllowUserToDeleteRows = false;
            visorDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void visorDatos_KeyDown(object sender, KeyEventArgs e)
        {
            //Al presionar Shift + Click izquierdo.
            int totalFilas = 0;
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    DataGridViewSelectedRowCollection filasMarcadas = visorDatos.SelectedRows;
                    totalFilas = filasMarcadas.Count;
                    foreach (DataGridViewRow row in filasMarcadas)
                    {
                        Cliente entCliente = new Cliente
                        {
                            id = Convert.ToInt32(row.Cells["ID"].Value)
                        };
                        lstClientes.Add(entCliente);
                    }
                }
            }

            //Cuando desee eliminar
            if (e.KeyCode == Keys.Delete)
            {
                if (visorDatos.SelectedRows.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show(this, $"¿Realmente desea Eliminar {visorDatos.SelectedRows.Count} Registros?", "Confirmación", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        string cMensaje = srvClientes.eliminarCliente(lstClientes);
                        visorDatos.DataSource = srvClientes.obtenerTablaClientes();
                        MessageBox.Show(cMensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado registros.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void visorDatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == visorDatos.Columns.Count - 1)
            {
                try
                {
                    visorDatos.CellEndEdit -= visorDatos_CellEndEdit;
                    Cliente entCliente = new Cliente();
                    {
                        DataGridViewRow filaSeleccionada = visorDatos.Rows[visorDatos.CurrentRow.Index];
                        entCliente.id = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);
                        entCliente.cNombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                        entCliente.cEdad = filaSeleccionada.Cells["Edad"].Value.ToString();
                        Cliente entRecuperado = srvClientes.ObtenerCliente(Convert.ToInt32(filaSeleccionada.Cells["id"].Value));
                        if (entRecuperado != null)
                        {
                            DialogResult result = MessageBox.Show($"Ya existe un cliente con el ID {entCliente.id} \n¿Desea Actualizar?", "Información", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if(result == DialogResult.Yes)
                            {
                                string cMensaje = srvClientes.ActualizarCliente(entCliente.cNombre, entCliente.cEdad, entCliente.id.ToString());
                                visorDatos.DataSource = srvClientes.obtenerTablaClientes();
                                MessageBox.Show(cMensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            string cMensaje = srvClientes.guardarCliente(entCliente);
                            MessageBox.Show(cMensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        visorDatos.DataSource = srvClientes.obtenerTablaClientes();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Ocurrió el siguiente Error {error.Message}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    visorDatos.CellEndEdit += visorDatos_CellEndEdit;
                }
            }
        }
    }
}
