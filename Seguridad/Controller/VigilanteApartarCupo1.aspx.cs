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
using Newtonsoft.Json;

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
        TB_hora_inicio_TextChanged();
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
            if (Session["val_date"] == null && (TB_Calendariocupo.Text != ""))
            {
                Reserva reserva = new Reserva();

                reserva.Parq_id = Campos();
                if (reserva.Parq_id != -1)
                {
                    reserva.F_inicio = DateTime.Parse(TB_Calendariocupo.Text);
                    reserva.F_fin = DateTime.Parse(TB_Calendariocupo.Text);
                    if (TimeSpan.Parse(TB_hora_inicio.Text) < TimeSpan.Parse(TB_hora_fin.Text))
                    {
                        
                        
                            reserva.F_inicio = reserva.F_inicio.AddHours(TimeSpan.Parse(TB_hora_inicio.Text).Hours);
                            reserva.F_inicio.AddMinutes((TimeSpan.Parse(TB_hora_inicio.Text)).Minutes);
                            reserva.F_inicio.AddMinutes(1);
                            reserva.F_fin = reserva.F_fin.AddHours(TimeSpan.Parse(TB_hora_fin.Text).Hours);
                            reserva.F_fin.AddMinutes((TimeSpan.Parse(TB_hora_fin.Text)).Minutes);
                            reserva.Vehiculo_id = int.Parse(Session["vehiculo_id"].ToString());
                            reserva.Descripcion = TB_Descripcion.Text;

                            DAOUsuario dAOUsuario = new DAOUsuario();


                            dAOUsuario.Insert_Reserva(reserva);
                            String QR = dAOUsuario.obtenerqr().Rows[0]["contenido"].ToString();
                            Reserva reserva1 = JsonConvert.DeserializeObject<Reserva>(QR);
                            txtCode.Text = reserva1.Id.ToString();
                            btnGenerate_Click();
                            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('la reservacion ha sido creada imprima el QR');</script>");
                        limpiar();



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
            }
            else
            {

                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('verifique la fecha');</script>");
            }

        }



    }

    private void limpiar()
    {
        TB_codigoVe.Text = "";
        TB_marca.Text = "";
        DDL_Vehiculo.SelectedIndex = 0;

        TB_Calendariocupo.Text = "";
        TB_hora_inicio.Text = "";
        TB_hora_fin.Text = "";
        DDL_Tipo.SelectedIndex = 0;
        DDL_Veicu.SelectedIndex = 0;
        TB_Descripcion.Text = "";
    }


    protected int Campos()
    {
       
        DAOUsuario dAOUsuario = new DAOUsuario();
        DateTime F_inicio = DateTime.Parse(TB_Calendariocupo.Text);
        DateTime F_fin = DateTime.Parse(TB_Calendariocupo.Text);
        F_inicio = F_inicio.AddHours(TimeSpan.Parse(TB_hora_inicio.Text).Hours);
        F_inicio = F_inicio.AddMinutes((TimeSpan.Parse(TB_hora_inicio.Text)).Minutes);
        F_fin = F_fin.AddHours(TimeSpan.Parse(TB_hora_fin.Text).Hours);
        F_fin = F_fin.AddMinutes((TimeSpan.Parse(TB_hora_fin.Text)).Minutes);

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

            DAOUsuario dAO = new DAOUsuario();
            DataTable carga = dAO.obtenerVehiculosTodos(int.Parse(DDL_Vehiculo.SelectedValue), int.Parse(Session["user_id"].ToString()));
            int val = 0;
            for (int i = 0; i < carga.Rows.Count; i++)
            {
                if (TB_codigoVe.Text == carga.Rows[i][3].ToString())
                {
                    val++;
                }
            }

            if (val==0) { 
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = TB_codigoVe.Text;
            vehiculo.Tipo = int.Parse(DDL_Vehiculo.SelectedValue);
            vehiculo.Usuario_id = int.Parse(Session["user_id"].ToString());
            vehiculo.Nombre = TB_marca.Text;
            dAO.Insert_Vehiculo(vehiculo);
            Session["tipo"] = vehiculo.Tipo;
            DDL_Tipo.SelectedValue =Session["tipo"].ToString();
            DDL_Veicu_SelectedIndexChanged();
              cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('vehiculo registrado');</script>");
              limpiar();
            }
            else
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('ya registrado anteriormente  COMUNIQUELE QUE DEBE REGISTRARSE EN PLATAFORMA');</script>");
            }

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





    protected void TB_Calendariocupo_TextChanged1(object sender, EventArgs e)
    {
        DateTime manana = DateTime.Today;
        string mananatDate = manana.ToString("yyyy-MM-dd");
        TB_Calendariocupo.Text = mananatDate;
    }

    protected void TB_hora_inicio_TextChanged()
    {
        DateTime hoy = DateTime.Now;
        TimeSpan hora = new TimeSpan(hoy.Hour,hoy.Minute,0);
        TB_hora_inicio.Text = hora.ToString();


    }



    protected void TB_hora_inicio_TextChanged(object sender, EventArgs e)
    {
        TB_hora_inicio_TextChanged();
    }
}