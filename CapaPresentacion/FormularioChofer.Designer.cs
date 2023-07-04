
namespace CapaPresentacion
{
    partial class FormularioChofer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lnapellido = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbcedula = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eAUTOBUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Edictar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eAUTOBUSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(94, 61);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(44, 13);
            this.lbnombre.TabIndex = 0;
            this.lbnombre.Text = "Nombre";
            // 
            // lnapellido
            // 
            this.lnapellido.AutoSize = true;
            this.lnapellido.Location = new System.Drawing.Point(94, 112);
            this.lnapellido.Name = "lnapellido";
            this.lnapellido.Size = new System.Drawing.Size(44, 13);
            this.lnapellido.TabIndex = 1;
            this.lnapellido.Text = "Apellido";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(187, 61);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(150, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(432, 61);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(37, 13);
            this.lbfecha.TabIndex = 3;
            this.lbfecha.Text = "Fecha";
            // 
            // lbcedula
            // 
            this.lbcedula.AutoSize = true;
            this.lbcedula.Location = new System.Drawing.Point(429, 128);
            this.lbcedula.Name = "lbcedula";
            this.lbcedula.Size = new System.Drawing.Size(40, 13);
            this.lbcedula.TabIndex = 4;
            this.lbcedula.Text = "Cedula";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(187, 112);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(150, 20);
            this.txtapellido.TabIndex = 5;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(495, 58);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(150, 20);
            this.txtfecha.TabIndex = 6;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(495, 121);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(150, 20);
            this.txtcedula.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(115, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eAUTOBUSBindingSource
            // 
            this.eAUTOBUSBindingSource.DataSource = typeof(CapaEntidad.E_AUTOBUS);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(148, 203);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 31);
            this.Guardar.TabIndex = 9;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(455, 203);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 31);
            this.Eliminar.TabIndex = 10;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Edictar
            // 
            this.Edictar.Location = new System.Drawing.Point(308, 203);
            this.Edictar.Name = "Edictar";
            this.Edictar.Size = new System.Drawing.Size(75, 31);
            this.Edictar.TabIndex = 11;
            this.Edictar.Text = "Edictar";
            this.Edictar.UseVisualStyleBackColor = true;
            this.Edictar.Click += new System.EventHandler(this.Edictar_Click);
            // 
            // FormularioChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Edictar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.lbcedula);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lnapellido);
            this.Controls.Add(this.lbnombre);
            this.Name = "FormularioChofer";
            this.Text = "FormularioChofer";
            this.Load += new System.EventHandler(this.FormularioChofer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eAUTOBUSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lnapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lbcedula;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource eAUTOBUSBindingSource;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Edictar;
    }
}