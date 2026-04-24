using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class SegTableRow
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
    /// Tipo de query, se refiere a los objetos diseñados para generar las consultas
    /// </summary>
    public int TypeQueryId { get; set; }

    public string Query { get; set; } = null!;

    public virtual ICollection<SegRowsPermission> SegRowsPermissions { get; set; } = new List<SegRowsPermission>();

    public virtual SegSystemTable Table { get; set; } = null!;

    public virtual SegTypeQuery TypeQuery { get; set; } = null!;
}
