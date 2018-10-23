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

    }

    protected void b_crear_fecha_hora_Click(object sender, EventArgs e)
    {
        Fechas_horas fechas_horas = new Fechas_horas();
        fechas_horas.Fecha = DateTime.Parse(tb_fecha.Text);
        fechas_horas.Hora_inicio =int.Parse(DDL_HInicio.SelectedValue);
        fechas_horas.Hora_fin = int.Parse(DDL_HFinal.SelectedValue);

        DAOUsuario crear = new DAOUsuario();
        crear.Insert_fechas_horas(fechas_horas);
        Response.Redirect("configuracion.aspx");
    }
}