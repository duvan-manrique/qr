﻿using System;
using System.Collections.Generic;
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
        }

        Cache.Remove("CrearZona.aspx");
    }

    ////
    ///




    protected void B_ApartarCupo1_Click(object sender, EventArgs e)
    {
        Zonas zonas = new Zonas();
        zonas.Nombre = TB_NombreZona.Text;
        zonas.Tipo_vehiculo = int.Parse(DDL_TipodeVehiculo.SelectedValue);
        zonas.Numero_de_campos = int.Parse(TB_NumerodeCampos.Text);
        DAOUsuario crear = new DAOUsuario();
        crear.Insert_Zonas(zonas);


    }
}