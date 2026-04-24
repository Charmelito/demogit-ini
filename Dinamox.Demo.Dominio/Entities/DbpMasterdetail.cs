using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class DbpMasterdetail
{
    public int IdTablemaster { get; set; }

    public int IdTabledetail { get; set; }

    public string? NomMasterdetail { get; set; }

    public virtual BdpTable IdTabledetailNavigation { get; set; } = null!;

    public virtual BdpTable IdTablemasterNavigation { get; set; } = null!;
}
