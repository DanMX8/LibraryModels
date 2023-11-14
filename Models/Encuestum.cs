﻿using System;
using System.Collections.Generic;
using System.Data;

namespace SurveyAppLibrary.Models;

public partial class Encuestum
{
    public int Id { get; set; } 

    public string NombreEncuesta { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaExpiracion { get; set; }

    public int IdRegion { get; set; }

    public virtual Region IdRegionNavegation { get; set; } 

    public virtual ICollection<Preguntum> Pregunta { get; set; } = new List<Preguntum>();
}
