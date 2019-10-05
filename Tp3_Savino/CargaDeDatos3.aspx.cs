using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Voucheria;

namespace Tp3_Savino
{
    public partial class CargaDeDatos3 : System.Web.UI.Page
    {
        Usuario usuario;
        Voucher voucher;
        string html;

        protected override void OnInit(EventArgs e)
        {
            try
            {
                base.OnInit(e);
                Voucheriappal v = new Voucheriappal();
                html = v.GetProductos(html);
                test.InnerHtml = html;
            }
            catch (Exception)
            {
           
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var valorQueViene = Request.QueryString["valor"];
                var producto = int.Parse(valorQueViene);
                if(producto != 0)
                {
                    usuario = (Usuario)Session["Usuario"];
                    voucher = (Voucher)Session["Voucher"];
                    Producto p = new Producto();
                    p.Id = producto;
                    Voucheriappal v = new Voucheriappal();
                    v.CrearTransaccion(usuario, voucher, p);
                    v = null;
                    Response.Redirect("Congratulations.aspx");
                }
            }
            catch (Exception)
            {
                if(IsPostBack)
                {
                    Response.Write("<script>alert('Error!');</script>");
                }
            }
        }
    }
}