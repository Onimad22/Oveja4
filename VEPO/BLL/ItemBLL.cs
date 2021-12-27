using System;
using System.Collections.Generic;
using System.Text;

namespace VEPO.BLL
{
    internal class ItemBLL
    {
        public int Id_item { get; set; }
        public int Cantidad_item { get; set; }
        public bool Vegetariana_item { get; set; }
        public double Total_item { get; set; }
        public double Bono_item { get; set; }
        public int Id_comandaI { get; set; }
        public int Id_productoI { get; set; }

    }
}
