using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColProfesor
{
    public int IdProfesor { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string NumeroDocumento { get; set; } = null!;

    public string PrimerNombre { get; set; } = null!;

    public string? SegundoNombre { get; set; }

    public string PrimerApellido { get; set; } = null!;

    public string? SegundoApellido { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? Genero { get; set; }

    public string? Telefono { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Direccion { get; set; }

    public string? Especialidad { get; set; }

    public DateOnly? FechaContratacion { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<ColAgendum> ColAgenda { get; set; } = new List<ColAgendum>();

    public virtual ICollection<ColProfesorMaterium> ColProfesorMateria { get; set; } = new List<ColProfesorMaterium>();

    public virtual ICollection<ColUsuario> ColUsuarios { get; set; } = new List<ColUsuario>();
}
