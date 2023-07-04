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
    public partial class furmularioAutobus : Form
    {
        CN_Chofer objetoCN = new CN_Chofer();
        private string idAutobus = null;
        private bool Editar = false;

        public furmularioAutobus()
        {
            InitializeComponent();
        }

        private void furmularioAutobus_Load(object sender, EventArgs e)
        {
            MostrarAutobus();
        }

        private void MostrarAutobus()
        {
            CN_Chofer objeto = new CN_Chofer();
            dataGridViewautobus.DataSource = objeto.MostrarATOBUS();

        }
        private void limpiarForm()
        {
            txtmarca.Clear();
            txtmodelo.Clear();
            txtplaca.Clear();
            txtcolor.Clear();
            txtann.Clear();
        }

        E_AUTOBUS objEntetidad = new E_AUTOBUS();

        private void guardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objEntetidad.MARCA = txtmarca.Text.ToUpper();
                    objEntetidad.MODELO = txtmodelo.Text.ToUpper();
                    objEntetidad.PLACA = txtplaca.Text.ToUpper();
                    objEntetidad.COLOR = txtcolor.Text.ToUpper();
                    objEntetidad.AGE = txtann.Text.ToUpper();

                    objetoCN.InsertAUTOBUS(objEntetidad);

                    MessageBox.Show("se inserto correctamente");
                    MostrarAutobus();
                    limpiarForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }

            if (Editar == true)
            {
                try
                {
                    objEntetidad.id_AUTOBUS = Convert.ToInt32(idAutobus);
                    objEntetidad.MARCA = txtmarca.Text.ToUpper();
                    objEntetidad.MODELO = txtmodelo.Text.ToUpper();
                    objEntetidad.PLACA = txtplaca.Text.ToUpper();
                    objEntetidad.COLOR = txtcolor.Text.ToUpper();
                    objEntetidad.AGE = txtann.Text.ToUpper();


                    objetoCN.EditarAUTOBUS(objEntetidad);

                    MessageBox.Show("se edito correctamente");
                    MostrarAutobus();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idAutobus = dataGridViewautobus.CurrentRow.Cells[0].Value.ToString();
            txtmarca.Text = dataGridViewautobus.CurrentRow.Cells[1].Value.ToString();
            txtmodelo.Text = dataGridViewautobus.CurrentRow.Cells[2].Value.ToString();
            txtplaca.Text = dataGridViewautobus.CurrentRow.Cells[3].Value.ToString();
            txtcolor.Text = dataGridViewautobus.CurrentRow.Cells[4].Value.ToString();
            txtann.Text = dataGridViewautobus.CurrentRow.Cells[4].Value.ToString();

        }

        private void edictar_Click(object sender, EventArgs e)
        {
            if (dataGridViewautobus.SelectedRows.Count > 0)
            {
                Editar = true;

                idAutobus = dataGridViewautobus.CurrentRow.Cells["ID_AUTOBUS"].Value.ToString();
                objEntetidad.MARCA = txtmarca.Text = dataGridViewautobus.CurrentRow.Cells["MARCA"].Value.ToString();
                objEntetidad.MODELO = txtmodelo.Text = dataGridViewautobus.CurrentRow.Cells["MODELO"].Value.ToString();
                objEntetidad.PLACA = txtplaca.Text = dataGridViewautobus.CurrentRow.Cells["PLACA"].Value.ToString();
                objEntetidad.COLOR = txtcolor.Text = dataGridViewautobus.CurrentRow.Cells["COLOR"].Value.ToString();
                objEntetidad.AGE = txtann.Text = dataGridViewautobus.CurrentRow.Cells["AGE"].Value.ToString();


            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewautobus.SelectedRows.Count > 0)
            {
                objEntetidad.id_AUTOBUS = Convert.ToInt32(dataGridViewautobus.CurrentRow.Cells[0].Value.ToString());
                //idAutobus = dataGridViewautobus.CurrentRow.Cells[0].Value.ToString();

                objetoCN.EliminarAUTOBUS(objEntetidad);
                MessageBox.Show("Eliminado correctamente");
                MostrarAutobus();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
