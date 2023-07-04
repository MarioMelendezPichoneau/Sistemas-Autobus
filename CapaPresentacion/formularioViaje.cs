using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class formularioViaje : Form
    {
        public formularioViaje()
        {
            InitializeComponent();
        }

        CN_Chofer objectoCN = new CN_Chofer();
        C_Iniciar_v objEntidad = new C_Iniciar_v();

        private void formularioViaje_Load(object sender, EventArgs e)
        {
            // comboBox chofer
            comboBoxchofer.DataSource = objectoCN.CB_CHOFER();
            comboBoxchofer.DisplayMember = "NOMBRE";
            comboBoxchofer.ValueMember = "NOMBRE";
            comboBoxchofer.SelectedIndex = -1;

            // comboBox Autobus
            comboBoxautobus.DataSource = objectoCN.CB_AUTOBUS();
            comboBoxautobus.DisplayMember = "PLACA";
            comboBoxautobus.ValueMember = "PLACA";
            comboBoxautobus.SelectedIndex = -1;

            // comboBox chofer
            comboBoxruta.DataSource = objectoCN.CB_RUTA();
            comboBoxruta.DisplayMember = "RUTA";
            comboBoxruta.ValueMember = "RUTA";
            comboBoxruta.SelectedIndex = -1;

            MostrarDatos("");
        }

        public void MostrarDatos(string buscar)
        {
            CN_Chofer objectoN = new CN_Chofer();
            dataviaje.DataSource = objectoN.CARGA_V(buscar);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            objEntidad.CHOFER = comboBoxchofer.Text.ToUpper();
            objEntidad.AUTOBUS = comboBoxautobus.Text.ToUpper();
            objEntidad.RUTA = comboBoxruta.Text.ToUpper();

            objectoCN.INSERTAR_V(objEntidad);
            objectoCN.DISPO_C(objEntidad);
            objectoCN.DISPO_A(objEntidad);
            objectoCN.DISPO_R(objEntidad);

            MessageBox.Show("Registro guardo con exicto");
            LIMPIAR();
            formularioViaje_Load(sender, e);
            MostrarDatos("");

        }

        private void LIMPIAR()
        {
            comboBoxchofer.Text = "";
            comboBoxautobus.Text = "";
            comboBoxruta.Text = "";
        }
    }
}
