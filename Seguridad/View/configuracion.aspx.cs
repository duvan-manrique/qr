using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_configuracion : System.Web.UI.Page
{
    string k = "si";
    string q = "si";
    string b = "si";
    string o = "si";
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
        if (q == "si")
        {
            if (b == "si")
            {
                ClientScriptManager cm = this.ClientScript;
                if (TimeSpan.Parse(TB_hora_inicio.Text) < TimeSpan.Parse(Tb_hora_Fin.Text))
                {
                    Fechas_horas fechas_horas = new Fechas_horas();
                    fechas_horas.Fecha = DateTime.Parse(tb_fecha.Text);
                    fechas_horas.Hora_inicio = TimeSpan.Parse(TB_hora_inicio.Text);
                    fechas_horas.Hora_fin = TimeSpan.Parse(Tb_hora_Fin.Text);


                    DAOUsuario crear = new DAOUsuario();
                    crear.Insert_fechas_horas(fechas_horas);
                    Response.Redirect("configuracion.aspx");
                    ClientScriptManager df = this.ClientScript;
                    df.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('fecha creada');</script>");
                    limpiar();

                }
                else
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('la hora inicial debe ser menos al final ');</script>");
                }
            }
        }

    }

    private void limpiar()
    {
        TB_Nombre.Text = "";
        TB_Username.Text = "";
        TB_Codigo.Text = "";
        TB_Clave.Text = "";
        TB_Correo.Text = "";
        DropDownList1.SelectedIndex = 0;

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
    
    protected void b_bloquear_fecha_hora_Click(object sender, EventArgs e)
    {
        if (k == "si")
        {
            if (o == "si")
            {
                ClientScriptManager cm = this.ClientScript;

                fechas_horas_bloqueadas fechas_horas_bloquedas = new fechas_horas_bloqueadas();
                fechas_horas_bloquedas.Fecha = DateTime.Parse(tb_fecha0.Text);


                DAOUsuario crear = new DAOUsuario();
                crear.Insert_fechas_horas_bloqueadas(fechas_horas_bloquedas);
                ClientScriptManager ol = this.ClientScript;
                ol.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('fecha bloqueada');</script>");
                limpiar();

                Response.Redirect("configuracion.aspx");
            }

        }
    }

    protected void tb_fecha0_TextChanged(object sender, EventArgs e)
    {
            DAOUsuario dao = new DAOUsuario();
            DataTable users = dao.obtenerfechas_horas_bloqueadasTodos();

            Session["validar_fecha"] = k;

            LB_u_n.Visible = false;
            for (int i = 0; i < users.Rows.Count; i++)
            {
                string g = (users.Rows[i]["fecha"].ToString());
                DateTime parsedDate = DateTime.Parse(g);
                string h = parsedDate.ToString("yyyy-MM-dd");

                if (tb_fecha0.Text == h)
                {
                    k = "no";
                LB_u_n.Visible = true;
                }

            }

            DAOUsuario daoo = new DAOUsuario();
            DataTable fech = daoo.obtenerfechas_horasTodos();

            Session["validar_fecha_ho"] = o;

        LB_uk.Visible = false;
        for (int i = 0; i < fech.Rows.Count; i++)
        {
            string w = (fech.Rows[i]["fecha"].ToString());
            DateTime parsedDate = DateTime.Parse(w);
            string t = parsedDate.ToString("yyyy-MM-dd");

            if (tb_fecha0.Text == t)
            {
                o = "no";
                LB_uk.Visible = true;
            }

        }
      
    }

    protected void tb_fecha_TextChanged(object sender, EventArgs e)
    {
        DAOUsuario dao = new DAOUsuario();
        DataTable users = dao.obtenerfechas_horasTodos();

        Session["validar_fecha_hora"] = q;
     
        LB_u_nn0.Visible = false;
        for (int i = 0; i < users.Rows.Count; i++)
        {
            string w = (users.Rows[i]["fecha"].ToString());
            DateTime parsedDate = DateTime.Parse(w);
            string t = parsedDate.ToString("yyyy-MM-dd");

            if (tb_fecha.Text == t)
            {
                q = "no";
                LB_u_nn0.Visible = true;
            }

        }

        DAOUsuario blo = new DAOUsuario();
        DataTable fechab = blo.obtenerfechas_horas_bloqueadasTodos();
        Session["validar_fecha_hora_bloqueada"] = b;
        LB_u_nn1.Visible = false;
        for (int i = 0; i < fechab.Rows.Count; i++)
        {
            string j = (fechab.Rows[i]["fecha"].ToString());
            DateTime parsedDate = DateTime.Parse(j);
            string c = parsedDate.ToString("yyyy-MM-dd");

            if (tb_fecha.Text == c)
            {
                b = "no";
                LB_u_nn1.Visible = true;
            }

        }
    }

    protected void TB_hora_inicio_TextChanged(object sender, EventArgs e)
    {
    }
}