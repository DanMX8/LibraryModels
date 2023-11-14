using System;
using System.Collections.Generic;

namespace SurveyAppLibrary.Models;
public partial class Region
{
    public int Id { get; set; }

    public string NombreRegion { get; set; }

    public virtual ICollection<Encuestum> Encuestas { get; set; } = new List<Encuestum>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
