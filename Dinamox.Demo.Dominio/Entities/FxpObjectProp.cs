using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class FxpObjectProp
{
    public int IdProperty { get; set; }

    public int IdObject { get; set; }

    public string? NomProperty { get; set; }

    public string NomPropertyDisplay { get; set; } = null!;

    public string? DesProperty { get; set; }

    /// <summary>
    /// Identificador del tipo de campo para el configurar
    /// </summary>
    public short TipCampo { get; set; }

    /// <summary>
    /// Identificador del campo de configuración
    /// </summary>
    public int? IdPropertyParent { get; set; }

    public int? IdGroup { get; set; }

    public virtual FxpObjectGroup? IdGroupNavigation { get; set; }

    public virtual FxpObject IdObjectNavigation { get; set; } = null!;

    public virtual FxpObjectProp? IdPropertyParentNavigation { get; set; }

    public virtual ICollection<FxpObjectProp> InverseIdPropertyParentNavigation { get; set; } = new List<FxpObjectProp>();

    public virtual FxpTipoCampo TipCampoNavigation { get; set; } = null!;
}
