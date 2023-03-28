using System;
using System.Collections.Generic;

namespace AccesoDatos
{
    public class Venta
    {
        public int Id { get; set; }
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
       
        public decimal Total { get; set; }
        public List<VentaDetalle> Conceptos { get; set; } = new List<VentaDetalle>();
    }
}
