using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColGrado
{
    public int IdGrado { get; set; }

    public string Nombre { get; set; } = null!;

    public string Nivel { get; set; } = null!;

    public int? Orden { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<ColGrupo> ColGrupos { get; set; } = new List<ColGrupo>();
}
