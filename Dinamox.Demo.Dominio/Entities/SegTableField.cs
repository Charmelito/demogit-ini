using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

/// <summary>
/// Tablas del sistema
/// </summary>
public partial class SegTableField
{
    /// <summary>
    /// Identificador único del campo
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Identificador único de la tabla
    /// </summary>
    public int TableId { get; set; }

    /// <summary>
    /// Nombre del campo de la tabla
    /// </summary>
    public string FieldName { get; set; } = null!;

    /// <summary>
    /// Nombre descriptivo del campo
    /// </summary>
    public string DisplayName { get; set; } = null!;

    /// <summary>
    /// Tipo de datos
    /// </summary>
    public string DataType { get; set; } = null!;

    /// <summary>
    /// Indicador de que el campo es por defecto de la Base de datos y no se debe tener encuenta en la inserción
    /// </summary>
    public bool IsDefaultDb { get; set; }

    /// <summary>
    /// Indicador de si esta activa
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Fecha de creación
    /// </summary>
    public DateTime CreatedAt { get; set; }

    public virtual ICollection<SegFieldPermission> SegFieldPermissions { get; set; } = new List<SegFieldPermission>();

    public virtual SegSystemTable Table { get; set; } = null!;
}
