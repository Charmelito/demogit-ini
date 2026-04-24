using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpCampo
{
    /// <summary>
    /// Identificador del campo 
    /// </summary>
    public int CodCampo { get; set; }

    /// <summary>
    /// Nombre a guardar del campo, no puede estar separado por espacios
    /// </summary>
    public string NomCampo { get; set; } = null!;

    /// <summary>
    /// Tipo de campo 
    /// </summary>
    public short TipCampo { get; set; }

    /// <summary>
    /// Longitud o tamaño a ingresar
    /// </summary>
    public int LonCampo { get; set; }

    /// <summary>
    /// Objeto que representa el PropertyAttribute
    /// </summary>
    public string JsnConfig { get; set; } = null!;

    /// <summary>
    /// Origen donde buscara los datos de la lista
    /// </summary>
    public int? IdSimularTabla { get; set; }

    public virtual ICollection<AcaAtencampo> AcaAtencampos { get; set; } = new List<AcaAtencampo>();

    public virtual ICollection<AcaIncicampo> AcaIncicampos { get; set; } = new List<AcaIncicampo>();

    public virtual ICollection<AcpProcparam> AcpProcparams { get; set; } = new List<AcpProcparam>();

    public virtual ICollection<AcpTipoinccampo> AcpTipoinccampos { get; set; } = new List<AcpTipoinccampo>();

    public virtual ICollection<FxpProcesoVsParam> FxpProcesoVsParams { get; set; } = new List<FxpProcesoVsParam>();

    public virtual FxpSimularTabla? IdSimularTablaNavigation { get; set; }

    public virtual FxpTipoCampo TipCampoNavigation { get; set; } = null!;
}
