﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_RecuperarContraseña : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString.Count > 0)
        {
            ClientScriptManager cm = this.ClientScript;
            DAOUsuario dAOUsuario1 = new DAOUsuario();
            dAOUsuario1.vista(cm);

            DAOUsuario user = new DAOUsuario();
            DataTable info = user.obtenerUsusarioToken(Request.QueryString[0]);

            if (int.Parse(info.Rows[0][0].ToString()) == -1)
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El Token es invalido. Genere uno nuevo');window.location=\"Loggin.aspx\"</script>");
            else if (int.Parse(info.Rows[0][0].ToString()) == -1)
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El Token esta vencido. Genere uno nuevo');window.location=\"Loggin.aspx\"</script>");
            else
                Session["user_id"] = int.Parse(info.Rows[0][0].ToString());       
        }

        else
            Response.Redirect("Loggin.aspx");
    }

    protected void B_Cambiar_Click(object sender, EventArgs e)
    {
        DAOUsuario user = new DAOUsuario();
        EUsuario eUser = new EUsuario();

        eUser.UserId = int.Parse(Session["user_id"].ToString());
        eUser.Clave = Tb_Contraseña.Text;

        user.actualziarContrasena(eUser);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Su Contraseña ha sido actualizada.');window.location=\"Loggin.aspx\"</script>");

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Loggin.aspx");
    }
}