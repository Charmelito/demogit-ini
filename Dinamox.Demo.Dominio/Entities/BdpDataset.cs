using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class BdpDataset
{
    public int IdDataset { get; set; }

    public string NomDataset { get; set; } = null!;

    public string DesDataset { get; set; } = null!;

    public virtual ICollection<BdpTable> BdpTables { get; set; } = new List<BdpTable>();
}
