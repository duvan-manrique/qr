using System;
using System.Collections.Generic;
using System.Data;
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
            ClientScriptManager cm = this.ClientScript;
            DAOUsuario dAOUsuario1 = new DAOUsuario();
            dAOUsuario1.vista(cm);

            double multa = 0;
          
            try
            {
                multa = double.Parse((dAOUsuario1.obtener_multa(int.Parse(Session["user_id"].ToString()))).Rows[0]["multa"].ToString());
                B_ApartarCupo.Enabled = false;
                B_CancelarCupo.Enabled = false;
                LB_multa.Visible = true;
                B_ApartarCupo.BackColor= System.Drawing.Color.Gray;
                B_CancelarCupo.BackColor = System.Drawing.Color.Gray;
            }
            catch
            {
                
            }


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
        Response.Redirect("CancelarCupo.aspx");
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

    protected void B_Multas_Click(object sender, EventArgs e)
    {
        DAOUsuario dAO = new DAOUsuario();
        DataTable tabla = dAO.obtenerUsuario(int.Parse(Session["user_id"].ToString()));
        Correo correo = new Correo();
        double multa = 0;
        ClientScriptManager cm = this.ClientScript;
        try
        {
             multa = double.Parse((dAO.obtener_multa(int.Parse(Session["user_id"].ToString()))).Rows[0]["multa"].ToString());
            String mensaje = multa.ToString();
            correo.enviarCorreoMulta(tabla.Rows[0]["correo"].ToString(), mensaje);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('multa enviada a su correo');</script>");
        }
        catch
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('no cuenta con multas pendientes');</script>");
        }
        


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
}