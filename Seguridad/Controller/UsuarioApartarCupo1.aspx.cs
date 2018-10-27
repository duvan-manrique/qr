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
using System.Drawing.Imaging;
using Image = System.Web.UI.WebControls.Image;

public partial class View_UsuarioApartarCupo : System.Web.UI.Page
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
        TB_Calendariocupo_TextChanged();
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

                    String QR = JsonConvert.SerializeObject(reserva);
                    txtCode.Text = QR;
                    btnGenerate_Click();
                    DAOUsuario dAOUsuario = new DAOUsuario();
                    dAOUsuario.Insert_Reserva(reserva);

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


        }
    }

    protected void DDL_Tipo_SelectedIndexChanged(object sender, EventArgs e)
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
            DDL_Veicu.Enabled = (true);
            DDL_Veicu.Items.Clear();
            DDL_Veicu.Items.Add("seleccione");
            switch (int.Parse(DDL_Tipo.SelectedValue))
            {
                case 1:

                    DataTable carga = dAO.obtenerVehiculosTodos(1, int.Parse(Session["user_id"].ToString()));
                    Session["vehiculo"] = carga;
                    for (int i = 0; i < carga.Rows.Count; i++)
                    {
                        DDL_Veicu.Items.Add(carga.Rows[i][3].ToString());
                    }

                    break;

                case 2:
                    DataTable carga1 = dAO.obtenerVehiculosTodos(2, int.Parse(Session["user_id"].ToString()));
                    Session["vehiculo"] = carga1;
                    for (int i = 0; i < carga1.Rows.Count; i++)
                    {
                        DDL_Veicu.Items.Add(carga1.Rows[i][3].ToString());
                    }
                    break;

                case 3:
                    DataTable carga2 = dAO.obtenerVehiculosTodos(1, int.Parse(Session["user_id"].ToString()));
                    Session["vehiculo"] = carga2;
                    for (int i = 0; i < carga2.Rows.Count; i++)
                    {
                        DDL_Veicu.Items.Add(carga2.Rows[i][3].ToString());
                    }
                    break;

                default:
                    break;

            }
        }
    }

    protected void DDL_Veicu_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable vehiculo = (DataTable)Session["vehiculo"];
        Session["vehiculo_id"] = null;
        for (int i = 0; i < (vehiculo.Rows.Count); i++)
        {
            if (vehiculo.Rows[i][3].ToString().Equals(DDL_Veicu.SelectedValue))
            {
                Session["vehiculo_id"] = vehiculo.Rows[i][0].ToString();
            }
        }
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
                /// uso el del  token por q hay ya tienen el correo



                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] byteImage = ms.ToArray();
                imgQRcode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);

                File.WriteAllBytes(Server.MapPath("\\Imagenes\\prueba.jpg"), byteImage);
                DAOUsuario dAO = new DAOUsuario();
                DataTable tabla = dAO.obtenerUsuarios(int.Parse(Session["user_id"].ToString()));
                Correo correo = new Correo();

                correo.enviarCorreoQr(tabla.Rows[0]["correo"].ToString());


            }

            PHQRCode.Controls.Add(imgQRcode);



        }
    }


    protected void TB_Calendariocupo_TextChanged()
    {

        DateTime manana = DateTime.Today.AddDays(1);
        string mananatDate = manana.ToString("yyyy-MM-dd");
        TB_Calendariocupo.Text = mananatDate;

    }





}