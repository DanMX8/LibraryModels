using System;
using System.Collections.Generic;

namespace SurveyAppLibrary.Models;

public partial class TipoPreguntum
{
    public int Id { get; set; }

    public string TipoPregunta { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Preguntum> Pregunta { get; set; } = new List<Preguntum>();
}
    