using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Class1
/// </summary>
public class Vehiculo
{
    public Vehiculo()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private int id;
    private string nombre;
    private int tipo;
    private string placa;
    private int usuario_id;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Tipo { get => tipo; set => tipo = value; }
    public string Placa { get => placa; set => placa = value; }
    public int Usuario_id { get => usuario_id; set => usuario_id = value; }
}