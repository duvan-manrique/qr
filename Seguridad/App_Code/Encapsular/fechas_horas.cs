﻿using System;
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
    private TimeSpan hora_inicio;
    private TimeSpan hora_fin;

    public int Id { get => id; set => id = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
    public TimeSpan Hora_inicio { get => hora_inicio; set => hora_inicio = value; }
    public TimeSpan Hora_fin { get => hora_fin; set => hora_fin = value; }
}
