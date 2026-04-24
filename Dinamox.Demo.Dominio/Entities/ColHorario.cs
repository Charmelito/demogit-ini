using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColHorario
{
    public int IdHorario { get; set; }

    public int IdProfesorMateria { get; set; }

    public int DiaSemana { get; set; }

    public TimeOnly HoraInicio { get; set; }

    public TimeOnly HoraFin { get; set; }

    public string? Salon { get; set; }

    public virtual ColProfesorMaterium IdProfesorMateriaNavigation { get; set; } = null!;
}
