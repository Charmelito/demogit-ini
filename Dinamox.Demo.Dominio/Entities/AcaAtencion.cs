using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaAtencion
{
    public int NumAtencion { get; set; }

    public short CodCampania { get; set; }

    public string NomUsuarora { get; set; } = null!;

    public DateTime FecAtencion { get; set; }

    public bool IndSimulado { get; set; }

    public bool IndEnviomail { get; set; }

    public virtual ICollection<AcaAtencampo> AcaAtencampos { get; set; } = new List<AcaAtencampo>();

    public virtual ICollection<AcaAtendetalle> AcaAtendetalles { get; set; } = new List<AcaAtendetalle>();

    public virtual ICollection<AcaAtendoc> AcaAtendocs { get; set; } = new List<AcaAtendoc>();

    public virtual AcaBuzonatencion? AcaBuzonatencion { get; set; }

    public virtual ICollection<AcaIncidencium> AcaIncidencia { get; set; } = new List<AcaIncidencium>();

    public virtual AcpCampanium CodCampaniaNavigation { get; set; } = null!;

    public virtual AcpUsusac NomUsuaroraNavigation { get; set; } = null!;
}
