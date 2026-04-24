using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColEstudianteAcudiente
{
    public int IdEstudianteAcudiente { get; set; }

    public int IdEstudiante { get; set; }

    public int IdAcudiente { get; set; }

    public bool? EsPrincipal { get; set; }

    public virtual ColAcudiente IdAcudienteNavigation { get; set; } = null!;

    public virtual ColEstudiante IdEstudianteNavigation { get; set; } = null!;
}
