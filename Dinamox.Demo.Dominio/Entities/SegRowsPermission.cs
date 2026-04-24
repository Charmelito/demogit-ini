using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class SegRowsPermission
{
    /// <summary>
    /// Id permisos sobre que filas mostrar de la tabla
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Id único de la regla
    /// </summary>
    public int RoleId { get; set; }

    /// <summary>
    /// Identificador único de la tabla
    /// </summary>
    public int TableRowId { get; set; }

    /// <summary>
    /// Tipo de query, se refiere a los objetos diseñados para generar las consultas
    /// </summary>
    public int TypeQueryId { get; set; }

    public virtual SegRole Role { get; set; } = null!;

    public virtual SegTableRow TableRow { get; set; } = null!;
}
