using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

/// <summary>
/// Manejo de los días Festivos
/// </summary>
public partial class AcpDiasfest
{
    /// <summary>
    /// Dia festivo, en formato fecha
    /// </summary>
    public DateOnly FecDiafest { get; set; }

    /// <summary>
    /// Descripción del día festivo
    /// </summary>
    public string DesDiafest { get; set; } = null!;
}
