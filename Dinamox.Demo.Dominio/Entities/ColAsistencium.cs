using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColAsistencium
{
    public int IdAsistencia { get; set; }

    public int IdEstudiante { get; set; }

    public int IdProfesorMateria { get; set; }

    public DateOnly Fecha { get; set; }

    public string EstadoAsistencia { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual ColEstudiante IdEstudianteNavigation { get; set; } = null!;

    public virtual ColProfesorMaterium IdProfesorMateriaNavigation { get; set; } = null!;
}
