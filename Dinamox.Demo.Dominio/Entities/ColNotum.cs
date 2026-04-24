using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColNotum
{
    public int IdNota { get; set; }

    public int IdEstudiante { get; set; }

    public int IdProfesorMateria { get; set; }

    public int Periodo { get; set; }

    public string TipoEvaluacion { get; set; } = null!;

    public decimal Valor { get; set; }

    public decimal Ponderacion { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? Observaciones { get; set; }

    public virtual ColEstudiante IdEstudianteNavigation { get; set; } = null!;

    public virtual ColProfesorMaterium IdProfesorMateriaNavigation { get; set; } = null!;
}
