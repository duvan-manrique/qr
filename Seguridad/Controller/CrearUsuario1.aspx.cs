using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_CrearUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null)
            Response.Redirect("Loggin.aspx");
    }

    protected void B_CrearUsuario_Click(object sender, EventArgs e)
    {
        User usuario = new User();
        usuario.Nombre = TB_Nombre.Text;
        usuario.User_name = TB_Username.Text;
        usuario.Codigo = long.Parse(TB_Codigo.Text);
        usuario.Clave = TB_Clave.Text;
        usuario.Correo = TB_Correo.Text;
        usuario.Rol_id = 3;
        usuario.Fecha = DateTime.Now;

        DAOUsuario crear = new DAOUsuario();
        crear.Insert_User(usuario);



    }
}