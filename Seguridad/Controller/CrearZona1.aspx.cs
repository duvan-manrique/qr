using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_CrearZona : System.Web.UI.Page
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

        Cache.Remove("CrearZona.aspx");
    }

    ////
    ///




    protected void B_ApartarCupo1_Click(object sender, EventArgs e)
    {
        if (Session["validar_zona"] == null)
        {
            Zonas zonas = new Zonas();
            zonas.Nombre = TB_NombreZona.Text;
            zonas.Tipo_vehiculo = int.Parse(DDL_TipodeVehiculo.SelectedValue);
            zonas.Numero_de_campos = int.Parse(TB_NumerodeCampos.Text);
            DAOUsuario crear = new DAOUsuario();
            crear.Insert_Zonas(zonas);
        }

    }

    protected void TB_NombreZona_TextChanged(object sender, EventArgs e)
    {
        DAOUsuario dao = new DAOUsuario();
        DataTable zonas = dao.obtenerzonasTodos();
        Session["validar_zona"] = null;
        LB_u_n.Visible = false;
        for (int i = 0; i < zonas.Rows.Count; i++)
        {
            if (TB_NombreZona.Text == (zonas.Rows[i]["nombre"].ToString()))
            {
                Session["validar_zona"] = 1;
                LB_u_n.Visible = true;
            }
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