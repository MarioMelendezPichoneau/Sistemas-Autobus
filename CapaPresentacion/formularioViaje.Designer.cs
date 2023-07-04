
namespace CapaPresentacion
{
    partial class formularioViaje
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Chofer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.dataviaje = new System.Windows.Forms.DataGridView();
            this.comboBoxchofer = new System.Windows.Forms.ComboBox();
            this.comboBoxautobus = new System.Windows.Forms.ComboBox();
            this.comboBoxruta = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataviaje)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxruta);
            this.panel1.Controls.Add(this.comboBoxautobus);
            this.panel1.Controls.Add(this.comboBoxchofer);
            this.panel1.Controls.Add(this.agregar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Chofer);
            this.panel1.Location = new System.Drawing.Point(563, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 341);
            this.panel1.TabIndex = 0;
            // 
            // Chofer
            // 
            this.Chofer.AutoSize = true;
            this.Chofer.Location = new System.Drawing.Point(20, 30);
            this.Chofer.Name = "Chofer";
            this.Chofer.Size = new System.Drawing.Size(38, 13);
            this.Chofer.TabIndex = 0;
            this.Chofer.Text = "Chofer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autobus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ruta";
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(42, 276);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(126, 37);
            this.agregar.TabIndex = 3;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // dataviaje
            // 
            this.dataviaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviaje.Location = new System.Drawing.Point(33, 52);
            this.dataviaje.Name = "dataviaje";
            this.dataviaje.Size = new System.Drawing.Size(482, 282);
            this.dataviaje.TabIndex = 1;
            // 
            // comboBoxchofer
            // 
            this.comboBoxchofer.FormattingEnabled = true;
            this.comboBoxchofer.Location = new System.Drawing.Point(23, 60);
            this.comboBoxchofer.Name = "comboBoxchofer";
            this.comboBoxchofer.Size = new System.Drawing.Size(168, 21);
            this.comboBoxchofer.TabIndex = 4;
            // 
            // comboBoxautobus
            // 
            this.comboBoxautobus.FormattingEnabled = true;
            this.comboBoxautobus.Location = new System.Drawing.Point(23, 130);
            this.comboBoxautobus.Name = "comboBoxautobus";
            this.comboBoxautobus.Size = new System.Drawing.Size(168, 21);
            this.comboBoxautobus.TabIndex = 5;
            // 
            // comboBoxruta
            // 
            this.comboBoxruta.FormattingEnabled = true;
            this.comboBoxruta.Location = new System.Drawing.Point(23, 206);
            this.comboBoxruta.Name = "comboBoxruta";
            this.comboBoxruta.Size = new System.Drawing.Size(168, 21);
            this.comboBoxruta.TabIndex = 6;
            // 
            // formularioViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataviaje);
            this.Controls.Add(this.panel1);
            this.Name = "formularioViaje";
            this.Text = "formularioViaje";
            this.Load += new System.EventHandler(this.formularioViaje_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataviaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Chofer;
        private System.Windows.Forms.DataGridView dataviaje;
        private System.Windows.Forms.ComboBox comboBoxruta;
        private System.Windows.Forms.ComboBox comboBoxautobus;
        private System.Windows.Forms.ComboBox comboBoxchofer;
    }
}