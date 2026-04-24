using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColGrupo
{
    public int IdGrupo { get; set; }

    public int IdGrado { get; set; }

    public string Nombre { get; set; } = null!;

    public int? Capacidad { get; set; }

    public int? AnioEscolar { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<ColComunicado> ColComunicados { get; set; } = new List<ColComunicado>();

    public virtual ICollection<ColEstudiante> ColEstudiantes { get; set; } = new List<ColEstudiante>();

    public virtual ICollection<ColEvento> ColEventos { get; set; } = new List<ColEvento>();

    public virtual ICollection<ColProfesorMaterium> ColProfesorMateria { get; set; } = new List<ColProfesorMaterium>();

    public virtual ColGrado IdGradoNavigation { get; set; } = null!;
}
