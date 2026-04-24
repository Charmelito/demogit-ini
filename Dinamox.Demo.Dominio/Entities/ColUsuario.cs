using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ColUsuario
{
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public string TipoUsuario { get; set; } = null!;

    public int? IdProfesor { get; set; }

    public int? IdAcudiente { get; set; }

    public int? IdEstudiante { get; set; }

    public bool? Estado { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ColAcudiente? IdAcudienteNavigation { get; set; }

    public virtual ColEstudiante? IdEstudianteNavigation { get; set; }

    public virtual ColProfesor? IdProfesorNavigation { get; set; }
}
