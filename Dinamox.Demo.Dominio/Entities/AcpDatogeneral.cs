using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpDatogeneral
{
    /// <summary>
    /// Usuario dueño de las tablas
    /// </summary>
    public string NomUsuarorapropt { get; set; } = null!;

    /// <summary>
    /// Código del concepto
    /// </summary>
    public decimal CodConcepto { get; set; }

    /// <summary>
    /// Numero del minuto de la alarma
    /// </summary>
    public decimal NumMinutoalarma { get; set; }

    public decimal NumHoraromp { get; set; }

    public decimal NumDiaromp { get; set; }

    public decimal? CodReportRuptura { get; set; }

    public string? NumCertiso { get; set; }

    public string? Pathreports { get; set; }

    /// <summary>
    /// Nombre de la empresa
    /// </summary>
    public string? NomEmpresa { get; set; }

    public string? NomNemoempresa { get; set; }

    public string? NumIdentifica { get; set; }

    public string? NumIdentificanuir { get; set; }

    public string? NomUsujefeac { get; set; }

    public decimal? CodCampinternet { get; set; }

    public virtual AcpProceso? CodReportRupturaNavigation { get; set; }
}
