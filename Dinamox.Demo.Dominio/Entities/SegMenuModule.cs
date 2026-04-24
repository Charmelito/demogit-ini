using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class SegMenuModule
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? ParentId { get; set; }

    public string? Route { get; set; }

    public string? Icon { get; set; }

    public int DisplayOrder { get; set; }

    public bool IsActive { get; set; }

    /// <summary>
    /// Fecha de creación
    /// </summary>
    public DateTime CreatedAt { get; set; }

    public virtual ICollection<SegMenuModule> InverseParent { get; set; } = new List<SegMenuModule>();

    public virtual SegMenuModule? Parent { get; set; }

    public virtual ICollection<SegMenuPermission> SegMenuPermissions { get; set; } = new List<SegMenuPermission>();
}
