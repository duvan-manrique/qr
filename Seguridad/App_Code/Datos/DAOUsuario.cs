using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Configuration;
using System.Web.UI;

/// <summary>
/// Descripción breve de DAOUsuario
/// </summary>
public class DAOUsuario
{
    public DAOUsuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //


    }

    static ClientScriptManager cm = null;

    public void vista(ClientScriptManager cm1)
    {
        cm = cm1;
    }

    public DataTable loggin(String userName, String clave)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("security.f_loggin", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar, 100).Value = userName;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar, 100).Value = clave;
            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable guardadoSession(EUsuario datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("security.f_guardado_session", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.UserId;
            dataAdapter.SelectCommand.Parameters.Add("_ip", NpgsqlDbType.Varchar, 100).Value = datos.Ip;
            dataAdapter.SelectCommand.Parameters.Add("_mac", NpgsqlDbType.Varchar, 100).Value = datos.Mac;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

 

    public DataTable actualziarContrasena(EUsuario datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_contrasena", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.UserId;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar).Value = datos.Clave;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable cerrarSession(EUsuario datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("security.f_cerrar_session", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable generarToken(String user_name)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = user_name;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable almacenarToken(String token, Int32 userId)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_almacenar_token", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_token", NpgsqlDbType.Text).Value = token;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = userId;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }


    public DataTable obtenerUsuario(int id)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_usuarios", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_filtro", NpgsqlDbType.Integer).Value = id;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenervehiculouno(int id2)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_vehiculo_uno", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id2;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;


    }

    public DataTable obtenereservaTodos()
    {
        DataTable Reserva = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_reserva", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            


            conection.Open();
            dataAdapter.Fill(Reserva);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Reserva;
    }

    public DataTable obtenereservacionyo(int id)
    {
        DataTable Reserva = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_reservaoyo", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;


            conection.Open();
            dataAdapter.Fill(Reserva);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Reserva;
    }

    public DataTable obtenereserva(int id)
    {
        DataTable Reserva = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_reserva", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;


            conection.Open();
            dataAdapter.Fill(Reserva);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Reserva;
    }

    public DataTable obtenerqr()
    {
        DataTable qr = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_qr", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            conection.Open();
            dataAdapter.Fill(qr);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return qr;
    }

    public DataTable obtenerUsusarioToken(String token)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_usuario_token", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_token", NpgsqlDbType.Text).Value = token;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerUsuariosTodos()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_usuarios", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerParqueaderoTodos()
    {
        DataTable Parqueadero = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_parqueadero", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            conection.Open();
            dataAdapter.Fill(Parqueadero);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Parqueadero;
    }

    public DataTable obtenerVehiculosTodos(int tipo, int usuario_id)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_vehiculo", conection);

            dataAdapter.SelectCommand.Parameters.Add("_tipo", NpgsqlDbType.Integer).Value = tipo;
            dataAdapter.SelectCommand.Parameters.Add("_usuario_id", NpgsqlDbType.Integer).Value = usuario_id;

            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerfechas_horasTodos()
    {
        DataTable Fechas_horas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_fechas_horas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            conection.Open();
            dataAdapter.Fill(Fechas_horas);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Fechas_horas;
    }

    public DataTable obtenerfechas_horas_bloqueadasTodos()
    {
        DataTable Fechas_horas_bloqueadas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_fechas_horas_bloqueadas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            conection.Open();
            dataAdapter.Fill(Fechas_horas_bloqueadas);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Fechas_horas_bloqueadas;
    }

    public DataTable obtenerzonasTodos()
    {
        DataTable Zonas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_zonas1", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            conection.Open();
            dataAdapter.Fill(Zonas);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Zonas;
    }

    public DataTable obtenerMultasTodos()
    {
        DataTable Multas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_valor_multa", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            conection.Open();
            dataAdapter.Fill(Multas);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Multas;
    }

    public DataTable Traer_cupo(int tipo, DateTime F_inicio, DateTime F_fin)
    {
        DataTable Zonas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_cupo1", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_tipo", NpgsqlDbType.Integer).Value = tipo;
            dataAdapter.SelectCommand.Parameters.Add("_f_inicio", NpgsqlDbType.Timestamp).Value = F_inicio;
            dataAdapter.SelectCommand.Parameters.Add("_f_final", NpgsqlDbType.Timestamp).Value = F_fin;

            conection.Open();
            dataAdapter.Fill(Zonas);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Zonas;
    }


    public void Insert_User(User usuario1)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.insert_user", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = usuario1.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = usuario1.User_name;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = usuario1.Clave;
            dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Text).Value = usuario1.Correo;
            dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Integer).Value = 1;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = "seccion";
            dataAdapter.SelectCommand.Parameters.Add("_last_modified", NpgsqlDbType.Timestamp).Value = usuario1.Fecha;
            dataAdapter.SelectCommand.Parameters.Add("_rol_id", NpgsqlDbType.Integer).Value = usuario1.Rol_id;
            dataAdapter.SelectCommand.Parameters.Add("_codigo", NpgsqlDbType.Bigint).Value = usuario1.Codigo;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }

    public void Insert_Zonas(Zonas zonas1)
    {
        DataTable Zonas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.insert_zonas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Text).Value = zonas1.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_tipo_vehiculo", NpgsqlDbType.Integer).Value = zonas1.Tipo_vehiculo;
            dataAdapter.SelectCommand.Parameters.Add("_numero_de_campos", NpgsqlDbType.Integer).Value = zonas1.Numero_de_campos;


            conection.Open();
            dataAdapter.Fill(Zonas);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }

    public void Insert_fechas_horas(Fechas_horas fechas_horas1)
    {
        DataTable fechas_horas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.insert_fechas_horas1", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Date).Value = fechas_horas1.Fecha;
            dataAdapter.SelectCommand.Parameters.Add("_hora_inicio", NpgsqlDbType.Time).Value = fechas_horas1.Hora_inicio;
            dataAdapter.SelectCommand.Parameters.Add("_hora_fin", NpgsqlDbType.Time).Value = fechas_horas1.Hora_fin;


            conection.Open();
            dataAdapter.Fill(fechas_horas);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }

    public void Insert_fechas_horas_bloqueadas(fechas_horas_bloqueadas fechas_horas_bloqueadas1)
    {
        DataTable fechas_horas_bloqueadas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.insert_fechas_horas_bloqueadas1", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Date).Value = fechas_horas_bloqueadas1.Fecha; 


            conection.Open();
            dataAdapter.Fill(fechas_horas_bloqueadas);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }

    public void Insert_Reserva(Reserva reserva)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {


            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.insert_reserva", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_parqueadero_id", NpgsqlDbType.Integer).Value = reserva.Parq_id;
            dataAdapter.SelectCommand.Parameters.Add("_fecha_inicio", NpgsqlDbType.Timestamp).Value = reserva.F_inicio;
            dataAdapter.SelectCommand.Parameters.Add("_fecha_fin", NpgsqlDbType.Timestamp).Value = reserva.F_fin;
            dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Integer).Value = 1;
            dataAdapter.SelectCommand.Parameters.Add("_vehiculo_id", NpgsqlDbType.Integer).Value = reserva.Vehiculo_id;
            dataAdapter.SelectCommand.Parameters.Add("_descripcion", NpgsqlDbType.Text).Value = reserva.Descripcion;



            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }

    public void Insert_Vehiculo(Vehiculo vehiculo)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {


            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.insert_vehiculo", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_marca", NpgsqlDbType.Text).Value = vehiculo.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_tipo", NpgsqlDbType.Integer).Value = vehiculo.Tipo;
            dataAdapter.SelectCommand.Parameters.Add("_placa", NpgsqlDbType.Text).Value = vehiculo.Placa;
            dataAdapter.SelectCommand.Parameters.Add("_usuario_id", NpgsqlDbType.Integer).Value = vehiculo.Usuario_id;



            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }


    public void EliminarUsuario(int id)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_eliminar_usuarios", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }


    public void EliminarFecha(int id)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_eliminar_fecha", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }

    public void EliminarFecha_bloqueadas(int id)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_eliminar_fechabloqueada", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }

    public void EliminarZonas(int id)
    {
        DataTable Zonas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_eliminar_zonas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;

            conection.Open();
            dataAdapter.Fill(Zonas);
        }
        catch (Exception Ex)
        {
            //throw Ex;
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('no se pudo eliminar la zona');</script>");
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }

    public void EliminarReserva(int id)
    {
        DataTable Reserva = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_eliminar_reserva", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;

            conection.Open();
            dataAdapter.Fill(Reserva);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }


    public void UpdateUsuario(int id, string Nombre, string User_name, string Clave, string Correo, string rol ,string rol_u, long Codigo)
    {
       


        DataTable users = obtenerUsuariosTodos();
        int prue = 0;
        int idprue = 0;
        for (int i = 0; i < users.Rows.Count; i++)
        {

            if (User_name.Trim().Equals((users.Rows[i]["user_name"].ToString().Trim())))
            {
                prue++;
                idprue = int.Parse(users.Rows[i]["id"].ToString().Trim());
            }
            
        }
        if (id==idprue)
        {
            prue = 0;
        }

        if (prue > 0)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('No se puede actualizar user name ya existente');</script>");

        }
        else
        {

            int Rol_id = 0;
            switch (rol)
            {
                case "Admin":
                    Rol_id = 1;
                    break;

                case "User":
                    Rol_id = 3;
                    break;
                case "Vigilante":
                    Rol_id = 2;
                    break;

                default:
                    Rol_id = 3;
                    break;


            }

            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_usuario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = User_name;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = Clave;
                dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Text).Value = Correo;
                dataAdapter.SelectCommand.Parameters.Add("_rol_id", NpgsqlDbType.Integer).Value = Rol_id;
                dataAdapter.SelectCommand.Parameters.Add("_codigo", NpgsqlDbType.Bigint).Value = Codigo;


                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
        }
    }

    public void UpdateZonas(int id, string Nombre, String Tipo_vehiculo, String tipo, int Numero_de_campos)
    {
        DataTable zonas = obtenerzonasTodos();
        int prue = 0;
        int idprue = 0;
        for (int i = 0; i < zonas.Rows.Count; i++)
        {

            if (Nombre.Trim().Equals((zonas.Rows[i]["nombre"].ToString().Trim())))
            {
                prue++;
                idprue = int.Parse(zonas.Rows[i]["id"].ToString().Trim());
            }
        }

       
        if (id == idprue)
        {
            prue = 0;
        }

        if (prue > 0)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('No se puede actualizar nombre de zona ya existente');</script>");

        }
        else
        {
            int Tipo_vehiculo1 = 0;
            switch (tipo)
            {
                case "carro":
                    Tipo_vehiculo1 = 2;
                    break;

                case "moto":
                    Tipo_vehiculo1 = 1;
                    break;
                case "cicla":
                    Tipo_vehiculo1 = 3;
                    break;

                default:
                    Tipo_vehiculo1 = 2;
                    break;


            }
            DataTable Zonas = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_zonas", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_tipo_vehiculo", NpgsqlDbType.Integer).Value = Tipo_vehiculo1;
                dataAdapter.SelectCommand.Parameters.Add("_numero_de_vehiculo", NpgsqlDbType.Integer).Value = Numero_de_campos;


                conection.Open();
                dataAdapter.Fill(Zonas);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }

        }
    }

    public void Updatefechas_horas(int id, DateTime Fecha, TimeSpan Hora_inicio, TimeSpan Hora_fin)
    {
        DataTable Fechas_horas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
   
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_fechas_horas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
            dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Date).Value = Fecha;
            dataAdapter.SelectCommand.Parameters.Add("_hora_inicio", NpgsqlDbType.Time).Value = Hora_inicio;
            dataAdapter.SelectCommand.Parameters.Add("_hora_fin", NpgsqlDbType.Time).Value = Hora_fin;


            conection.Open();
            dataAdapter.Fill(Fechas_horas);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }

    public void UpdateReserva(int id, int parqueadero_id, DateTime fecha_inicio, DateTime fecha_fin, int estado, int vehiculo_id, string descripcion, int qr)
    {
        DataTable Reserva = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_reserva", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
            dataAdapter.SelectCommand.Parameters.Add("_parqueadero_id", NpgsqlDbType.Integer).Value = parqueadero_id;
            dataAdapter.SelectCommand.Parameters.Add("_fecha_inicio", NpgsqlDbType.Timestamp).Value = fecha_inicio;
            dataAdapter.SelectCommand.Parameters.Add("_fecha_fin", NpgsqlDbType.Timestamp).Value = fecha_fin;
            dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Integer).Value = estado;
            dataAdapter.SelectCommand.Parameters.Add("_vehiculo_id", NpgsqlDbType.Integer).Value = vehiculo_id;
            dataAdapter.SelectCommand.Parameters.Add("_descripcion", NpgsqlDbType.Text).Value = descripcion;
            dataAdapter.SelectCommand.Parameters.Add("_qr", NpgsqlDbType.Integer).Value = qr;



            conection.Open();
            dataAdapter.Fill(Reserva);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }

    public void UpdateUsuarioyo(int id, string Nombre, string User_name, string Clave, string Correo)
    {

        DataTable users = obtenerUsuariosTodos();
        int prue = 0;
        int idprue = 0;
        for (int i = 0; i < users.Rows.Count; i++)
        {

            if (User_name.Trim().Equals((users.Rows[i]["user_name"].ToString().Trim())))
            {
                prue++;
                idprue = int.Parse(users.Rows[i]["id"].ToString().Trim());
            }
        }

        if (id == idprue)
        {
            prue = 0;
        }


        if (prue > 0)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('No se puede actualizar user name ya existente');</script>");

        }
        else
        {
            DataTable Usuarioyo = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_usuarioyo", conection);

                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = User_name;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = Clave;
                dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Text).Value = Correo;


                conection.Open();
                dataAdapter.Fill(Usuarioyo);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }

        }
    }

    public void UpdateValorMulta(int id, string Nombre, double   Valor_multa)
    {
            DataTable Multa = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_Valor_Multa", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
                dataAdapter.SelectCommand.Parameters.Add("_valor_multa", NpgsqlDbType.Double ).Value = Valor_multa;
            
                conection.Open();
                dataAdapter.Fill(Multa);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
        
    }

    public void update_entrda(int id, int idqr, DateTime entrada)
    {
        DataTable tabla = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_entrada", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
            dataAdapter.SelectCommand.Parameters.Add("_qr", NpgsqlDbType.Integer).Value = idqr;
            dataAdapter.SelectCommand.Parameters.Add("_fecha_entrada", NpgsqlDbType.Date).Value = entrada;

            conection.Open();
            dataAdapter.Fill(tabla);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }

    public void update_salida(int id, int idqr, DateTime salida)
    {
        DataTable tabla = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_salida", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
            dataAdapter.SelectCommand.Parameters.Add("_qr", NpgsqlDbType.Integer).Value = idqr;
            dataAdapter.SelectCommand.Parameters.Add("_fecha_salida", NpgsqlDbType.Timestamp).Value = salida;

            conection.Open();
            dataAdapter.Fill(tabla);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }


}