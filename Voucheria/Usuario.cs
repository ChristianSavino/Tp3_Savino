using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucheria
{
    public class Usuario
    {
        #region variables   
        private string iNombre;
        private string iApellido;
        private string iEmail;
        private string iDireccion;
        private string iCiudad;
        private string iCodigoPostal;
        private Int64 iiD;
        private int idni;
        private DateTime ifecha;
        #endregion

        #region propiedades
        public string Nombre
        {
            get
            {
                return iNombre;
            }
            set
            {
                iNombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return iApellido;
            }
            set
            {
                iApellido = value;
            }
        }

        public string Email
        {
            get
            {
                return iEmail;
            }
            set
            {
                iEmail = value;
            }
        }

        public string Direccion
        {
            get
            {
                return iDireccion;
            }
            set
            {
                iDireccion = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return iCiudad;
            }
            set
            {
                iCiudad = value;
            }
        }

        public string CodigoPostal
        {
            get
            {
                return iCodigoPostal;
            }
            set
            {
                iCodigoPostal = value;
            }
        }

        public int Dni
        {

            get
            {
                return idni;
            }
            set
            {
                idni = value;
            }
        }
        public Int64 Id
        {

            get
            {
                return iiD;
            }
            set
            {
                iiD = value;
            }
        }

        public DateTime fecha
        {
            get
            {
                return ifecha;
            }
            set
            {
                ifecha = value;
            }
        }
        #endregion
    }
}
