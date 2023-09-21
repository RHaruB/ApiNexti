using System;
using System.Collections.Generic;

namespace ApiNexti.Models;

public partial class LogEvento
{
    public int Id { get; set; }

    public int? Idevento { get; set; }

    public string? Accion { get; set; }

    public DateTime? FechaAccion { get; set; }

    public string? Usuario { get; set; }

    public virtual Evento? IdeventoNavigation { get; set; }
}
