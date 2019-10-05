using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucheria
{
    public class Producto
    {
        private Int64 iId;
        private string iTitulo;
        private string iDescripcion;
        private string iURLImagen;

        public Int64 Id
        {
            get
            {
                return iId;
            }
            set
            {
                iId = value;
            }
        }

        public string Titulo
        {
            get
            {
                return iTitulo;
            }
            set
            {
                iTitulo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return iDescripcion;
            }
            set
            {
                iDescripcion = value;
            }
        }

        public string URLImagen
        {
            get
            {
                return iURLImagen;
            }
            set
            {
                iURLImagen = value;
            }
        }
    }
}
