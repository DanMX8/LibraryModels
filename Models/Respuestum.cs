using System;
using System.Collections.Generic;

namespace SurveyAppLibrary.Models;
public partial class Respuestum
{
    public int Id { get; set; }

    public string Respuesta { get; set; } = null!;

    public int IdPregunta { get; set; }

    public int IdUsuario { get; set; }

    public virtual Preguntum IdPreguntaNavegation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavegation { get; set; } = null!;
}
