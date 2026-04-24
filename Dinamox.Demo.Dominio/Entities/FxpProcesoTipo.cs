using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

/// <summary>
/// Tipo de Proceso Form, Services, ejecutable, Procedimientos almacenados, etc
/// </summary>
public partial class FxpProcesoTipo
{
    /// <summary>
    /// Indicador unico del tipo de proceso
    /// </summary>
    public int IdProcesoTipo { get; set; }

    /// <summary>
    /// Nombre del tipo de proceso
    /// </summary>
    public string NomProcesoTipo { get; set; } = null!;

    /// <summary>
    /// Descripción del tipo de proceso
    /// </summary>
    public string DesProcesoTipo { get; set; } = null!;

    public virtual ICollection<FxpProceso> FxpProcesos { get; set; } = new List<FxpProceso>();
}
