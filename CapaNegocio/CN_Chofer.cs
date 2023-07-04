using CapaDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Chofer
    {
        private D_AUTOBUS objetoCD = new D_AUTOBUS();

        public DataTable Mostrarchofer()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarChofer(CHOHER A)
        {
            objetoCD.INSERTAR_CHOFE(A);
        }

        public void EditarChofer(CHOHER A)
        {
            objetoCD.Edictar_chof(A);
        }

        public void EliminarPRod(string id)
        {
            objetoCD.ELIMINAR_CHOFER(Convert.ToInt32(id));
        }


        // AUTOBUS

        public DataTable MostrarATOBUS()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mos_AUTOBUS();
            return tabla;
        }

        public void InsertAUTOBUS(E_AUTOBUS A)
        {
            objetoCD.INSERTAR_AUTOBUS(A);
        }

        public void EditarAUTOBUS(E_AUTOBUS A)
        {
            objetoCD.EDITAR_AUTOBUS(A);
        }

        public void EliminarAUTOBUS(E_AUTOBUS A)
        {
            objetoCD.ELIMINAR_AUTOBUS(A);
        }

        // AUTOBUS

        public DataTable MostrarRuta()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mos_RUTA();
            return tabla;
        }

        public void InsertRuta(RUTA A)
        {
            objetoCD.INSERTAR_RUTA(A);
        }

        public void EditarRuta(RUTA A)
        {
            objetoCD.EDITAR_RUTA(A);
        }

        public void EliminarRuta(RUTA id)
        {
            objetoCD.ELIMINAR_RUTA(id);
        }

        /****************************************************************************/

        public DataTable CB_CHOFER()
        {
            return objetoCD.Combo_chofer();
        }

        public DataTable CB_AUTOBUS()
        {
            return objetoCD.Combo_Autobus();
        }

        public DataTable CB_RUTA()
        {
            return objetoCD.Combo_Ruta();
        }

        /*************************PROCESOS DE VIAJE*****************************************************/

        public List<C_Iniciar_v> CARGA_V(string b)
        {
            return objetoCD.CARGAR_VIAJE(b);

        }


        public void INSERTAR_V(C_Iniciar_v A)
        {
            objetoCD.Insertar_Viaje(A);
        }


        public void DISPO_C(C_Iniciar_v A)
        {
            objetoCD.Dispo_Chofer(A);
        }

        public void DISPO_A(C_Iniciar_v A)
        {
            objetoCD.Dispo_Autobus(A);
        }

        public void DISPO_R(C_Iniciar_v A)
        {
            objetoCD.Dispo_Ruta(A);
        }

        /*******************************************************************/

        public void FINALIZAR_V(C_Iniciar_v A)
        {
            objetoCD.Eliminar_Viaje(A);
        }


        public void DISPO_CV(C_Iniciar_v A)
        {
            objetoCD.Dispo_Choferv(A);
        }

        public void DISPO_AV(C_Iniciar_v A)
        {
            objetoCD.Dispo_Autobusv(A);
        }

        public void DISPO_RV(C_Iniciar_v A)
        {
            objetoCD.Dispo_Rutav(A);
        }


    }
}
