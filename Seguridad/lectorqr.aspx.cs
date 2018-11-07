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
            String jn = txtCodigo1.Text;
            txtCodigo1.Text = "";
            Reserva reserva = JsonConvert.DeserializeObject<Reserva>(jn);
            DAOUsuario dAO = new DAOUsuario();
            DataTable reserva1 = dAO.obtenereserva(reserva.Id) ;
            switch (reserva1.Rows[0]["estado"].ToString())
            {
                case "1":

                    break;
                case "2":

                    break;

                default:

                    break;

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
    }
}