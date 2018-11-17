using Newtonsoft.Json;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_AdminApartarCupo : System.Web.UI.Page
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

        Cache.Remove("UsuarioApartarCupo.aspx");
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
                if (validar() == false)
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('sus datos no coinciden con los intervalos aseptados');</script>");
                }
                else
                {
                    reserva.Parq_id = Campos();
                    if (reserva.Parq_id != -1)
                    {
                        reserva.F_inicio = DateTime.Parse(TB_Calendariocupo.Text);
                        reserva.F_fin = DateTime.Parse(TB_Calendariocupo.Text);
                        if (TimeSpan.Parse(TB_hora_inicio.Text) < TimeSpan.Parse(TB_hora_fin.Text))
                        {
                            DAOUsuario dAO1 = new DAOUsuario();
                            DataTable tabla1 = dAO1.obtenereservacionyo(int.Parse(Session["user_id_control"].ToString()));
                            int prue = 0;
                            DateTime F_inicio = reserva.F_inicio.AddHours(TimeSpan.Parse(TB_hora_inicio.Text).Hours);
                            F_inicio.AddMinutes((TimeSpan.Parse(TB_hora_inicio.Text)).Minutes);
                            F_inicio.AddMinutes(1);
                            DateTime F_fin = reserva.F_fin.AddHours(TimeSpan.Parse(TB_hora_fin.Text).Hours);
                            F_fin.AddMinutes((TimeSpan.Parse(TB_hora_fin.Text)).Minutes);
                            for (int i = 0; i < tabla1.Rows.Count; i++)
                            {
                                if (F_inicio == (DateTime.Parse(tabla1.Rows[i]["fecha_inicio"].ToString())) && F_fin == (DateTime.Parse(tabla1.Rows[i]["fecha_fin"].ToString())))
                                {
                                    prue++;
                                }
                                if (F_inicio >= (DateTime.Parse(tabla1.Rows[i]["fecha_inicio"].ToString())) && F_fin == (DateTime.Parse(tabla1.Rows[i]["fecha_fin"].ToString())))
                                {
                                    prue++;
                                }
                                if (F_inicio <= (DateTime.Parse(tabla1.Rows[i]["fecha_inicio"].ToString())) && F_fin == (DateTime.Parse(tabla1.Rows[i]["fecha_fin"].ToString())))
                                {
                                    prue++;
                                }
                                if (F_inicio == (DateTime.Parse(tabla1.Rows[i]["fecha_inicio"].ToString())) && F_fin >= (DateTime.Parse(tabla1.Rows[i]["fecha_fin"].ToString())))
                                {
                                    prue++;
                                }
                                if (F_inicio == (DateTime.Parse(tabla1.Rows[i]["fecha_inicio"].ToString())) && F_fin <= (DateTime.Parse(tabla1.Rows[i]["fecha_fin"].ToString())))
                                {
                                    prue++;
                                }
                                if (F_inicio <= (DateTime.Parse(tabla1.Rows[i]["fecha_inicio"].ToString())) && F_fin <= (DateTime.Parse(tabla1.Rows[i]["fecha_fin"].ToString())) && F_fin >= (DateTime.Parse(tabla1.Rows[i]["fecha_inicio"].ToString())) && F_inicio <= (DateTime.Parse(tabla1.Rows[i]["fecha_fin"].ToString())))
                                {
                                    prue++;
                                }
                                if (F_inicio >= (DateTime.Parse(tabla1.Rows[i]["fecha_inicio"].ToString())) && F_inicio <= (DateTime.Parse(tabla1.Rows[i]["fecha_fin"].ToString())))
                                {
                                    prue++;
                                }
                                if (F_inicio <= (DateTime.Parse(tabla1.Rows[i]["fecha_inicio"].ToString())) && F_fin <= (DateTime.Parse(tabla1.Rows[i]["fecha_fin"].ToString())) && F_fin >= (DateTime.Parse(tabla1.Rows[i]["fecha_inicio"].ToString())))
                                {
                                    prue++;
                                }

                                if (F_inicio <= (DateTime.Parse(tabla1.Rows[i]["fecha_inicio"].ToString())) && F_fin >= (DateTime.Parse(tabla1.Rows[i]["fecha_fin"].ToString())))
                                {
                                    prue++;
                                }




                            }
                            if (prue == 0)
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
                                string mensaje = "su QR de reservacion del dia: " + reserva.F_inicio + "asta: " + reserva.F_fin + ";  para mas informacion puede revisar desde su plataforma ";

                                btnGenerate_Click(mensaje);
                                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Su reserva ha sido hecha revise su correo');</script>");
                                limpar();

                            }
                            else
                            {
                                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Su reserva esta cruzada con una ya creada pero puede ver en estos horarios');</script>");

                                DAOUsuario dAO = new DAOUsuario();

                                TimeSpan hora_inicial = TimeSpan.Parse(TB_hora_inicio.Text);
                                TimeSpan hora_final = TimeSpan.Parse(TB_hora_fin.Text);
                                TimeSpan diferencia = hora_final.Subtract(hora_inicial);
                                string segundos = diferencia.TotalSeconds.ToString();

                                DateTime fecha_aranque = DateTime.Parse(TB_Calendariocupo.Text);
                                fecha_aranque = fecha_aranque.AddHours(hora_inicial.Hours);
                                fecha_aranque = fecha_aranque.AddMinutes(hora_inicial.Minutes);
                                DateTime fecha_seriesi = DateTime.Parse(TB_Calendariocupo.Text);// desde que hora
                                fecha_seriesi = fecha_seriesi.AddHours(1);
                                DateTime fecha_seriesf = DateTime.Parse(TB_Calendariocupo.Text);//asta que hora
                                fecha_seriesf = fecha_seriesf.AddDays(1);
                                //fecha_series.AddHours();//agregar desde que hora de tabla de configuracion
                                //fecha_series.AddMinutes();
                                DataTable series = obtenerseries(segundos, fecha_aranque, fecha_seriesi, fecha_seriesf);
                                GV_series.DataSource = series;
                                GV_series.DataBind();
                            }


                        }
                        else
                        {
                            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('la hora inicial debe ser menos al final ');</script>");
                        }
                    }
                    else
                    {
                        //series

                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('lamentablemente no hay cupo para este vehiculo pero puede ver en estos horarios');</script>");
                        DAOUsuario dAO = new DAOUsuario();

                        TimeSpan hora_inicial = TimeSpan.Parse(TB_hora_inicio.Text);
                        TimeSpan hora_final = TimeSpan.Parse(TB_hora_fin.Text);
                        TimeSpan diferencia = hora_final.Subtract(hora_inicial);
                        string segundos = diferencia.TotalSeconds.ToString();

                        DateTime fecha_aranque = DateTime.Parse(TB_Calendariocupo.Text);
                        fecha_aranque = fecha_aranque.AddHours(hora_inicial.Hours);
                        fecha_aranque = fecha_aranque.AddMinutes(hora_inicial.Minutes);
                        DateTime fecha_seriesi = DateTime.Parse(TB_Calendariocupo.Text);// desde que hora
                        fecha_seriesi = fecha_seriesi.AddHours(1);
                        DateTime fecha_seriesf = DateTime.Parse(TB_Calendariocupo.Text);//asta que hora
                        fecha_seriesf = fecha_seriesf.AddDays(1);
                        //fecha_series.AddHours();//agregar desde que hora de tabla de configuracion
                        //fecha_series.AddMinutes();
                        DataTable series = obtenerseries(segundos, fecha_aranque, fecha_seriesi, fecha_seriesf);
                        GV_series.DataSource = series;
                        GV_series.DataBind();
                    }
                }
            }
            else
            {

                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('verifique la fecha');</script>");
            }

        }



    }

    private bool validar()
    {
        string mensaje = "";
        ClientScriptManager cm = this.ClientScript;
        if ((TimeSpan.Parse(TB_hora_inicio.Text) < TimeSpan.Parse(TB_hora_fin.Text)) && 15 <= (TimeSpan.Parse(TB_hora_fin.Text).Subtract(TimeSpan.Parse(TB_hora_inicio.Text))).TotalMinutes)
        { }
        else
        {
            return false;
        }
        DAOUsuario dAOUsuario = new DAOUsuario();

        DateTime F_inicio = DateTime.Parse(TB_Calendariocupo.Text);
        TimeSpan hi = TimeSpan.Parse(TB_hora_inicio.Text);
        TimeSpan hf = TimeSpan.Parse(TB_hora_fin.Text);

        DataTable f_block = dAOUsuario.obtenerfechas_horas_bloqueadasTodos();
        DataTable f_horario = dAOUsuario.obtenerfechas_horasTodos();
        int val = 0;
        for (int i = 0; i < f_block.Rows.Count; i++)
        {
            if (DateTime.Parse(f_block.Rows[i]["fecha"].ToString()) == F_inicio)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('esta fecha no esta disponible');</script>");
                return false;

            }
        }
        int esta = 0;
        for (int i = 0; i < f_horario.Rows.Count; i++)
        {
            if (DateTime.Parse(f_horario.Rows[i]["fecha"].ToString()) == F_inicio)
            {
                TimeSpan h1a = (TimeSpan.Parse(((DateTime.Parse(f_horario.Rows[i]["hora_inicio"].ToString())).TimeOfDay).ToString()));
                TimeSpan hfa = (TimeSpan.Parse(((DateTime.Parse(f_horario.Rows[i]["hora_fin"].ToString())).TimeOfDay).ToString()));

                if (hi >= (TimeSpan.Parse(((DateTime.Parse(f_horario.Rows[i]["hora_inicio"].ToString())).TimeOfDay).ToString())) && hf <= (TimeSpan.Parse((((DateTime.Parse(f_horario.Rows[i]["hora_fin"].ToString())).TimeOfDay).ToString()))))
                {
                    TimeSpan dif = hf.Subtract(hi);
                    if (dif.TotalSeconds <= (double.Parse(f_horario.Rows[i]["limite_diario"].ToString())))
                    {
                        //valida horas en la semana
                        DataTable tabla1 = dAOUsuario.obtenereservacionyo(int.Parse(Session["user_id_control"].ToString()));
                        TimeSpan semana = new TimeSpan();
                        for (int j = 0; j < tabla1.Rows.Count; j++)
                        {
                            if (DateTime.Parse(tabla1.Rows[j]["fecha_inicio"].ToString()).Date == F_inicio.Date)//aaaaaaaaaaaaaaaaaaaaaaa
                            {
                                semana = semana.Add((TimeSpan.Parse((((DateTime.Parse(tabla1.Rows[j]["fecha_fin"].ToString())).TimeOfDay).ToString()))).Subtract((TimeSpan.Parse(((DateTime.Parse(tabla1.Rows[j]["fecha_inicio"].ToString())).TimeOfDay).ToString()))));
                            }

                        }
                        if (semana.TotalSeconds < (double.Parse(f_horario.Rows[i]["limite_diario"].ToString())))
                        {
                            if (dif.TotalSeconds <= ((double.Parse(f_horario.Rows[i]["limite_diario"].ToString())) - (semana.TotalSeconds)))
                            {
                                return true;
                            }
                            else
                            {
                                mensaje = "limite de horas solo le queda: " + dif.TotalSeconds + " segundos para reservar";
                                val++;
                            }
                        }
                        else
                        {
                            mensaje = "limite de horas alcanzado";
                            val++;
                        }
                    }
                    else
                    {
                        mensaje = "el rango de hora supera el limite diario de: " + double.Parse(f_horario.Rows[i]["limite_diario"].ToString()) + "segundos";
                        val++;
                    }
                }
                else
                {
                    mensaje = "el rango de hora selecionado esta fuera del horario de atencion que es de: " + (TimeSpan.Parse(((DateTime.Parse(f_horario.Rows[i]["hora_inicio"].ToString())).TimeOfDay).ToString())) + "asta: " + (TimeSpan.Parse((((DateTime.Parse(f_horario.Rows[i]["hora_fin"].ToString())).TimeOfDay).ToString())));

                    val++;
                }
            }
            else
            {
                esta++;
            }
        }
        if (esta == f_horario.Rows.Count)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('este fecha no tiene horario de servicio');</script>");
            return false;
        }
        else
        {
            if (val > 0)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('" + mensaje + "');</script>");
                return false;
            }
            else
            {
                return true;
            }
        }




    }


    private DataTable obtenerseries(string segundos, DateTime fecha_aranque, DateTime fecha_seriesi, DateTime fecha_seriesf)
    {

        DAOUsuario dAO = new DAOUsuario();
        DataTable parqueaderos = dAO.obtenerParqueaderoTipo(int.Parse(DDL_Tipo.SelectedValue));
        int id = 0;
        DataTable series = new DataTable();
        for (int i = 0; i < parqueaderos.Rows.Count; i++)
        {
            id = int.Parse(parqueaderos.Rows[i]["id"].ToString());
            series = dAO.Traer_series(segundos, id, fecha_aranque, fecha_seriesi, fecha_seriesf, int.Parse(DDL_Tipo.SelectedValue));
            if (series.Rows.Count != 0)
            {
                break;
            }
        }

        return series;
    }

    private void limpar()
    {

    }

    protected int Campos()
    {



        DAOUsuario dAOUsuario = new DAOUsuario();
        DateTime F_inicio = DateTime.Parse(TB_Calendariocupo.Text);
        DateTime F_fin = DateTime.Parse(TB_Calendariocupo.Text);
        F_inicio = F_inicio.AddHours(TimeSpan.Parse(TB_hora_inicio.Text).Hours);
        F_inicio.AddMinutes((TimeSpan.Parse(TB_hora_inicio.Text)).Minutes);
        F_fin = F_fin.AddHours(TimeSpan.Parse(TB_hora_fin.Text).Hours);
        F_fin.AddMinutes((TimeSpan.Parse(TB_hora_fin.Text)).Minutes);
        DataTable x = dAOUsuario.Traer_cupo(int.Parse(DDL_Tipo.SelectedValue), F_inicio, F_fin);
        return int.Parse(x.Rows[0][0].ToString());
    }

    protected void B_agregar_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        if (Session["user_id_control"] == null)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Debe seleccionar un usuario control');</script>");
        }
        else {
           
            if (int.Parse(DDL_Vehiculo.SelectedValue) == 0)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Debe seleccionar un tipo de vehiculo');</script>");
            }
            else
            {
                DAOUsuario dAO = new DAOUsuario();
                DataTable carga = dAO.obtenerVehiculosTodos(int.Parse(DDL_Vehiculo.SelectedValue), int.Parse(Session["user_id_control"].ToString()));
                int val = 0;
                for (int i = 0; i < carga.Rows.Count; i++)
                {
                    if (TB_codigoVe.Text == carga.Rows[i][3].ToString())
                    {
                        val++;
                    }
                }

                if (val == 0)
                {
                    Vehiculo vehiculo = new Vehiculo();
                    vehiculo.Placa = TB_codigoVe.Text;
                    vehiculo.Tipo = int.Parse(DDL_Vehiculo.SelectedValue);
                    vehiculo.Usuario_id = int.Parse(Session["user_id_control"].ToString());
                    vehiculo.Nombre = TB_marca.Text;
                    dAO.Insert_Vehiculo(vehiculo);
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('vehiculo registrado');</script>");

                }
                else
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('ya registrado anteriormente');</script>");
                }




            }
        }
    }  

    protected void DDL_Tipo_SelectedIndexChanged(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        if (Session["user_id_control"] == null)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Debe seleccionar  usuario control');</script>");
        }
        else {
            if ((int.Parse(DDL_Tipo.SelectedValue)) == 0)
            {
                DDL_Veicu.Items.Clear();
                Session["vehiculo"] = null;
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Debe seleccionar  un tipo de vehiculo');</script>");
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

                        DataTable carga = dAO.obtenerVehiculosTodos(1, int.Parse(Session["user_id_control"].ToString()));
                        Session["vehiculo"] = carga;
                        for (int i = 0; i < carga.Rows.Count; i++)
                        {
                            DDL_Veicu.Items.Add(carga.Rows[i][3].ToString());
                        }

                        break;

                    case 2:
                        DataTable carga1 = dAO.obtenerVehiculosTodos(2, int.Parse(Session["user_id_control"].ToString()));
                        Session["vehiculo"] = carga1;
                        for (int i = 0; i < carga1.Rows.Count; i++)
                        {
                            DDL_Veicu.Items.Add(carga1.Rows[i][3].ToString());
                        }
                        break;

                    case 3:
                        DataTable carga2 = dAO.obtenerVehiculosTodos(3, int.Parse(Session["user_id_control"].ToString()));
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

    protected void btnGenerate_Click(string mensaje)
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
                Random num = new Random();
                int a = num.Next(1, 9999);

                String ruta1 = "\\Imagenes\\prueba" + a + ".jpg";
                File.WriteAllBytes(Server.MapPath(ruta1), byteImage);
                String ruta = Server.MapPath(ruta1);
                DAOUsuario dAO = new DAOUsuario();
                DataTable tabla = dAO.obtenerUsuario(int.Parse(Session["user_id_control"].ToString()));
                Correo correo = new Correo();

                correo.enviarCorreoQr(tabla.Rows[0]["correo"].ToString(), ruta,mensaje);


            }

            PHQRCode.Controls.Add(imgQRcode);



        }
    }   

    protected void TB_Calendariocupo_TextChanged(object sender, EventArgs e)
    {
        DateTime selec = new DateTime();
        DateTime hoy = DateTime.Today;
        selec = DateTime.Parse(TB_Calendariocupo.Text);
        Session["val_date"] = null;
        LB_u_n.Visible = false;
        if (selec < hoy)
        {
            Session["val_date"] = 1;
            LB_u_n.Visible = true;
        }
        if (selec.Year != hoy.Year)
        {
            Session["val_date"] = 1;
            LB_u_n.Visible = true;
        }
    }
    
    protected void DDL_usuarios_SelectedIndexChanged(object sender, EventArgs e)
    {

        DDL_Veicu.Items.Clear();
        DDL_Veicu.Items.Add("seleccione");
        Session["vehiculo_id"] = null;


        String username =DDL_usuarios.SelectedValue;
        DAOUsuario dAO = new DAOUsuario();
        DataTable datos = dAO.obtenerUsuariosTodos();
        Session["user_id_control"] = null;
        for (int i=0;i<datos.Rows.Count;i++)
        {
            if (username==datos.Rows[i]["user_name"].ToString())
            {
                Session["user_id_control"] = datos.Rows[i]["id"].ToString();
                break;
            }
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




}