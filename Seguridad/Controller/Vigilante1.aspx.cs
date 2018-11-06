using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Vigilante : System.Web.UI.Page
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
            ClientScriptManager cm = this.ClientScript;
            DAOUsuario dAOUsuario1 = new DAOUsuario();
            dAOUsuario1.vista(cm);
        }

        Cache.Remove("Vigilante.aspx");
    }

    protected void B_LeerQR_Click(object sender, EventArgs e)
    {
        Response.Redirect("/lectorqr.aspx");
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

    protected void B_ApartarCupoVilgilante_Click(object sender, EventArgs e)
    {
        Response.Redirect("VigilanteApartarCupo.aspx");
    }

    protected void B_VerParquedero_Click(object sender, EventArgs e)
    {
        Response.Redirect("VerParquedero.aspx");
    }
}