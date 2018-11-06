using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class View_Loggin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        DAOUsuario dAOUsuario1 = new DAOUsuario();
        dAOUsuario1.vista(cm);
    }

    protected void L_Autenticate_Authenticate(object sender, AuthenticateEventArgs e)
    {  
        DAOUsuario guardarUsuario = new DAOUsuario();
        DataTable data = guardarUsuario.loggin(L_Autenticate.UserName.ToString(), L_Autenticate.Password.ToString());

        if(int.Parse(data.Rows[0]["user_id"].ToString()) > 0)
        {
            Session["nombre"] = data.Rows[0]["nombre"].ToString();
            Session["user_id"] = data.Rows[0]["user_id"].ToString();

            EUsuario datosUsuario = new EUsuario();
            MAC datosConexion = new MAC();

           /* ipAddress = HttpContext.Current.Request.UserHostAddress;
            mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

            datosUsuario.UserId = int.Parse(Session["user_id"].ToString());
            datosUsuario.Ip = datosConexion.ip();
            datosUsuario.Mac = datosConexion.mac();
            datosUsuario.Session = Session.SessionID;

            guardarUsuario.guardadoSession(datosUsuario);

            Response.Redirect("MenuAdmin.aspx");
        }

    }

    protected void LB_Recuperar_Click(object sender, EventArgs e)
    {
        Response.Redirect("GenerarToken.aspx");
    }

    protected void L_Autenticate_Authenticate(object sender, EventArgs e)
    {
        DAOUsuario guardarUsuario = new DAOUsuario();
        DataTable data = guardarUsuario.loggin(L_Autenticate.UserName.ToString(), L_Autenticate.Password.ToString());

        if (int.Parse(data.Rows[0]["user_id"].ToString()) > 0)
        {
            Session["nombre"] = data.Rows[0]["nombre"].ToString();
            Session["user_id"] = data.Rows[0]["user_id"].ToString();

            EUsuario datosUsuario = new EUsuario();
            MAC datosConexion = new MAC();

            /* ipAddress = HttpContext.Current.Request.UserHostAddress;
             mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

            datosUsuario.UserId = int.Parse(Session["user_id"].ToString());
            datosUsuario.Ip = datosConexion.ip();
            datosUsuario.Mac = datosConexion.mac();
            datosUsuario.Session = Session.SessionID;
            datosUsuario.RolId = int.Parse(data.Rows[0]["rol_id"].ToString());
            Session["user"] = datosUsuario;
            guardarUsuario.guardadoSession(datosUsuario);
            if(datosUsuario.RolId == 1)
                Response.Redirect("MenuAdmin.aspx");
            else if (datosUsuario.RolId == 2)
                Response.Redirect("Vigilante.aspx");
            else
                Response.Redirect("Usuario.aspx");
           
        }
    }

    protected void B_registrarse_Click(object sender, EventArgs e)
    {
         Response.Redirect("CrearUsuario.aspx");
    }
}