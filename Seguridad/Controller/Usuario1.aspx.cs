using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Usuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null)
        {
            Response.Redirect("Loggin.aspx");
        }
        else
        {
            L_Nombre.Text = Session["nombre"].ToString();
        }

        Cache.Remove("Usuario.aspx");
    }



    protected void B_ApartarCupo_Click(object sender, EventArgs e)
    {
        Response.Redirect("UsuarioApartarCupo.aspx");
    }

    protected void B_EditarPerfil_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditarUsuario.aspx");
    }

    protected void B_CancelarCupo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Usuariocancelarcupo.aspx");
    }

    protected void B_BuscarCupo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ConsultarCupoUsuario.aspx");
    }

    protected void B_Cierre_Click(object sender, EventArgs e)
    {
        Session["user_id"] = null;
        Session["nombre"] = null;

        DAOUsuario user = new DAOUsuario();
        EUsuario datos = new EUsuario();
        datos.Session = Session.SessionID;
        user.cerrarSession(datos);

        Response.Redirect("Loggin.aspx");



    }
}