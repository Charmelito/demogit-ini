using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

/// <summary>
/// Parametros para un proceso (Proceso vs campos)
/// </summary>
public partial class FxpProcesoVsParam
{
    /// <summary>
    /// Indicador unico del proceso
    /// </summary>
    public int IdProceso { get; set; }

    /// <summary>
    /// Identificador del campo 
    /// </summary>
    public int CodCampo { get; set; }

    /// <summary>
    /// Numero de item en la secuencia para mostrar o procesar
    /// </summary>
    public int NumOrden { get; set; }

    /// <summary>
    /// Identificador del grupo
    /// </summary>
    public int? IdGrouping { get; set; }

    public virtual AcpCampo CodCampoNavigation { get; set; } = null!;

    public virtual FxpGroupingAttr? IdGroupingNavigation { get; set; }

    public virtual FxpProceso IdProcesoNavigation { get; set; } = null!;
}
