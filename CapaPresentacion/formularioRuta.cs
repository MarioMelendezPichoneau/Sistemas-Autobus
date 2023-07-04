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
    public partial class formularioRuta : Form
    {
        CN_Chofer objetoCN = new CN_Chofer();

        private string idRuta = null;
        private bool Editar = false;

        public formularioRuta()
        {
            InitializeComponent();
        }

        private void formularioRuta_Load(object sender, EventArgs e)
        {
            MostrarRuta();
        }


        private void MostrarRuta()
        {
            CN_Chofer objeto = new CN_Chofer();
            dataGridView1.DataSource = objeto.MostrarRuta();

        }

        private void limpiarForm()
        {
            txtnombre.Clear();
        }


        RUTA objEntetidad = new RUTA();

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objEntetidad.NOMBRE_RUTA = txtnombre.Text.ToUpper();

                    objetoCN.InsertRuta(objEntetidad);

                    MessageBox.Show("se inserto correctamente");
                    MostrarRuta();
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
                    objEntetidad.id_RUTA = Convert.ToInt32(idRuta);
                    objEntetidad.NOMBRE_RUTA = txtnombre.Text.ToUpper();
                    objetoCN.EditarRuta(objEntetidad);


                    MessageBox.Show("se edito correctamente");
                    MostrarRuta(); 
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
            idRuta = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void edictar_Click(object sender, EventArgs e)
        {
            

            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;

                idRuta = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                objEntetidad.NOMBRE_RUTA = txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objEntetidad.id_RUTA = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()); 
                objetoCN.EliminarRuta(objEntetidad);
                MessageBox.Show("Eliminado correctamente");
                MostrarRuta();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
