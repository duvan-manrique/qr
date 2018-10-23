using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de User
/// </summary>
public class User
{
    public User()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private int id;
    private string nombre;
    private string user_name;
    private string clave;
    private string correo;
    private DateTime fecha;
    private int rol_id;
    private long codigo;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string User_name { get => user_name; set => user_name = value; }
    public string Clave { get => clave; set => clave = value; }
    public string Correo { get => correo; set => correo = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
    public int Rol_id { get => rol_id; set => rol_id = value; }
    public long Codigo { get => codigo; set => codigo = value; }
}