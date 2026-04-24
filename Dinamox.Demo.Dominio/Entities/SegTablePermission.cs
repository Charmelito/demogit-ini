using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class SegTablePermission
{
    public int Id { get; set; }

    /// <summary>
    /// Id único de la regla
    /// </summary>
    public int RoleId { get; set; }

    /// <summary>
    /// Identificador único de la tabla
    /// </summary>
    public int TableId { get; set; }

    /// <summary>
    /// Indicador de si puede Visualizar la tabla
    /// </summary>
    public bool CanView { get; set; }

    /// <summary>
    /// Indicador de si puede Crear registros en la tabla
    /// </summary>
    public bool CanCreate { get; set; }

    /// <summary>
    /// Indicador de si puede Editar la tabla
    /// </summary>
    public bool CanEdit { get; set; }

    /// <summary>
    /// Indicador de si puede Eliminar registros de la tabla
    /// </summary>
    public bool CanDelete { get; set; }

    /// <summary>
    /// Indicador de si puede Exportar información de la tabla
    /// </summary>
    public bool CanExport { get; set; }

    /// <summary>
    /// Fecha de creación
    /// </summary>
    public DateTime CreatedAt { get; set; }

    public virtual SegRole Role { get; set; } = null!;

    public virtual SegSystemTable Table { get; set; } = null!;
}
