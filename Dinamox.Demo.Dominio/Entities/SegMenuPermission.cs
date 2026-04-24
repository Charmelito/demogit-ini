using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class SegMenuPermission
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public int MenuModuleId { get; set; }

    public bool CanView { get; set; }

    public bool CanCreate { get; set; }

    public bool CanEdit { get; set; }

    public bool CanDelete { get; set; }

    public bool CanExport { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual SegMenuModule MenuModule { get; set; } = null!;

    public virtual SegRole Role { get; set; } = null!;
}
