using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class SegFieldPermission
{
    /// <summary>
    /// Id permisos sobre el campo de la tabla
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Id único de la regla
    /// </summary>
    public int RoleId { get; set; }

    /// <summary>
    /// Id de la tabla campo
    /// </summary>
    public int TableFieldId { get; set; }

    /// <summary>
    /// Indicador de si puede Visualizar la propiedad
    /// </summary>
    public bool CanView { get; set; }

    /// <summary>
    /// Indicador de si puede Crear datos a la propiedad
    /// </summary>
    public bool CanCreate { get; set; }

    /// <summary>
    /// Indicador de si puede Editar la propiedad
    /// </summary>
    public bool CanEdit { get; set; }

    /// <summary>
    /// Fecha de creación
    /// </summary>
    public DateTime CreatedAt { get; set; }

    public virtual SegRole Role { get; set; } = null!;

    public virtual SegTableField TableField { get; set; } = null!;
}
