using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            String jn = txtCodigo.Text;
            Reserva reserva = JsonConvert.DeserializeObject(jn) as Reserva;

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