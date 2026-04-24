using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaHatencion
{
    public decimal NumAtencion { get; set; }

    public decimal CodCampania { get; set; }

    public string NomUsuarora { get; set; } = null!;

    public DateTime FecAtencion { get; set; }

    public DateTime FecHistorico { get; set; }

    public virtual ICollection<AcaHatencampo> AcaHatencampos { get; set; } = new List<AcaHatencampo>();

    public virtual ICollection<AcaHatendetalle> AcaHatendetalles { get; set; } = new List<AcaHatendetalle>();

    public virtual ICollection<AcaHatendoc> AcaHatendocs { get; set; } = new List<AcaHatendoc>();
}
