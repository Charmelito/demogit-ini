using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ProTipoCompra
{
    public int IdTipoCompra { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ProProveedore> ProProveedores { get; set; } = new List<ProProveedore>();
}
