using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucheria
{
    public class Voucher
    {
        #region variables   
        private string icodigo;
        private bool iestado;
        private int icliente;
        private int iproducto;
        private DateTime ifecha;
        #endregion

        #region propiedades
        public string codigo
        {
            get
            {
                return icodigo;
            }
            set
            {
                icodigo = value;
            }
        }

        public bool estado
        {

            get
            {
                return iestado;
            }
            set
            {
                iestado = value;
            }
        }

        public int cliente
        {

            get
            {
                return icliente;
            }
            set
            {
                icliente = value;
            }
        }

        public int producto
        {

            get
            {
                return iproducto;
            }
            set
            {
                iproducto = value;
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
