using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class ProProveedore
{
    public int IdProveedor { get; set; }

    public string Proveedor { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string DirNotificacion { get; set; } = null!;

    public string Representante { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string? Celular { get; set; }

    public string? Email { get; set; }

    public int? TipoCompra { get; set; }

    public int? IdMunicipio { get; set; }

    public string? Www { get; set; }

    public string? FormaPago { get; set; }

    public byte? DiasRespuesta { get; set; }

    public DateTime? FecVinculacion { get; set; }

    public short? DiasLimiteDeuda { get; set; }

    public double? MontoLimiteDeuda { get; set; }

    public bool SwBloqueo { get; set; }

    public DateTime? FecBloqueo { get; set; }

    public string? MotivoBloqueo { get; set; }

    public float? DctoGeneral { get; set; }

    public float? DctoProntoPago { get; set; }

    public string? RegimenIva { get; set; }

    public string? Logo { get; set; }

    public int? IdTipoActividad { get; set; }

    public int IdEstado { get; set; }

    public DateTime FecAlta { get; set; }

    public int IdUsrAlta { get; set; }

    public virtual ProMunicipio? IdMunicipioNavigation { get; set; }

    public virtual ProTipoCompra? TipoCompraNavigation { get; set; }
}
