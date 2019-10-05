using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Voucheria;

namespace Tp3_Savino
{
    public partial class CargaDeDatos2 : System.Web.UI.Page
    {
        Voucher voucher;
        Usuario usuario;
        string error;

        protected void Page_Load(object sender, EventArgs e)
        {
            voucher = (Voucher)Session["Voucher"];
            usuario = (Usuario)Session["Usuario"];
            BuscarUsuario();
            if(usuario.Id == 0)
            {
               usuario.Apellido = apellidoText.Text;
               usuario.Nombre = nombreText.Text;
               usuario.Ciudad = ciudadText.Text;
               usuario.Direccion = direccionText.Text;
               usuario.Email = emailText.Text;
               usuario.CodigoPostal = codigoPostalText.Text;
            }
            if (!IsPostBack)
            {
                voucherText.Text = voucher.codigo;
                dniText.Text = usuario.Dni.ToString();
                if (usuario.Id != 0)
                {
                    ActualizarText(usuario);
                }
            }
        }

        void BuscarUsuario()
        {
            try
            {
                Voucheriappal v = new Voucheriappal();
                usuario = v.BuscarCliente(usuario.Dni);
            }
            catch (Exception)
            {

            }
        }

        void ActualizarText(Usuario usuario)
        {
            apellidoText.Text = usuario.Apellido;
            nombreText.Text = usuario.Nombre;
            ciudadText.Text = usuario.Ciudad;
            direccionText.Text = usuario.Direccion;
            emailText.Text = usuario.Email;
            codigoPostalText.Text = usuario.CodigoPostal;

            apellidoText.Enabled = false;
            nombreText.Enabled = false;
            emailText.Enabled = false;
            ciudadText.Enabled= false;
            direccionText.Enabled = false;
            codigoPostalText.Enabled = false;
        }

        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                if(usuario.Id == 0)
                {
                    Validar();
                }
                Session["Voucher"] = voucher;
                Session["Usuario"] = usuario;
                Response.Redirect("CargadeDatos3.aspx");
            }
            catch (Exception)
            {
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        bool EspaciosBlanco(string texto)
        {
            if (texto == "" || texto == " ")
            {
                return true;
            }
            return false;
        }

        void Validar()
        {
            try
            {
                if (EspaciosBlanco(nombreText.Text))
                {
                    error = "Falta el nombre";
                    throw new Exception();
                }
                if (EspaciosBlanco(apellidoText.Text))
                {
                    error = "Falta el Apellido";
                    throw new Exception();
                }
                if (EspaciosBlanco(direccionText.Text))
                {
                    error = "Falta la Direccion";
                    throw new Exception();
                }
                if (EspaciosBlanco(ciudadText.Text))
                {
                    error = "Falta la Ciudad";
                    throw new Exception();
                }
                if (EspaciosBlanco(codigoPostalText.Text))
                {
                    error = "Falta el Codigo Postal";
                    throw new Exception();
                }
                if (!IsValidEmail(emailText.Text))
                {
                    error = "Mail incorrecto";
                    throw new Exception();
                }
                bool solotexto;
                if (!(solotexto = nombreText.Text.All(Char.IsLetter)))
                {
                    error = "Nombre solo debe tener letras";
                }
                if (!(solotexto = apellidoText.Text.All(Char.IsLetter)))
                {
                    error = "Apellido solo debe tener letras";
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('" + error + "');</script>");
            }           
        }
    }
}