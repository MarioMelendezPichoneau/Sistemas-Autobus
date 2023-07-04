using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Microsoft.Azure.Amqp.Framing;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        

        
       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new FormularioChofer();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new furmularioAutobus();
            formulario.Show();
        }

        private void btn_Ruta_Click(object sender, EventArgs e)
        {
            Form formulario = new formularioRuta();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new formularioViaje();
            formulario.Show();
        }
    }
}
