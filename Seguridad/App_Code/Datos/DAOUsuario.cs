using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Configuration;

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

    public DataTable obtenerUsuarios(int filtro)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_usuarios", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_filtro", NpgsqlDbType.Integer).Value = filtro;

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

    public void UpdateUsuario(int id,string Nombre,string User_name,string Clave,string Correo,int Rol_id,long  Codigo)
    {
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


    public DataTable obteneryo(int filtro)
    {
        DataTable Usuarioyo = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_usuarioyo", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_filtro", NpgsqlDbType.Integer).Value = filtro;


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
        return Usuarioyo;
    }

    public void UpdateUsuarioyo(int id, string Nombre, string User_name, string Clave, string Correo)
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

    public DataTable obtenerzonasTodos()
    {
        DataTable Zonas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_zonas", conection);
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

    public void UpdateZonas(int id, string Nombre, int Tipo_vehiculo,  int Numero_de_campos)
    {
        DataTable Zonas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_zonas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_tipo_vehiculo", NpgsqlDbType.Integer).Value = Tipo_vehiculo;
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

    public void Insert_fechas_horas(Fechas_horas fechas_horas1)
    {
        DataTable fechas_horas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.insert_fechas_horas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Date).Value = fechas_horas1.Fecha;
            dataAdapter.SelectCommand.Parameters.Add("_hora_inicio", NpgsqlDbType.Integer).Value = fechas_horas1.Hora_inicio;
            dataAdapter.SelectCommand.Parameters.Add("_hora_fin", NpgsqlDbType.Integer).Value = fechas_horas1.Hora_fin;


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

    public void Updatefechas_horas(int id, DateTime Fecha, int Hora_inicio, int Hora_fin)
    {
        DataTable Fechas_horas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_fechas_horas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
            dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Date).Value = Fecha;
            dataAdapter.SelectCommand.Parameters.Add("_hora_inicio", NpgsqlDbType.Integer).Value = Hora_inicio;
            dataAdapter.SelectCommand.Parameters.Add("_hora_fin", NpgsqlDbType.Integer).Value = Hora_fin;


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

    public DataTable obtenerVehiculosTodos(int tipo,int usuario_id)
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
   
    public DataTable obtenereservaTodos(int id)
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
            dataAdapter.SelectCommand.Parameters.Add("_fecha_inicio", NpgsqlDbType.Date).Value = fecha_inicio;
            dataAdapter.SelectCommand.Parameters.Add("_fecha_fin", NpgsqlDbType.Date).Value = fecha_fin;
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
  
}