using System;
using System.Collections.Generic;
using System.Text;

namespace VEPO.BLL
{
    internal class ComandaBLL
    {
        public int Id_comanda { get; set; }
        public string Mesa_comanda { get; set; }
        public bool Pago_comanda { get; set; }
        public bool Cerrar_comanda { get; set; }
        public bool Delivery_comanda { get; set; }
        public double Total_comanda { get; set; }
        public string Fecha_comanda { get; set; }
    }
}
