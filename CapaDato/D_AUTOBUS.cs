using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data.Common;
using System.Configuration;
using System.Data.OracleClient;

namespace CapaDato
{
    public class D_AUTOBUS
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        //OracleConnection conexion = new OracleConnection("DATA SOURCE = SISTEMA_AUTOBUS ; PASSWORD = 123456 ; USER ID = Sistema");
        //OracleCommand cmd = new OracleCommand();

        //SqlDataReader leer;
        SqlDataAdapter leer = new SqlDataAdapter();
        DataTable tabla = new DataTable();
        //SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            SqlCommand cmd = new SqlCommand("select * from CHOFER", conexion);
            leer.SelectCommand = cmd;
            leer.Fill(tabla);
            

            //conexion.Open();
           // cmd.CommandText = "select * from CHOFER";
           // cmd.CommandType = CommandType.StoredProcedure;
            //leer.SelectCommand = cmd;
            //leer.Fill(tabla);
            //leer = cmd.ExecuteReader();
            //tabla.Load(leer);
            //conexion.Close();
            return tabla;

        }

        // TABLA MOSTAR AUTOBUS
        public DataTable Mos_AUTOBUS()
        {
            SqlCommand cmd = new SqlCommand("select * from AUTOBUS", conexion);
            leer.SelectCommand = cmd;
            leer.Fill(tabla);

            return tabla;
        }


        // TABLA MOSTAR RUTA
        public DataTable Mos_RUTA()
        {
            SqlCommand cmd = new SqlCommand("select * from  RUTA", conexion);
            leer.SelectCommand = cmd;
            leer.Fill(tabla);

            return tabla;
        }



        //MOSTRAS CHOFER
        /*INSERTAR LOS CRUD*/
        //INSERTAR CHOFER
        //public void INSERTAR_CHOFER(string nombre, string apellido, string fecha, string cedula)
        //{
        //    SqlCommand cmd = new SqlCommand("SP_INSERTARCHOFER", conexion);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    conexion.Open();

        //    cmd.Parameters.AddWithValue("@NOMBRE", nombre);
        //    cmd.Parameters.AddWithValue("@APELLIDO", apellido);
        //    cmd.Parameters.AddWithValue("@FECHA", fecha);
        //    cmd.Parameters.AddWithValue("@CEDULA", cedula);
        //    cmd.ExecuteNonQuery();
        //    conexion.Close();
        //}

        public void INSERTAR_CHOFE(CHOHER A)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARCHOFER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", A.NOMBRE);
            cmd.Parameters.AddWithValue("@APELLIDO", A.APELLIDO);
            cmd.Parameters.AddWithValue("@FECHA", A.FECHA);
            cmd.Parameters.AddWithValue("@CEDULA", A.CEDULA);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        //edicatar chofer nuevo

        public void Edictar_chof(CHOHER E)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARCHOFER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_CHOFER", E.id_CHOFER);
            cmd.Parameters.AddWithValue("@NOMBRE", E.NOMBRE);
            cmd.Parameters.AddWithValue("@APELLIDO", E.APELLIDO);
            cmd.Parameters.AddWithValue("@FECHA", E.FECHA);
            cmd.Parameters.AddWithValue("@CEDULA", E.CEDULA);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //ELIMINAR CHOFER
        public void ELIMINAR_CHOFER(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARCHOFER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@ID_CHOFER", id);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        // CRUD DE AUTOBUS

        //INSERTAR AUTOBUS
        public void INSERTAR_AUTOBUS(E_AUTOBUS A)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARAUTOBUS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@MARCA", A.MARCA);
            cmd.Parameters.AddWithValue("@MODELO", A.MODELO);
            cmd.Parameters.AddWithValue("@PLACA", A.PLACA);
            cmd.Parameters.AddWithValue("@COLOR", A.COLOR);
            cmd.Parameters.AddWithValue("@AGE", A.AGE);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //EDITAR AUTOBUS
        public void EDITAR_AUTOBUS(E_AUTOBUS A)
        {

            SqlCommand cmd = new SqlCommand("SP_EDITARAUTOBUS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_AUTOBUS", A.id_AUTOBUS);
            cmd.Parameters.AddWithValue("@MARCA", A.MARCA);
            cmd.Parameters.AddWithValue("@MODELO", A.MODELO);
            cmd.Parameters.AddWithValue("@PLACA", A.PLACA);
            cmd.Parameters.AddWithValue("@COLOR", A.COLOR);
            cmd.Parameters.AddWithValue("@AGE", A.AGE);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //ELIMINAR AUTOBUS
        public void ELIMINAR_AUTOBUS(E_AUTOBUS id)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARAUTOBUS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@ID_AUTOBUS", id.id_AUTOBUS);
            cmd.ExecuteNonQuery();
            conexion.Close(); 
        }

        //  CRUD DE RUTA

        //INSERTAR RUTA
        public void INSERTAR_RUTA(RUTA A)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARRUTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", A.NOMBRE_RUTA);
            
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
       
        
        //INSERTAR EDITAR RUTA
        public void EDITAR_RUTA(RUTA A)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARRUTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_RUTA", A.id_RUTA);
            cmd.Parameters.AddWithValue("@NOMBRE", A.NOMBRE_RUTA);

            cmd.ExecuteNonQuery();
            conexion.Close();
         }
                                   
        //ELIMINAR RUTA
        public void ELIMINAR_RUTA(RUTA id)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARRUTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@ID_RUTA", id.id_RUTA);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        // CARGAR COMBOX//
        // cargando cb//

        public DataTable Combo_chofer()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT NOMBRE FROM CHOFER WHERE DISPO = 'V' ", conexion);
            DataTable dt = new DataTable();
            cmd.Fill(dt);

            return dt;
        }

        public DataTable Combo_Autobus()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT PLACA, CONCAT(MARCA, '', MODELO) AUTOBUS FROM AUTOBUS WHERE DISPO = 'V' ", conexion);
            DataTable dt = new DataTable();
            cmd.Fill(dt);

            return dt;
        }

        public DataTable Combo_Ruta()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT NOMBRE AS RUTA FROM RUTA WHERE DISPO = 'V'", conexion);
            //DataTable dt = new DataTable();
            cmd.Fill(tabla);

            return tabla;
        }

        public List<C_Iniciar_v> CARGAR_VIAJE(string buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("PS_BUSCAR_VIAJE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leerfilas = cmd.ExecuteReader();

            List<C_Iniciar_v> lista = new List<C_Iniciar_v>();

            while (leerfilas.Read())
            {
                lista.Add(new C_Iniciar_v
                {
                    ID_VIAJE = leerfilas.GetInt32(0),
                    CHOFER = leerfilas.GetString(1),
                    AUTOBUS = leerfilas.GetString(2),
                    RUTA = leerfilas.GetString(3)

                });
            }
            conexion.Close();
            leerfilas.Close();
            return lista;

        }

        public void Insertar_Viaje(C_Iniciar_v A)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARVIAJE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CHOFER", A.CHOFER);
            cmd.Parameters.AddWithValue("@AUTOBUS", A.AUTOBUS);
            cmd.Parameters.AddWithValue("@RUTA", A.RUTA);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void Dispo_Chofer(C_Iniciar_v A)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPO_CHOFER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", A.CHOFER);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void Dispo_Autobus(C_Iniciar_v A)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPO_AUTOBUS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@PLACA", A.AUTOBUS);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void Dispo_Ruta(C_Iniciar_v A)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPO_RUTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@RUTA", A.RUTA);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        /*******************************************************************************/

        public void Eliminar_Viaje(C_Iniciar_v A)
        {
            SqlCommand cmd = new SqlCommand("SP_FINALIZAR_VIAJE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_VIAJE", A.ID_VIAJE);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        public void Dispo_Choferv(C_Iniciar_v A)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPO_CHOFER_V", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", A.CHOFER);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void Dispo_Autobusv(C_Iniciar_v A)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPO_AUTOBUS_V", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@PLACA", A.AUTOBUS);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void Dispo_Rutav(C_Iniciar_v A)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPO_RUTA_V", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@RUTA", A.RUTA);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}

