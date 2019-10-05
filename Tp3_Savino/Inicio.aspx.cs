using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Voucheria;


namespace Tp3_Savino
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContinuar_Click(object sender, EventArgs e)
        {      
            string voucher = voucherText.Text;
            ValidarVoucher(voucher);
        }

        protected void ValidarVoucher(string voucher)
        {
            try
            {
                Voucheriappal manager = new Voucheriappal();
                if(manager.ValidarVoucher(voucher))
                {
                    //Response.Write("<script>alert('Voucher Correcto');</script>");
                    Voucher V = new Voucher();
                    V.codigo = voucher;
                    V.estado = true;
                    Session["Voucher"] = V;
                    Response.Redirect("CargaDeDatos.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Voucher ya utilizado / Voucher Invalido');</script>");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Voucher ya utilizado / Voucher Invalido');</script>");
            }
        }
    }
}