
namespace CapaPresentacion
{
    partial class furmularioAutobus
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
            this.dataGridViewautobus = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtann = new System.Windows.Forms.TextBox();
            this.edictar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewautobus)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewautobus
            // 
            this.dataGridViewautobus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewautobus.Location = new System.Drawing.Point(22, 43);
            this.dataGridViewautobus.Name = "dataGridViewautobus";
            this.dataGridViewautobus.Size = new System.Drawing.Size(506, 251);
            this.dataGridViewautobus.TabIndex = 0;
            this.dataGridViewautobus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(14, 23);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(174, 20);
            this.txtmarca.TabIndex = 2;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(31, 295);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(126, 35);
            this.guardar.TabIndex = 3;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Año";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtann);
            this.panel1.Controls.Add(this.guardar);
            this.panel1.Controls.Add(this.txtcolor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtplaca);
            this.panel1.Controls.Add(this.txtmodelo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtmarca);
            this.panel1.Location = new System.Drawing.Point(567, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 350);
            this.panel1.TabIndex = 8;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(14, 71);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(174, 20);
            this.txtmodelo.TabIndex = 5;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(14, 120);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(174, 20);
            this.txtplaca.TabIndex = 6;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(14, 176);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(174, 20);
            this.txtcolor.TabIndex = 7;
            // 
            // txtann
            // 
            this.txtann.Location = new System.Drawing.Point(14, 231);
            this.txtann.Name = "txtann";
            this.txtann.Size = new System.Drawing.Size(174, 20);
            this.txtann.TabIndex = 8;
            // 
            // edictar
            // 
            this.edictar.Location = new System.Drawing.Point(67, 338);
            this.edictar.Name = "edictar";
            this.edictar.Size = new System.Drawing.Size(126, 35);
            this.edictar.TabIndex = 9;
            this.edictar.Text = "Edictar";
            this.edictar.UseVisualStyleBackColor = true;
            this.edictar.Click += new System.EventHandler(this.edictar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(290, 338);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(126, 35);
            this.eliminar.TabIndex = 10;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // furmularioAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.edictar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewautobus);
            this.Name = "furmularioAutobus";
            this.Text = "furmularioAutobus";
            this.Load += new System.EventHandler(this.furmularioAutobus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewautobus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewautobus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtann;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Button edictar;
        private System.Windows.Forms.Button eliminar;
    }
}