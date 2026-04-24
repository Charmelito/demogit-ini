using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class SegTypeQuery
{
    public int Id { get; set; }

    public byte[] TypeQueryName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<SegTableRow> SegTableRows { get; set; } = new List<SegTableRow>();
}
