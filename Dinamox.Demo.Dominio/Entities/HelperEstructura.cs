using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class HelperEstructura
{
    public int Id { get; set; }

    /// <summary>
    /// Nombre de la tabla
    /// </summary>
    public string TableName { get; set; } = null!;

    /// <summary>
    /// Nombre de la tabla que la reemplazo
    /// </summary>
    public string NewTableName { get; set; } = null!;

    /// <summary>
    /// inidicador de eliminar la tabla
    /// </summary>
    public bool IndEliminar { get; set; }

    /// <summary>
    /// Indicador que esta tabla es nueva
    /// </summary>
    public bool IndNuevo { get; set; }

    /// <summary>
    /// descripción de ayuda
    /// </summary>
    public string? Descripcion { get; set; }
}
