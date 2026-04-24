using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColAviso
{
    public int IdAviso { get; set; }

    public string Titulo { get; set; } = null!;

    public string Mensaje { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public string? Prioridad { get; set; }

    public string? Destinatario { get; set; }

    public bool? Estado { get; set; }
}
