using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_AdminApartarCupo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

    protected void B_agregar_Click(object sender, EventArgs e)
    {

    }

    protected void B_Reservar_Click(object sender, EventArgs e)
    {

    }

    protected void DDL_Vehiculo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DDL_HInicio_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DDL_HFinal_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DDL_Tipo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DDL_Veicu_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void TB_Calendariocupo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TB_codigoVe_TextChanged(object sender, EventArgs e)
    {

    }
}