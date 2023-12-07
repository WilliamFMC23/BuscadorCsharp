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
        public string cCadenaBuscar = "Hacer una búsqueda...";
        public Form1()
        {
            InitializeComponent();
            txtBuscar.Text = cCadenaBuscar;
            txtBuscar.ForeColor = SystemColors.GrayText;
            visorDatos.DataSource = ObtenerDataTable();
            lblID.Text = "ID";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.ToLower();
            DataRow[] filasFiltradas = ObtenerDataTable().Select($"Nombre LIKE '%{textoBusqueda}%'");
            DataTable dataTableFiltrado = ObtenerDataTable().Clone();
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
                visorDatos.DataSource = ObtenerDataTable();
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
                visorDatos.DataSource = ObtenerDataTable();
            }
        }

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void txtBuscar_DoubleClick(object sender, EventArgs e)
        {
        }

        private DataTable ObtenerDataTable()
        {
            // Crear un DataTable con columnas
            DataTable dataTable = new DataTable("EjemploDataTable");
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Edad", typeof(int));

            // Agregar filas al DataTable (puedes obtener estos datos de una base de datos, por ejemplo)
            dataTable.Rows.Add(1, "Juan", 25);
            dataTable.Rows.Add(2, "María", 30);
            dataTable.Rows.Add(3, "Carlos", 22);
            for (int i = 1; i <= 50; i++)
            {
                dataTable.Rows.Add(i, "Persona" + i, 20 + i);
            }
            return dataTable;
        }

        private DataTable BuscarElementoEnDataTable(string _cNombreBuscar, DataTable _dtDatos)
        {
            DataRow[] filasEncontradas = _dtDatos.Select($"Nombre = {QuitarDiacriticos(_cNombreBuscar)}");
            DataTable dtResultado = new DataTable();
            foreach (DataRow row in filasEncontradas)
            {
                dtResultado.ImportRow(row);
            }
            return dtResultado;
        }

        private string QuitarDiacriticos(string input)
        {
            string normalizedString = input.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }

            return stringBuilder.ToString();
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
