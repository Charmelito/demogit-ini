using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColMaterium
{
    public int IdMateria { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Area { get; set; }

    public int? IntensidadHoraria { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<ColProfesorMaterium> ColProfesorMateria { get; set; } = new List<ColProfesorMaterium>();
}
