using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CHOHER
    {
        //ATRIBUTOS CHOFER

        private int _id_CHOFER;
        private string _NOMBRE;
        private string _APELLIDO;
        private string _FECHA;
        private string _CEDULA;


        //PROPIEDADES CHOFER 
        public int id_CHOFER { get => _id_CHOFER; set => _id_CHOFER = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string APELLIDO { get => _APELLIDO; set => _APELLIDO = value; }
        public string FECHA { get => _FECHA; set => _FECHA = value; }
        public string CEDULA { get => _CEDULA; set => _CEDULA = value; }

    }
    public class RUTA
    {
        //ATRIBUTOS RUTA

        private int _id_RUTA;
        private string _NOMBRE_RUTA;

        //PROPIEDADES RUTA 
        public int id_RUTA { get => _id_RUTA; set => _id_RUTA = value; }
        public string NOMBRE_RUTA { get => _NOMBRE_RUTA; set => _NOMBRE_RUTA = value; }

    }


    public class E_AUTOBUS
    {

        //ATRIBUTOS AUTOBUS

        private int _id_AUTOBUS;
        private string _MARCA;
        private string _MODELO;
        private string _PLACA;
        private string _COLOR;
        private string _AGE;

        //PROPIEDADES AUTOBUS 
        public int id_AUTOBUS { get => _id_AUTOBUS; set => _id_AUTOBUS = value; }
        public string MARCA { get => _MARCA; set => _MARCA = value; }
        public string MODELO { get => _MODELO; set => _MODELO = value; }
        public string PLACA { get => _PLACA; set => _PLACA = value; }
        public string COLOR { get => _COLOR; set => _COLOR = value; }
        public string AGE { get => _AGE; set => _AGE = value; }

        
    }
}
