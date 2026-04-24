using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class FxpTipoCampo
{
    /// <summary>
    /// Tipo de campo
    /// </summary>
    public short TipCampo { get; set; }

    /// <summary>
    /// _
    /// </summary>
    public string DesTipoCampo { get; set; } = null!;

    /// <summary>
    /// Nombre que representa el tipo de campo
    /// </summary>
    public string NomTipCampo { get; set; } = null!;

    /// <summary>
    /// Nombre del asssembly del tipo de campo
    /// </summary>
    public string? TipCampoCsharp { get; set; }

    public virtual ICollection<AcpCampo> AcpCampos { get; set; } = new List<AcpCampo>();

    public virtual ICollection<DbpColumn> DbpColumns { get; set; } = new List<DbpColumn>();

    public virtual ICollection<FxpCampoConf> FxpCampoConfs { get; set; } = new List<FxpCampoConf>();

    public virtual ICollection<FxpObjectProp> FxpObjectProps { get; set; } = new List<FxpObjectProp>();
}
