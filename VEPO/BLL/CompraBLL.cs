using System;
using System.Collections.Generic;
using System.Text;

namespace VEPO.BLL
{
    internal class CompraBLL
    {
        public int Id_compra { get; set; }
        public double Total_compra { get; set; }
        public string Fecha_compra { get; set; }
        public int Id_insumoC { get; set; }
    }
}
