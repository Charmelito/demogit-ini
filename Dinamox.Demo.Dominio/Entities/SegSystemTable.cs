using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class SegSystemTable
{
    /// <summary>
    /// Identificador único de la tabla
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nombre de la tabla de la Base de Datos
    /// </summary>
    public string TableName { get; set; } = null!;

    /// <summary>
    /// Descripción de para que es la tabla
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Indicador de si esta activa
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Fecha de creación
    /// </summary>
    public DateTime CreatedAt { get; set; }

    public virtual ICollection<SegTableField> SegTableFields { get; set; } = new List<SegTableField>();

    public virtual ICollection<SegTablePermission> SegTablePermissions { get; set; } = new List<SegTablePermission>();

    public virtual ICollection<SegTableRow> SegTableRows { get; set; } = new List<SegTableRow>();
}
