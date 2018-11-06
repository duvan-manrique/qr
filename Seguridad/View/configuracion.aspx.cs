using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_configuracion : System.Web.UI.Page
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

        Cache.Remove("configuracion.aspx");
    }

    protected void b_crear_fecha_hora_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        if (System.Convert.ToInt32(DDL_HInicio.SelectedValue) < System.Convert.ToInt32(DDL_HFinal.SelectedValue))
        {
            Fechas_horas fechas_horas = new Fechas_horas();
        fechas_horas.Fecha = DateTime.Parse(tb_fecha.Text);
        fechas_horas.Hora_inicio =int.Parse(DDL_HInicio.SelectedValue);
        fechas_horas.Hora_fin = int.Parse(DDL_HFinal.SelectedValue);

        DAOUsuario crear = new DAOUsuario();
        crear.Insert_fechas_horas(fechas_horas);
        Response.Redirect("configuracion.aspx");
        }
        else
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('la hora inicial debe ser menos al final ');</script>");
        }
    }
    
                   

               
}