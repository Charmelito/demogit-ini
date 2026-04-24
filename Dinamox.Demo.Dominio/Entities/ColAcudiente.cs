using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColAcudiente
{
    public int IdAcudiente { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string NumeroDocumento { get; set; } = null!;

    public string PrimerNombre { get; set; } = null!;

    public string? SegundoNombre { get; set; }

    public string PrimerApellido { get; set; } = null!;

    public string? SegundoApellido { get; set; }

    public string Parentesco { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Direccion { get; set; }

    public string? Ocupacion { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<ColEstudianteAcudiente> ColEstudianteAcudientes { get; set; } = new List<ColEstudianteAcudiente>();

    public virtual ICollection<ColUsuario> ColUsuarios { get; set; } = new List<ColUsuario>();
}
