using System;
using System.Collections.Generic;

namespace SistemaAcademico.Persistence.Models;

public partial class CuentaPorPagar
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public bool Pagada { get; set; }

    public string Tipo { get; set; } = null!;

    public decimal CantidadTotal { get; set; }

    public decimal CantidadRestante { get; set; }

    public decimal Descuento { get; set; }

    public int IdUsuario { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
