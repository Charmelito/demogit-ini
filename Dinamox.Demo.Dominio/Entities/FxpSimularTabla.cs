using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

/// <summary>
/// Tabla para simular tablas para las listas
/// </summary>
public partial class FxpSimularTabla
{
    /// <summary>
    /// Id de la tabla simulada
    /// </summary>
    public int IdSimularTabla { get; set; }

    /// <summary>
    /// Nombre para la tabla simulada
    /// </summary>
    public string NomSimularTabla { get; set; } = null!;

    /// <summary>
    /// Descripción de la tabla simulada
    /// </summary>
    public string DesSimularTabla { get; set; } = null!;

    /// <summary>
    /// Indicador de que la tabla es real en BD
    /// </summary>
    public bool IndTablaEsReal { get; set; }

    /// <summary>
    /// Nombre del campo que representa el ID
    /// </summary>
    public string? NomCampoId { get; set; }

    /// <summary>
    /// Nombre del campo que representa la descripción
    /// </summary>
    public string? NomCampoDesc { get; set; }

    public virtual ICollection<AcpCampo> AcpCampos { get; set; } = new List<AcpCampo>();

    public virtual ICollection<DbpColumn> DbpColumns { get; set; } = new List<DbpColumn>();

    public virtual ICollection<FxpSimularCampo> FxpSimularCampos { get; set; } = new List<FxpSimularCampo>();
}
