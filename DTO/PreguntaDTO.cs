using SurveyAppLibrary.Models;
using System;
using System.Collections.Generic;


namespace SurveyAppLibrary.DTO
{
    public class PreguntaDTO
    {
        public string Pregunta { get; set; } = null!;
        public int IdTipoPregunta { get; set; }
        public int IdCategoria { get; set; }
        public int IdEncuesta { get; set; }
        public static PreguntaDTO PreguntaToDTO(Preguntum pregunta) =>
        new PreguntaDTO
        {
            Pregunta = pregunta.Pregunta,
            IdTipoPregunta = pregunta.IdTipoPregunta,
            IdCategoria = pregunta.IdCategoria,
            IdEncuesta = pregunta.IdEncuesta
        };
    }
}
