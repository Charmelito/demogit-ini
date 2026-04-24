using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColComunicado
{
    public int IdComunicado { get; set; }

    public string Titulo { get; set; } = null!;

    public string Contenido { get; set; } = null!;

    public DateTime? FechaPublicacion { get; set; }

    public DateOnly? FechaExpiracion { get; set; }

    public string TipoComunicado { get; set; } = null!;

    public int? IdGrupo { get; set; }

    public int? IdEstudiante { get; set; }

    public string? Estado { get; set; }

    public virtual ColEstudiante? IdEstudianteNavigation { get; set; }

    public virtual ColGrupo? IdGrupoNavigation { get; set; }
}
