using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Zonas
/// </summary>
public class Zonas
{
    public Zonas()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private int id;
    private string nombre;
    private  int tipo_de_vehiculo;
    private int numero_de_campos;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Tipo_vehiculo { get => tipo_de_vehiculo; set => tipo_de_vehiculo = value; }
    public int Numero_de_campos { get => numero_de_campos; set => numero_de_campos = value; }

}

  
