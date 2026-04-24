using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ProMunicipio
{
    public int IdMunicipio { get; set; }

    public string Municipio { get; set; } = null!;

    public virtual ICollection<ProProveedore> ProProveedores { get; set; } = new List<ProProveedore>();
}
