using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColProfesorMaterium
{
    public int IdProfesorMateria { get; set; }

    public int IdProfesor { get; set; }

    public int IdMateria { get; set; }

    public int IdGrupo { get; set; }

    public int? AnioEscolar { get; set; }

    public virtual ICollection<ColAsistencium> ColAsistencia { get; set; } = new List<ColAsistencium>();

    public virtual ICollection<ColHorario> ColHorarios { get; set; } = new List<ColHorario>();

    public virtual ICollection<ColNotum> ColNota { get; set; } = new List<ColNotum>();

    public virtual ColGrupo IdGrupoNavigation { get; set; } = null!;

    public virtual ColMaterium IdMateriaNavigation { get; set; } = null!;

    public virtual ColProfesor IdProfesorNavigation { get; set; } = null!;
}
