using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

public class Fechas_horas 
{
    public Fechas_horas()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private int id;
    private DateTime fecha;
    private int hora_inicio;
    private int hora_fin;

    public int Id { get => id; set => id = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
    public int Hora_inicio { get => hora_inicio; set => hora_inicio = value; }
    public int Hora_fin { get => hora_fin; set => hora_fin = value; }
}
