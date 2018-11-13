﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_CrearUsuarioAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null)
        {
            Response.Redirect("Loggin.aspx");
        }
        else
        {
            
            ClientScriptManager cm = this.ClientScript;
            DAOUsuario dAOUsuario1 = new DAOUsuario();
            dAOUsuario1.vista(cm);
        }

        Cache.Remove("EditarUsuario.aspx");
    }

    protected void TB_TipoUser(object sender, EventArgs e)
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

    protected void B_CrearUsuario_Click(object sender, EventArgs e)
    {
        if (Session["validar_name"] == null)
        {
            User usuario = new User();
            usuario.Nombre = TB_Nombre.Text;
            usuario.User_name = TB_Username.Text;
            usuario.Codigo = long.Parse(TB_Codigo.Text);
            usuario.Clave = TB_Clave.Text;
            usuario.Correo = TB_Correo.Text;
            usuario.Rol_id = int.Parse(DropDownList1.SelectedValue);
            usuario.Fecha = DateTime.Now;

            DAOUsuario crear = new DAOUsuario();
            crear.Insert_User(usuario);
            ClientScriptManager cm = this.ClientScript;
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario Registrado exitosamente');</script>");
            limpiar();
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

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void TB_Nombre_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TB_Username_TextChanged(object sender, EventArgs e)
    {
        DAOUsuario dao = new DAOUsuario();
        DataTable users = dao.obtenerUsuariosTodos();
        Session["validar_name"] = null;
        LB_u_n.Visible = false;
        for (int i = 0; i < users.Rows.Count; i++)
        {
            if (TB_Username.Text == (users.Rows[i]["user_name"].ToString()))
            {
                Session["validar_name"] = 1;
                LB_u_n.Visible = true;
            }
        }

    }
}