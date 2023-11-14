using System;
using System.Collections.Generic;

namespace SurveyAppLibrary.Models;

public partial class Preguntum
{
    public int Id { get; set; }

    public string Pregunta { get; set; }

    public int IdTipoPregunta { get; set; }

    public int IdCategoria { get; set; }

    public int IdEncuesta { get; set; }

    public virtual CategoriaPreguntum IdCategoriaNavegation { get; set; } = null!;

    public virtual Encuestum IdEncuestaNavegation { get; set; } = null!;

    public virtual TipoPreguntum IdTipoPreguntaNavegation { get; set; } = null!;

    public virtual ICollection<Respuestum> Respuesta { get; set; } = new List <Respuestum>();
}
