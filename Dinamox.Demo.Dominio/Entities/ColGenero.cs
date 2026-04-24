using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColGenero
{
    public int IdGenero { get; set; }

    public string Genero { get; set; } = null!;

    public virtual ICollection<ColEstudiante> ColEstudiantes { get; set; } = new List<ColEstudiante>();
}
