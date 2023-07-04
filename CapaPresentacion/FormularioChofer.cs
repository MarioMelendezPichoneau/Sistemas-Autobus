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
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FormularioChofer : Form
    {
        CN_Chofer objetoCN = new CN_Chofer();
        private string idchofer ;
        private bool Editar = false;

        public FormularioChofer()
        {
            InitializeComponent();
        }

       

        private void MostrarChoferes()
        {
            CN_Chofer objeto = new CN_Chofer();
            dataGridView1.DataSource = objeto.Mostrarchofer();

        }

        CHOHER objENTIDAD = new CHOHER();


        private void Guardar_Click(object sender, EventArgs e)
        {

            ////objENTIDAD.id_CHOFER = Convert.ToInt32(idchofer);
            //objENTIDAD.NOMBRE = txtnombre.Text.ToUpper();
            //objENTIDAD.APELLIDO = txtapellido.Text.ToUpper();
            //objENTIDAD.FECHA = txtfecha.Text.ToUpper();
            //objENTIDAD.CEDULA = txtcedula.Text.ToUpper();

            //objetoCN.InsertarChofer(objENTIDAD);

            //MessageBox.Show("se inserto correctamente");
            //MostrarChoferes();
            //limpiarForm();

            if (Editar == false)
            {
                try
                {
                    // objetoCN.InsertarChofer(txtnombre.Text, txtapellido.Text, txtfecha.Text, txtcedula.Text, idchofer);

                    objENTIDAD.NOMBRE = txtnombre.Text.ToUpper();
                    objENTIDAD.APELLIDO = txtapellido.Text.ToUpper();
                    objENTIDAD.FECHA = txtfecha.Text.ToUpper();
                    objENTIDAD.CEDULA = txtcedula.Text.ToUpper();

                    objetoCN.InsertarChofer(objENTIDAD);
                    MessageBox.Show("se inserto correctamente");
                    MostrarChoferes();
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
                    //objetoCN.EditarChofer(idchofer, txtnombre.Text, txtapellido.Text, txtfecha.Text, txtcedula.Text);
                    objENTIDAD.id_CHOFER = Convert.ToInt32(idchofer);
                    objENTIDAD.NOMBRE = txtnombre.Text.ToUpper();
                    objENTIDAD.APELLIDO = txtapellido.Text.ToUpper();
                    objENTIDAD.FECHA = txtfecha.Text.ToUpper();
                    objENTIDAD.CEDULA = txtcedula.Text.ToUpper();

                    objetoCN.EditarChofer(objENTIDAD);

                    MessageBox.Show("se edito correctamente");
                    MostrarChoferes();
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
            idchofer = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtfecha.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtcedula.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void limpiarForm()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtfecha.Clear();
            txtcedula.Clear();
        }

        private void FormularioChofer_Load(object sender, EventArgs e)
        {
            MostrarChoferes();
        }

        private void Edictar_Click(object sender, EventArgs e)
        {

            //objENTIDAD.id_CHOFER = Convert.ToInt32(idchofer);
            //objENTIDAD.NOMBRE = txtnombre.Text.ToUpper();
            //objENTIDAD.APELLIDO = txtapellido.Text.ToUpper();
            //objENTIDAD.FECHA = txtfecha.Text.ToUpper();
            //objENTIDAD.CEDULA = txtcedula.Text.ToUpper();

            //objetoCN.EditarChofer(objENTIDAD);
            //MessageBox.Show("edictado correctamente");

            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;


                idchofer = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                 txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                 txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                 txtfecha.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                  txtcedula.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                

                //idchofer = dataGridView1.CurrentRow.Cells["ID_CHOFER"].Value.ToString();
                //objENTIDAD.NOMBRE = txtnombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                //objENTIDAD.APELLIDO = txtapellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                //objENTIDAD.FECHA = txtfecha.Text = dataGridView1.CurrentRow.Cells["Fecha"].Value.ToString();
                //objENTIDAD.CEDULA = txtcedula.Text = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();
                //objetoCN.EditarChofer(objENTIDAD);

                //objENTIDAD.id_CHOFER = Convert.ToInt32(idchofer);
                //objENTIDAD.NOMBRE = txtnombre.Text.ToUpper();
                //objENTIDAD.APELLIDO = txtapellido.Text.ToUpper();
                //objENTIDAD.FECHA = txtfecha.Text.ToUpper();
                //objENTIDAD.CEDULA = txtcedula.Text.ToUpper();

                //objetoCN.EditarChofer(objENTIDAD);
                
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idchofer = dataGridView1.CurrentRow.Cells["ID_CHOFER"].Value.ToString();
                objetoCN.EliminarPRod(idchofer);
                MessageBox.Show("Eliminado correctamente");
                MostrarChoferes();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

      
    }
    
}
