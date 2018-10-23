using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Reserva
/// </summary>
public class Reserva
{   
    public Reserva()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private int id;
    private int parq_id;
    private DateTime f_inicio;
    private DateTime f_fin;
    private int estado;
    private int vehiculo_id;
    private string descripcion;
    private int qr;

    public int Id { get => id; set => id = value; }
    public int Parq_id { get => parq_id; set => parq_id = value; }
    public DateTime F_inicio { get => f_inicio; set => f_inicio = value; }
    public DateTime F_fin { get => f_fin; set => f_fin = value; }
    public int Estado { get => estado; set => estado = value; }
    public int Vehiculo_id { get => vehiculo_id; set => vehiculo_id = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Qr { get => qr; set => qr = value; }
}