using SurveyAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppLibrary.DTO;

public class UsuarioDTO
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public string? NumeroTelefono { get; set; }
    public string? Nss { get; set; }
    public string Correo { get; set; } = null!;
    public string Password { get; set; } = null!;
    public DateTime? FechaNacimiento { get; set; }
    public int IdTipoUsuario { get; set; }
    public int IdRegion { get; set; }
    public static UsuarioDTO UsuarioToDTO(Usuario usuario) =>
    new UsuarioDTO
    {
            Id = usuario.Id,
            Nombre = usuario.Nombre,
            ApellidoPaterno = usuario.ApellidoPaterno,
            ApellidoMaterno = usuario.ApellidoMaterno,
            NumeroTelefono = usuario.NumeroTelefono,
            Nss = usuario.Nss,
            Correo = usuario.Correo,
            Password = usuario.Password,
            FechaNacimiento = usuario.FechaNacimiento,
            IdTipoUsuario = usuario.IdTipoUsuario,
            IdRegion = usuario.IdRegion
        };
}
