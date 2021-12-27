using System;
using System.Collections.Generic;
using System.Text;

namespace VEPO.BLL
{
    internal class JornalBLL
    {
        public int Id_jornal { get; set; }
        public string Fecha_jornal { get; set; }
        public string Entrada_jornal { get; set; }
        public string Salida_jornal { get; set; }
        public double Bono_jornal { get; set; }
        public double Total_jornal { get; set; }
        public bool Pago_jornal { get; set; }
        public int Id_empleadoJ { get; set; }
    }
}
