using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColAgendum
{
    public int IdAgenda { get; set; }

    public int IdProfesor { get; set; }

    public DateOnly Fecha { get; set; }

    public TimeOnly HoraInicio { get; set; }

    public TimeOnly HoraFin { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? TipoActividad { get; set; }

    public string? Estado { get; set; }

    public virtual ColProfesor IdProfesorNavigation { get; set; } = null!;
}
