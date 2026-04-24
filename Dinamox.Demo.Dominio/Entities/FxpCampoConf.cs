using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class FxpCampoConf
{
    /// <summary>
    /// Identificador del campo de configuración
    /// </summary>
    public int IdCampoConf { get; set; }

    public int IdObject { get; set; }

    /// <summary>
    /// Nombre de la propiedad interno
    /// </summary>
    public string NomProperty { get; set; } = null!;

    /// <summary>
    /// Nombre de la propiedad para mostrar al usuario
    /// </summary>
    public string NomPropertyDisplay { get; set; } = null!;

    /// <summary>
    /// Descripcion de para que sirve la propiedad
    /// </summary>
    public string DesProperty { get; set; } = null!;

    /// <summary>
    /// Identificador del tipo de campo para el configurar
    /// </summary>
    public short TipCampo { get; set; }

    /// <summary>
    /// Identificador del campo de configuración
    /// </summary>
    public int? IdCampoConfPadre { get; set; }

    public int? IdCampoConfGrupo { get; set; }

    public virtual FxpCampoConf? IdCampoConfPadreNavigation { get; set; }

    public virtual ICollection<FxpCampoConf> InverseIdCampoConfPadreNavigation { get; set; } = new List<FxpCampoConf>();

    public virtual FxpTipoCampo TipCampoNavigation { get; set; } = null!;
}
