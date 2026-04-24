using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class DbpColumn
{
    public int IdColumn { get; set; }

    public string NomColumn { get; set; } = null!;

    public string DesColumn { get; set; } = null!;

    /// <summary>
    /// Tipo de campo 
    /// </summary>
    public short TipColumn { get; set; }

    public int IdTable { get; set; }

    /// <summary>
    /// Origen donde buscara los datos de la lista
    /// </summary>
    public int? IdSimularTabla { get; set; }

    /// <summary>
    /// Objeto que representa el PropertyAttribute
    /// </summary>
    public string JsnConfig { get; set; } = null!;

    public virtual FxpSimularTabla? IdSimularTablaNavigation { get; set; }

    public virtual BdpTable IdTableNavigation { get; set; } = null!;

    public virtual FxpTipoCampo TipColumnNavigation { get; set; } = null!;
}
