using System;
using System.Collections.Generic;

namespace ApiNexti.Models;

public partial class Evento
{
    public int Id { get; set; }

    public DateTime? FechaEvento { get; set; }

    public string? LugarEvento { get; set; }

    public int? NumEntradas { get; set; }

    public string? DescripcionEvento { get; set; }

    public decimal? Precio { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public bool? Eliminado { get; set; }

    public virtual ICollection<LogEvento> LogEventos { get; set; } = new List<LogEvento>();
}
