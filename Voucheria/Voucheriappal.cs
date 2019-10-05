using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Drawing;

namespace Voucheria
{
    public class Voucheriappal
    {
        private AccesoDatos accesoDatos;
        public bool ValidarVoucher(string voucher)
        {
            try
            {
                accesoDatos = new AccesoDatos();
                accesoDatos.setearConsulta("Select estado as 'Estado' from vouchers where codigovoucher = @codigo");
                accesoDatos.agregarParametro("@codigo", voucher);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                if(accesoDatos.Lector.HasRows)
                {
                    if(accesoDatos.Lector.Read())
                    {
                        if (accesoDatos.Lector.GetBoolean(accesoDatos.Lector.GetOrdinal("Estado")) == true)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                accesoDatos.Lector.Close();
                accesoDatos.cerrarConexion();
                accesoDatos = null;
            }
        }

        public Usuario BuscarCliente(int dni)
        {
            Usuario u = new Usuario();
            u.Dni = dni;
            try
            {
                accesoDatos = new AccesoDatos();
                accesoDatos.setearConsulta("Select ID,Nombre, DNI ,Apellido, Email, Direccion,Ciudad,CodigoPostal,FechaRegistro from Clientes where dni = @dni");
                accesoDatos.agregarParametro("@dni", dni);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                if(accesoDatos.Lector.HasRows)
                {
                    if(accesoDatos.Lector.Read())
                    {
                        u.Id = accesoDatos.Lector.GetInt64(accesoDatos.Lector.GetOrdinal("Id"));
                        u.Nombre = accesoDatos.Lector.GetString(accesoDatos.Lector.GetOrdinal("Nombre"));
                        u.Apellido = accesoDatos.Lector.GetString(accesoDatos.Lector.GetOrdinal("Apellido"));
                        u.Email = accesoDatos.Lector.GetString(accesoDatos.Lector.GetOrdinal("Email"));
                        u.Dni = accesoDatos.Lector.GetInt32(accesoDatos.Lector.GetOrdinal("DNI"));
                        u.Direccion = accesoDatos.Lector.GetString(accesoDatos.Lector.GetOrdinal("Direccion"));
                        u.Ciudad = accesoDatos.Lector.GetString(accesoDatos.Lector.GetOrdinal("Ciudad"));
                        u.CodigoPostal = accesoDatos.Lector.GetString(accesoDatos.Lector.GetOrdinal("CodigoPostal"));
                        u.fecha = accesoDatos.Lector.GetDateTime(accesoDatos.Lector.GetOrdinal("FechaRegistro"));
                        return u;
                    }
                }
                return u;
            }
            catch (Exception)
            {
                return u;
            }
            finally
            {
                accesoDatos.Lector.Close();
                accesoDatos.cerrarConexion();
                accesoDatos = null;
            }
        }

        public string GetProductos(string html)
        {
            try
            {               
                accesoDatos = new AccesoDatos();
                accesoDatos.setearConsulta("Select Id,Titulo,Descripcion,URLImagen from Productos");
                accesoDatos.abrirConexion();
                Producto p;
                accesoDatos.ejecutarConsulta();
                if(accesoDatos.Lector.HasRows)
                {
                    while(accesoDatos.Lector.Read())
                    {
                        p = null;
                        p = new Producto();
                        p.Id = accesoDatos.Lector.GetInt64(accesoDatos.Lector.GetOrdinal("Id"));
                        p.Titulo = accesoDatos.Lector.GetString(accesoDatos.Lector.GetOrdinal("Titulo"));
                        p.Descripcion = accesoDatos.Lector.GetString(accesoDatos.Lector.GetOrdinal("Descripcion"));
                        p.URLImagen = accesoDatos.Lector.GetString(accesoDatos.Lector.GetOrdinal("URLImagen"));
                        html += "<div class=\"card\" style=\"width: 18rem;\">";
                        html += "<img class=\"card-img-top\" src="+p.URLImagen +" alt=\"Card image cap\">";
                        html += "<div class=\"card-body\">";
                        html += "<h5 class=\"card-title\">"+p.Titulo+"</h5>";
                        html += "<p class=\"card-text\">"+p.Descripcion+"</p>";
                        html += "<a href =\"CargaDeDatos3.aspx?valor="+p.Id+"\" class=\"btn btn-primary btn-lg\" runat=\"server\">Quiero Este</a>";
                        //html += "<input ID=\""+p.Id+"\" type=\"button\" class=\"btn btn-primary btn-lg\" runat=\"server\" value=\"Quiero Este\" OnClick=\"\"/>";
                        //html +=  "<asp:LinkButton ID=\""+p.Id+"\" class=\"btn btn-primary btn-lg\" runat=\"server\" Text=\"Siguiente paso &raquo;\" OnClick=\"btnContinuar_Click\"/>";
                        html += "</div>";
                        html += "</div>";
                        html += "<p></p>";
                    }
                }
                return html;
            }
            catch (Exception)
            {
                return "Error!";
            }
            finally
            {
                accesoDatos.Lector.Close();
                accesoDatos.cerrarConexion();
                accesoDatos = null;
            }           
        }

        public void CrearTransaccion(Usuario u, Voucher v, Producto p)
        {
            try
            {
                //Agregamos al Cliente si no existe            
                if (u.Id == 0)
                {
                    accesoDatos = new AccesoDatos();
                    accesoDatos.setearConsulta("INSERT INTO Clientes (DNI,Nombre,Apellido,Email,Direccion,Ciudad,CodigoPostal,FechaRegistro) VALUES (@dni,@nombre,@apellido,@email,@direccion,@ciudad,@codigopostal,GETDATE())");
                    accesoDatos.agregarParametro("@dni", u.Dni);
                    accesoDatos.agregarParametro("@nombre", u.Nombre);
                    accesoDatos.agregarParametro("@apellido", u.Apellido);
                    accesoDatos.agregarParametro("@direccion", u.Direccion);
                    accesoDatos.agregarParametro("@email", u.Email);
                    accesoDatos.agregarParametro("@ciudad", u.Ciudad);
                    accesoDatos.agregarParametro("@codigopostal", u.CodigoPostal);
                    accesoDatos.abrirConexion();
                    accesoDatos.ejecutarAccion();
                    accesoDatos.cerrarConexion();
                    accesoDatos = null;
                    accesoDatos = new AccesoDatos();
                    u = BuscarCliente(u.Dni);
                }

                //Actualizamos el voucher
                accesoDatos = new AccesoDatos();
                accesoDatos.setearConsulta("UPDATE vouchers SET Estado = @estado, IdCliente = @idcliente, IdProducto = @idproducto, FechaRegistro = GETDATE() WHERE CodigoVoucher = @codigo ");
                accesoDatos.agregarParametro("@estado", v.estado);
                accesoDatos.agregarParametro("@idcliente", u.Id);
                accesoDatos.agregarParametro("@idproducto", p.Id);
                accesoDatos.agregarParametro("@codigo", v.codigo);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
                accesoDatos.cerrarConexion();
                accesoDatos = null;
            }
            catch (Exception e)
            {

            }
        }
    }
}
