using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColEstudiante
{
    public int IdEstudiante { get; set; }

    public string CodigoEstudiante { get; set; } = null!;

    public string TipoDocumento { get; set; } = null!;

    public string NumeroDocumento { get; set; } = null!;

    public string PrimerNombre { get; set; } = null!;

    public string? SegundoNombre { get; set; }

    public string PrimerApellido { get; set; } = null!;

    public string? SegundoApellido { get; set; }

    public DateOnly FechaNacimiento { get; set; }

    public int IdGenero { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? CorreoElectronico { get; set; }

    public int? IdSede { get; set; }

    public int? IdGrupo { get; set; }

    public DateOnly? FechaIngreso { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<ColAsistencium> ColAsistencia { get; set; } = new List<ColAsistencium>();

    public virtual ICollection<ColComunicado> ColComunicados { get; set; } = new List<ColComunicado>();

    public virtual ICollection<ColEstudianteAcudiente> ColEstudianteAcudientes { get; set; } = new List<ColEstudianteAcudiente>();

    public virtual ICollection<ColNotum> ColNota { get; set; } = new List<ColNotum>();

    public virtual ICollection<ColUsuario> ColUsuarios { get; set; } = new List<ColUsuario>();

    public virtual ColGenero IdGeneroNavigation { get; set; } = null!;

    public virtual ColGrupo? IdGrupoNavigation { get; set; }

    public virtual ColSede? IdSedeNavigation { get; set; }
}
