using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColEvento
{
    public int IdEvento { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public string TipoEvento { get; set; } = null!;

    public string? Ubicacion { get; set; }

    public int? IdGrupo { get; set; }

    public string? Estado { get; set; }

    public virtual ColGrupo? IdGrupoNavigation { get; set; }
}
