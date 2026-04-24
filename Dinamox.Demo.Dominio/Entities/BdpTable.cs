using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class BdpTable
{
    public int IdTable { get; set; }

    public string NomTable { get; set; } = null!;

    public string DesTable { get; set; } = null!;

    public int IdDataset { get; set; }

    public virtual ICollection<DbpColumn> DbpColumns { get; set; } = new List<DbpColumn>();

    public virtual ICollection<DbpMasterdetail> DbpMasterdetailIdTabledetailNavigations { get; set; } = new List<DbpMasterdetail>();

    public virtual ICollection<DbpMasterdetail> DbpMasterdetailIdTablemasterNavigations { get; set; } = new List<DbpMasterdetail>();

    public virtual BdpDataset IdDatasetNavigation { get; set; } = null!;
}
