using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_MenuAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        if (Session["user_id"] == null)
            Response.Redirect("Loggin.aspx");
        else
        {
     

            ClientScriptManager cm = this.ClientScript;
            DAOUsuario dAOUsuario1 = new DAOUsuario();
            dAOUsuario1.vista(cm);
            L_Nombre.Text = Session["nombre"].ToString();
            EUsuario user = (EUsuario)Session["user"];
            string url;
            if (user.RolId != 1)
            {
                switch (user.RolId)
                {
                    case 1:
                        url = "MenuAdmin.aspx";
                        break;
                    case 2:
                        url = "MenuOperario.aspx";
                        break;
                    default:
                        url = "Loggin.aspx";
                        break;
                }
                Response.Redirect(url);
            }

        }
        Cache.Remove("MenuAdmin.aspx");

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

    protected void B_BuscarUsuario_Click(object sender, EventArgs e)
    {
        Response.Redirect("EliminaroBuscarUsuario.aspx");
    }

    protected void B_CrearUsuario_Click(object sender, EventArgs e)
    {
        Response.Redirect("CrearUsuarioAdmin.aspx");
        
    }

 


    protected void B_BuscarZona_Click(object sender, EventArgs e)
    {
        Response.Redirect("BuscaryEliminar.aspx");
    }

    
    protected void B_CrearZona_Click(object sender, EventArgs e)
    {
        Response.Redirect("CrearZona.aspx");
    }





    protected void B_CreaReservacion_Click(object sender, EventArgs e)
    {
        Response.Redirect("UsuarioApartarCupo.aspx");

    }


    protected void B_BuscarReservacion_Click(object sender, EventArgs e)
    {
        Response.Redirect("Buscareliminarreservacion.aspx");
    }

    protected void B_Verparquedero_Click(object sender, EventArgs e)
    {
        Response.Redirect("VerParquedero.aspx");
    }

    protected void B_AdministrarParquedero_Click(object sender, EventArgs e)
    {
        Response.Redirect("configuracion.aspx");
    }

    protected void B_Multas_Click(object sender, EventArgs e)
    {
        Response.Redirect("MultasAdmin.aspx");
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (int.Parse(Session["rolId"].ToString()) == 1)
        {
            Response.Redirect("MenuAdmin.aspx");
        }
        else if (int.Parse(Session["rolId"].ToString()) == 2)
        {
            Response.Redirect("Vigilante.aspx");
        }
        else if (int.Parse(Session["rolId"].ToString()) == 3)
        {
            Response.Redirect("Usuario.aspx");
        }
        else
        {
            Response.Redirect("Loggin.aspx");
        }
    }

    protected void B_CreaReservacionadministrativo_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminApartarCupo.aspx");
    }
}