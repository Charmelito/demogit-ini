using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColSede
{
    public int IdSede { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<ColEstudiante> ColEstudiantes { get; set; } = new List<ColEstudiante>();
}
