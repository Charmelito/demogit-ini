using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class FxpSimularCampo
{
    /// <summary>
    /// Id del campo
    /// </summary>
    public int IdSimularCampo { get; set; }

    /// <summary>
    /// Id de la tabla simulada
    /// </summary>
    public int IdSimularTabla { get; set; }

    /// <summary>
    /// Valor que respresenta el id del campo
    /// </summary>
    public int ValIdcampo { get; set; }

    /// <summary>
    /// Valor que respresenta la descripción del campo
    /// </summary>
    public string ValDescampo { get; set; } = null!;

    public virtual FxpSimularTabla IdSimularTablaNavigation { get; set; } = null!;
}
