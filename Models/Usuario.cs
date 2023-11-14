using System;
using System.Collections.Generic;

namespace SurveyAppLibrary.Models;

public partial class Usuario
{
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string? NumeroTelefono { get; set; }
        public string? Nss { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int IdTipoUsuario { get; set; }
        public int IdRegion { get; set; }
        public virtual Region IdRegionNavegation { get; set; }
        public virtual TipoUsuario IdTipoUsuarioNavegation { get; set; }
        public virtual ICollection<Respuestum> Respuesta { get; set; } = new List <Respuestum> ();

}