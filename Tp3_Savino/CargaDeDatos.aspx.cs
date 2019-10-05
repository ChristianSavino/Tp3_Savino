using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Voucheria;

namespace Tp3_Savino
{
    public partial class CargaDeDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = int.Parse(dniText.Text);
                Usuario u = new Usuario();
                u.Dni = dni;
                Session["Usuario"] = u;
                Response.Redirect("CargaDeDatos2.aspx");
            }
            catch (Exception)
            {
                Response.Write("<script>alert('DNI Invalido');</script>");
            }
        }
    }
}