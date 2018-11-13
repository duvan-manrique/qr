using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de fechas_horas_bloqueadas
/// </summary>
public class fechas_horas_bloqueadas
{
    public fechas_horas_bloqueadas()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private int id;
    private DateTime fecha;

    public int Id { get => id; set => id = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
}