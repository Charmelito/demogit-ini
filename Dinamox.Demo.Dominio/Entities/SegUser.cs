using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

/// <summary>
/// Tabla para el manejo de los usuarios
/// </summary>
public partial class SegUser
{
    /// <summary>
    /// Indicador unico del usuario
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nombre del usuario
    /// </summary>
    public string Username { get; set; } = null!;

    /// <summary>
    /// Correo electronico
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// Clave
    /// </summary>
    public string PasswordHash { get; set; } = null!;

    /// <summary>
    /// Indicador de activo
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Fecha de creación
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Fecha de actualización
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<SegUserRole> SegUserRoles { get; set; } = new List<SegUserRole>();
}
