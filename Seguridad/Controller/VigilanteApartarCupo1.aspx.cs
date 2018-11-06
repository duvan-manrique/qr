using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;
using MessagingToolkit.QRCode.Codec;
using System.IO;
using System.Drawing.Imaging;
using QRCoder;

public partial class View_VigilanteApartarCupo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null)
            Response.Redirect("Loggin.aspx");
        else
        {
            L_Nombre.Text = Session["nombre"].ToString();
            ClientScriptManager cm = this.ClientScript;
            DAOUsuario dAOUsuario1 = new DAOUsuario();
            dAOUsuario1.vista(cm);
        }
        TB_Calendariocupo_TextChanged();
        Cache.Remove("VigilanteApartarCupo.aspx");
    }



    protected void B_Reservar_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;

        if ((System.Convert.ToInt32(DDL_Tipo.SelectedValue) == 0) || ((DDL_Veicu.SelectedValue) == "seleccione"))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Debe seleccionar un vehiculo');</script>");

        }
        else
        {
            Reserva reserva = new Reserva();

            reserva.Parq_id = Campos();
            if (reserva.Parq_id != -1)
            {
                reserva.F_inicio = DateTime.Parse(TB_Calendariocupo.Text);
                reserva.F_fin = DateTime.Parse(TB_Calendariocupo.Text);
                if (System.Convert.ToInt32(DDL_HInicio.SelectedValue) < System.Convert.ToInt32(DDL_HFinal.SelectedValue))
                {

                    reserva.F_inicio = reserva.F_inicio.AddHours(double.Parse(DDL_HInicio.SelectedValue));
                    reserva.F_fin = reserva.F_fin.AddHours(double.Parse(DDL_HFinal.SelectedValue));
                    reserva.Vehiculo_id = int.Parse(Session["vehiculo_id"].ToString());
                    reserva.Descripcion = TB_Descripcion.Text;


                    DAOUsuario dAOUsuario = new DAOUsuario();
                    dAOUsuario.Insert_Reserva(reserva);



                    txtCode.Text = ((TB_Calendariocupo.Text) + " " + (TB_Calendariocupo.Text) + " " + (DDL_HInicio.SelectedValue) + " " + (DDL_HFinal.SelectedValue) + " " + Session["vehiculo_id"].ToString() + " " + TB_Descripcion.Text);



                }
                else
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('la hora inicial debe ser menos al final ');</script>");
                }
            }
            else
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('lamentablemente no hay cupo para este vehiculo');</script>");
            }
            btnGenerate_Click();
        }



    }


    protected int Campos()
    {
        DAOUsuario dAOUsuario = new DAOUsuario();
        DateTime F_inicio = DateTime.Parse(TB_Calendariocupo.Text);
        DateTime F_fin = DateTime.Parse(TB_Calendariocupo.Text);
        F_inicio = F_inicio.AddHours(double.Parse(DDL_HInicio.SelectedValue));
        F_fin = F_fin.AddHours(double.Parse(DDL_HFinal.SelectedValue));

        DataTable x = dAOUsuario.Traer_cupo(int.Parse(DDL_Tipo.SelectedValue), F_inicio, F_fin);
        return int.Parse(x.Rows[0][0].ToString());
    }

    protected void B_agregar_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        if ((int.Parse(DDL_Vehiculo.SelectedValue)) == 0)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Debe seleccionar un tipo de vehiculo');</script>");
        }
        else
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = TB_codigoVe.Text;
            vehiculo.Tipo = int.Parse(DDL_Vehiculo.SelectedValue);
            vehiculo.Usuario_id = int.Parse(Session["user_id"].ToString());
            vehiculo.Nombre = TB_marca.Text;
            DAOUsuario dAO = new DAOUsuario();
            dAO.Insert_Vehiculo(vehiculo);
            Session["tipo"] = vehiculo.Tipo;
            DDL_Tipo.SelectedValue =Session["tipo"].ToString();
            DDL_Veicu_SelectedIndexChanged();

        }
    }

    protected void DDL_Tipo_SelectedIndexChanged()
    {
        ClientScriptManager cm = this.ClientScript;

        if ((int.Parse(DDL_Tipo.SelectedValue)) == 0)
        {
            DDL_Veicu.Items.Clear();
            Session["vehiculo"] = null;
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Debe seleccionar un tipo de vehiculo');</script>");
        }
        else
        {
            DAOUsuario dAO = new DAOUsuario();
            
            DDL_Veicu.Items.Clear();
          
            switch (int.Parse(DDL_Tipo.SelectedValue))
            {
                case 1:

                    DataTable carga = dAO.obtenerVehiculosTodos(1, int.Parse(Session["user_id"].ToString()));
                    Session["vehiculo"] = carga;
                    
                        DDL_Veicu.Items.Add(carga.Rows[carga.Rows.Count-1][3].ToString());
                    

                    break;

                case 2:
                    DataTable carga1 = dAO.obtenerVehiculosTodos(2, int.Parse(Session["user_id"].ToString()));
                    Session["vehiculo"] = carga1;
                    
                        DDL_Veicu.Items.Add(carga1.Rows[carga1.Rows.Count - 1][3].ToString());
                    
                    break;

                case 3:
                    DataTable carga2 = dAO.obtenerVehiculosTodos(3, int.Parse(Session["user_id"].ToString()));
                    Session["vehiculo"] = carga2;
                   
                        DDL_Veicu.Items.Add(carga2.Rows[carga2.Rows.Count - 1][3].ToString());
                    
                    break;

                default:
                    break;

            }
        }
    }

    protected void DDL_Veicu_SelectedIndexChanged()
    {
        DDL_Tipo_SelectedIndexChanged();
        DataTable vehiculo = (DataTable)Session["vehiculo"];
        Session["vehiculo_id"] = null;
         Session["vehiculo_id"] = vehiculo.Rows[vehiculo.Rows.Count-1][0].ToString();
        
    }

    protected void btnGenerate_Click()
    {
        string Code = txtCode.Text;
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode(Code, QRCodeGenerator.ECCLevel.Q);

        System.Web.UI.WebControls.Image imgQRcode = new System.Web.UI.WebControls.Image();
        imgQRcode.Height = 150;
        imgQRcode.Width = 150;

        using (Bitmap bitmap = qrCode.GetGraphic(20))
        {

            using (MemoryStream ms = new MemoryStream())
            {

                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] byteImage = ms.ToArray();
                imgQRcode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);

            }

            PHQRCode.Controls.Add(imgQRcode);
           

        }


    }


    protected void TB_Calendariocupo_TextChanged()
    {

        DateTime manana = DateTime.Today;
        string mananatDate = manana.ToString("yyyy-MM-dd");
        TB_Calendariocupo.Text = mananatDate;

    }





    
}