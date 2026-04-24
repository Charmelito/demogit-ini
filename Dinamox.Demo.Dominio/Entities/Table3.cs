using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class Table3
{
    /// <summary>
    /// Identificador del proceso
    /// </summary>
    public int Idproceso { get; set; }

    public int IditemProceso { get; set; }

    /// <summary>
    /// Identificador de la actividad
    /// </summary>
    public int IditemProcesoSig { get; set; }

    public bool Swactivo { get; set; }
}
