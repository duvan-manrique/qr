using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prestamos
{
    public partial class lectorqr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] == null)
            {
                Response.Redirect("View/Loggin.aspx");
            }
            else
            {
                L_Nombre.Text = Session["nombre"].ToString();
            }

            Cache.Remove("lectorqr.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClientScriptManager cm = this.ClientScript;
            if (Session["info"]!= null)
            {
                
                String jn = txtCodigo1.Text;
                txtCodigo1.Text = "";
                Reserva reserva = JsonConvert.DeserializeObject<Reserva>(jn);
                DAOUsuario dAO = new DAOUsuario();
                DataTable reserva1 = dAO.obtenereserva(int.Parse(jn));
                switch (reserva1.Rows[0]["estado"].ToString())
                {
                    case "1":
                        DateTime hoy = DateTime.Now;
                        if (hoy.Date == (DateTime.Parse(reserva1.Rows[0]["fecha_inicio"].ToString())).Date)
                        {
                            if (hoy.Hour == (DateTime.Parse(reserva1.Rows[0]["fecha_inicio"].ToString())).Hour)
                            {
                                if (hoy.Minute == (DateTime.Parse(reserva1.Rows[0]["fecha_inicio"].ToString())).Minute)
                                {
                                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('ingreso registrado');</script>");
                                    //autorizar cambiar a 2 
                                }
                                else
                                {
                                    TimeSpan x = hoy.Subtract(DateTime.Parse(reserva1.Rows[0]["fecha_inicio"].ToString()));
                                    int time = x.Minutes;
                                    if (time <= 10 && time >= 0)
                                    {
                                        //cambia a autorzada
                                    }
                                    else
                                    {
                                        if (x.Minutes > 10)
                                        {
                                            //reserva pasada por 10 minutos
                                        }
                                        else
                                        {
                                            //aun no es hora de su reserva
                                        }

                                    }
                                }
                            }
                            else
                            {
                                TimeSpan x = hoy.Subtract(DateTime.Parse(reserva1.Rows[0]["fecha_inicio"].ToString()));
                                if (x.Hours == 0)
                                {
                                    TimeSpan x1 = hoy.Subtract((DateTime.Parse(reserva1.Rows[0]["fecha_inicio"].ToString())));
                                    int time = x1.Minutes;
                                    if (time <= 10 && time >= 0)
                                    {
                                        //cambia a autorzada
                                    }
                                    else
                                    {
                                        if (x.Minutes > 10)
                                        {
                                            //reserva pasada por 10 minutos
                                        }
                                        else
                                        {
                                            //aun no es hora de su reserva
                                        }
                                    }
                                }
                                else
                                {
                                    if (x.Hours > 0)
                                    {
                                        //reserva pasada por 1 hora
                                    }
                                    else
                                    {
                                        //aun no es hora de su reserva
                                    }
                                }

                            }

                        }
                        else
                        {
                            // su reserva no es hoy
                        }
                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('ingreso registrado');</script>");
                        break;
                    case "2":

                        break;

                    default:

                        break;

                }
            }
            else
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('verifique el automovil');</script>");
            }
            


        }

        protected void B_Cierre_Click(object sender, EventArgs e)
        {

            Session["user_id"] = null;
            Session["nombre"] = null;

            DAOUsuario user = new DAOUsuario();
            EUsuario datos = new EUsuario();
            datos.Session = Session.SessionID;
            user.cerrarSession(datos);

            Response.Redirect("View/Loggin.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}