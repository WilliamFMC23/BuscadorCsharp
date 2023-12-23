
namespace Buscador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.visorDatos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblActalizar = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImportar = new System.Windows.Forms.ToolStripButton();
            this.barraCarga = new System.Windows.Forms.ProgressBar();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lblConteo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visorDatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // visorDatos
            // 
            this.visorDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visorDatos.Location = new System.Drawing.Point(12, 70);
            this.visorDatos.Name = "visorDatos";
            this.visorDatos.Size = new System.Drawing.Size(445, 210);
            this.visorDatos.TabIndex = 0;
            this.visorDatos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.visorDatos_CellEndEdit);
            this.visorDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.visorDatos_KeyDown);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(12, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(174, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // lblActalizar
            // 
            this.lblActalizar.AutoSize = true;
            this.lblActalizar.Location = new System.Drawing.Point(553, 308);
            this.lblActalizar.Name = "lblActalizar";
            this.lblActalizar.Size = new System.Drawing.Size(0, 13);
            this.lblActalizar.TabIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImportar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(468, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnImportar
            // 
            this.btnImportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
            this.btnImportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(23, 22);
            this.btnImportar.Text = "Importar desde Excel";
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // barraCarga
            // 
            this.barraCarga.Location = new System.Drawing.Point(319, 30);
            this.barraCarga.Name = "barraCarga";
            this.barraCarga.Size = new System.Drawing.Size(137, 21);
            this.barraCarga.TabIndex = 10;
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(319, 13);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(0, 13);
            this.lblOperacion.TabIndex = 12;
            // 
            // lblConteo
            // 
            this.lblConteo.AutoSize = true;
            this.lblConteo.Location = new System.Drawing.Point(12, 287);
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Size = new System.Drawing.Size(102, 13);
            this.lblConteo.TabIndex = 13;
            this.lblConteo.Text = "Conteo de Clientes: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 332);
            this.Controls.Add(this.lblConteo);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.barraCarga);
            this.Controls.Add(this.lblActalizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.visorDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.visorDatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView visorDatos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblActalizar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnImportar;
        private System.Windows.Forms.ProgressBar barraCarga;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Label lblConteo;
    }
}

