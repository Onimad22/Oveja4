using System;
using System.Collections.Generic;
using System.Text;

namespace VEPO.BLL
{
    class ProductoBLL
    {
        public int Id_producto { get; set; }
        public string Nombre_producto { get; set; }
        public double PrecioLocal_producto { get; set; }
        public double PrecioDelivery_producto { get; set; }
        public int Carne_producto { get; set; }
        public int Papa_producto { get; set; }
        public double Bono_producto { get; set; }
        public string Categoria_producto { get; set; }
    }
}
