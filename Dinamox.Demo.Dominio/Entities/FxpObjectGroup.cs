using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class FxpObjectGroup
{
    public int IdGroup { get; set; }

    public string NomGroup { get; set; } = null!;

    public string Display { get; set; } = null!;

    public string? DesGroup { get; set; }

    public string? Icon { get; set; }

    public int? IdGroupParent { get; set; }

    public virtual ICollection<FxpObjectProp> FxpObjectProps { get; set; } = new List<FxpObjectProp>();
}
