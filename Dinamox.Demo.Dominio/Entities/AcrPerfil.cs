using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcrPerfil
{
    /// <summary>
    /// Identificador del perfil
    /// </summary>
    public int CodPerfil { get; set; }

    /// <summary>
    /// Descripción del perfil
    /// </summary>
    public string DesPerfil { get; set; } = null!;

    public string TipPerfil { get; set; } = null!;

    /// <summary>
    /// Indicador de Fijo
    /// </summary>
    public bool IndFijo { get; set; }

    public virtual ICollection<AcrPerfilususac> AcrPerfilususacCodPerfilcampNavigations { get; set; } = new List<AcrPerfilususac>();

    public virtual ICollection<AcrPerfilususac> AcrPerfilususacCodPerfiltincNavigations { get; set; } = new List<AcrPerfilususac>();

    public virtual ICollection<AcrRestradocumento> AcrRestradocumentos { get; set; } = new List<AcrRestradocumento>();

    public virtual ICollection<AcpCampanium> CodCampania { get; set; } = new List<AcpCampanium>();

    public virtual ICollection<AcpTipoincidencium> TipIncidencia { get; set; } = new List<AcpTipoincidencium>();
}
