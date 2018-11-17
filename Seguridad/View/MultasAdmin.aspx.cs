using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_MultasUser : System.Web.UI.Page
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
            try
            {
                DataTable multas = dAOUsuario1.obtener_multa_a(int.Parse(Session["user_id_control"].ToString()));
                Session["tabla_multas"] = multas;
                GV_multas.DataSource = multas;
                GV_multas.DataBind();
            }
            catch
            {

            }
            
        }

        Cache.Remove("MultasAdmin.aspx");
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

    protected void B_Seleccionar_Click(object sender, EventArgs e)
    {
        Session["user_id_control"] = null;
        DDL_usuarios.Items.Clear();
        DAOUsuario dAOUsuario1 = new DAOUsuario();
        DDL_usuarios.Items.Add("Seleccione");
        DataTable usuarios = dAOUsuario1.obtenerUsuariosTodos();
        for (int i = 0; i < usuarios.Rows.Count; i++)
        {
            if (usuarios.Rows[i]["rol_id"].ToString() != "2" && usuarios.Rows[i]["rol_id"].ToString() != "1")
            {
                DDL_usuarios.Items.Add(usuarios.Rows[i]["user_name"].ToString());

            }

        }
    }

    protected void DDL_usuarios_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DDL_usuarios.SelectedItem.ToString()!= "Seleccione")
        {
            String username = DDL_usuarios.SelectedValue;
            DAOUsuario dAO = new DAOUsuario();
            DataTable datos = dAO.obtenerUsuariosTodos();
            Session["user_id_control"] = null;
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                if (username == datos.Rows[i]["user_name"].ToString())
                {
                    Session["user_id_control"] = datos.Rows[i]["id"].ToString();
                    break;
                }
            }

            DataTable multas = dAO.obtener_multa_a(int.Parse(Session["user_id_control"].ToString()));
            Session["tabla_multas"] = multas;
            GV_multas.DataSource = multas;
            GV_multas.DataBind();
        }
        else
        {
            DataTable multas = new DataTable();
            
            GV_multas.DataSource = multas;
            GV_multas.DataBind();
        }
    }

          
    protected void GV_multas_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
       int pos = e.RowIndex;
        int id=0;
        DataTable multas = Session["tabla_multas"] as DataTable;
        for (int i=0;i<multas.Rows.Count;i++)
        {
            if (pos==i)
            {
                id=int.Parse(multas.Rows[i]["id"].ToString());
                break;
            }
        }
        DAOUsuario dAO = new DAOUsuario();
        dAO.update_multa(id);
    }
}