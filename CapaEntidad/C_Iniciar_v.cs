using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class C_Iniciar_v
    {
        private int id_Viaje;
        private string chofer;
        private string autobus;
        private string ruta;

        public int ID_VIAJE { get => id_Viaje; set => id_Viaje = value; }
        public string CHOFER { get => chofer; set => chofer = value; }
        public string AUTOBUS { get => autobus; set => autobus = value; }
        public string RUTA { get => ruta; set => ruta = value; }
    }
}
