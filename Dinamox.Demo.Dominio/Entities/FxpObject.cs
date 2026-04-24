using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class FxpObject
{
    public int IdObject { get; set; }

    public string NomObject { get; set; } = null!;

    public string DescObject { get; set; } = null!;

    public string? Icon { get; set; }

    public virtual ICollection<FxpObjectProp> FxpObjectProps { get; set; } = new List<FxpObjectProp>();
}
