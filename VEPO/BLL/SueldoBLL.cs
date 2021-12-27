using System;
using System.Collections.Generic;
using System.Text;

namespace VEPO.BLL
{
    internal class SueldoBLL
    {
        public int Id_sueldo { get; set; }
        public string Fecha_sueldo { get; set; }
        public double Total_sueldo { get; set; }
        public int Id_empleadoS { get; set; }
    }
}
