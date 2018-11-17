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
                //Reserva reserva = JsonConvert.DeserializeObject<Reserva>(jn);
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
                                    dAO.update_entrda(int.Parse(reserva1.Rows[0]["id"].ToString()), int.Parse(reserva1.Rows[0]["qr"].ToString()),hoy);
                                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('ingreso registrado');</script>");
                                    //autorizar cambiar a 2
                                }
                                else
                                {
                                    TimeSpan x = hoy.Subtract(DateTime.Parse(reserva1.Rows[0]["fecha_inicio"].ToString()));
                                    int time = x.Minutes;
                                    if (time <= 10 && time >= 0)
                                    {
                                        dAO.update_entrda(int.Parse(reserva1.Rows[0]["id"].ToString()), int.Parse(reserva1.Rows[0]["qr"].ToString()), hoy);
                                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('ingreso registrado');</script>");
                                        //cambia a autorzada
                                    }
                                    else
                                    {
                                        if (x.Minutes > 10)
                                        {
                                            dAO.update_salida(int.Parse(reserva1.Rows[0]["id"].ToString()), int.Parse(reserva1.Rows[0]["qr"].ToString()), hoy);
                                            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('reservacion perdida por desface de tiempo');</script>");
                                            //reserva pasada por 10 minutos
                                        }
                                        else
                                        {
                                            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('aun no es tiempo de ingreso de esta reservacion');</script>");
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
                                        dAO.update_entrda(int.Parse(reserva1.Rows[0]["id"].ToString()), int.Parse(reserva1.Rows[0]["qr"].ToString()), hoy);
                                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('ingreso registrado');</script>");
                                        //cambia a autorzada
                                    }
                                    else
                                    {
                                        if (x.Minutes > 10)
                                        {

                                            dAO.update_salida(int.Parse(reserva1.Rows[0]["id"].ToString()), int.Parse(reserva1.Rows[0]["qr"].ToString()), hoy);
                                            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('reservacion perdida por desface de tiempo');</script>");
                                            //reserva pasada por 10 minutos
                                        }
                                        else
                                        {
                                            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('aun no es tiempo de ingreso de esta reservacion');</script>");
                                            //aun no es hora de su reserva
                                        }
                                    }
                                }
                                else
                                {
                                    if (x.Hours > 0)
                                    {
                                        dAO.update_salida(int.Parse(reserva1.Rows[0]["id"].ToString()), int.Parse(reserva1.Rows[0]["qr"].ToString()), hoy);
                                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('reservacion perdida por desface de tiempo');</script>");
                                        //reserva pasada por 1 hora
                                    }
                                    else
                                    {
                                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('aun no es tiempo de ingreso de esta reservacion');</script>");
                                        //aun no es hora de su reserva
                                    }
                                }

                            }

                        }
                        else
                        {
                            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('lamentablemente la reservacion es para otro dia');</script>");
                            // su reserva no es hoy
                        }
                        
                        break;
                    case "2":
                        DateTime hoy1 = DateTime.Now;
                        TimeSpan xa = hoy1.Subtract(DateTime.Parse(reserva1.Rows[0]["fecha_fin"].ToString()));
                        
                        if (xa.Minutes>10 || xa.Hours>0)
                        {
                            //hacer multa falta 
                            //consulta de tipo_vehiculo para traer valor multa 
                            // insert en tabla de multa
                            // enviar valor de multa en el correo
                            DataTable multas = dAO.obtenerMultasTodos();
                            double v_multa = 0;
                            int tipo_v = int.Parse((dAO.obtenerTipo(int.Parse(reserva1.Rows[0]["parqueadero_id"].ToString()))).Rows[0][0].ToString()) ;
                            
                            for (int i =0;i<multas.Rows.Count;i++)
                            {
                                if (multas.Rows[i]["id"].ToString()== tipo_v.ToString() )
                                {
                                    v_multa = double.Parse(multas.Rows[i]["valor_multa"].ToString());
                                    break;
                                }
                            }
                            double multa = ((xa.TotalSeconds / 60) / 60) * (v_multa);
                            int id_user = int.Parse((dAO.obtener_user_vehiculo(int.Parse(reserva1.Rows[0]["vehiculo_id"].ToString()))).Rows[0][0].ToString());
                            dAO.update_salida(int.Parse(reserva1.Rows[0]["id"].ToString()), int.Parse(reserva1.Rows[0]["qr"].ToString()), hoy1);
                            dAO.Insert_multa( id_user, int.Parse(reserva1.Rows[0]["id"].ToString()),multa);

                            DataTable tabla = dAO.obtenerUsuario(int.Parse(Session["user_id"].ToString()));
                            Correo correo = new Correo();
                            
                            String mensaje = multa.ToString();
                            correo.enviarCorreoMulta(tabla.Rows[0]["correo"].ToString(), mensaje);

                            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('salida exitosa pero con multa');</script>");

                        }
                        else
                        {

                            dAO.update_salida(int.Parse(reserva1.Rows[0]["id"].ToString()), int.Parse(reserva1.Rows[0]["qr"].ToString()), hoy1);
                            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('salida exitosa');</script>");

                        }

                        break;

                    default:
                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('reservacion no valida');</script>");
                        break;

                }
            }
            else
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('verifique el automovil');</script>");
            }

            Session["info"] = null;
            Button1.Enabled = false;
            Button2.Enabled = true;
            Button3.Enabled = false;
            TB_descrip.Text = "";
            TB_placa.Text = "";
            Button1.BackColor = System.Drawing.Color.Gray;


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
           
            ClientScriptManager cm = this.ClientScript;
            String jn = txtCodigo1.Text;
            Button3.Enabled = true;
            if (jn == "")
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('debe leer el qr primero');</script>");
            }
            else{
                Button3.BackColor = System.Drawing.Color.Green;
                try
                {
                    int id = int.Parse(jn);
                    DAOUsuario dAO = new DAOUsuario();
                    DataTable tabla = dAO.obtenereserva(id);
                    if (tabla.Rows.Count==0)
                    {
                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('codigo de reserva no valido');</script>");
                    }
                    int id2 = int.Parse(tabla.Rows[0]["vehiculo_id"].ToString());
                    DataTable tabla1 = dAO.obtenervehiculouno(id2);
                    TB_descrip.Text = tabla.Rows[0]["descripcion"].ToString();
                    TB_placa.Text = tabla1.Rows[0][0].ToString();
                    Button3.Enabled = true;
                }
                catch
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('a ocurrido un error');</script>");
                }
                              
                    
           
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button1.BackColor = System.Drawing.Color.Green;
            Button3.BackColor = System.Drawing.Color.Gray;
            Session["info"] = null;
            Session["info"]= 1;
            Button1.Enabled = true;
            Button2.Enabled = false;
            Button3.Enabled = false;
        }
    }
}