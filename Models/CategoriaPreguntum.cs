using System;
using System.Collections.Generic;

namespace SurveyAppLibrary.Models;

public partial class CategoriaPreguntum
{
    public int Id { get; set; }

    public string Categoria { get; set; } = null!;

    public string? Descripcion { get; set; } = null!;

    public virtual ICollection<Preguntum> Preguntas { get; set; } = new List<Preguntum>();
}
