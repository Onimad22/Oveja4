using System.Data;
using System.Data.SQLite;
using VEPO.BLL;

namespace VEPO.DAL
{
    class ProductoDAL
    {
        //ATRIBUTO DE TIPO "CONEXIONDAL" DE TAL MANERA QUE PODAMOS CREAR UN OBJETO DE ESA CLASE Y UTILIZAR LOS METODOS
        //DE ESA CLASE
        readonly conexionDAL conexion;

        //CONSTRUCTOR
        public ProductoDAL()
        {
            conexion = new conexionDAL(); //CREAMOS EL OBJETO
        }


        //CREAMOS EL METODO QUE SERVIRA PARA AGREGAR UN DEPARTAMENTO A LA TABLA
        public bool Agregar(ProductoBLL producto) //RECIBO UN OBJETO QUE TIENE LA INFORMACION RECOGIDA
        {
            //INGRESO EL COMANDO SQL QUE SOLICITA EL METODO "EJECUTARCOMANDO" DE LA CLASE CONEXIONDAL MEDIANTE EL OBJETO CONEXION  

            SQLiteCommand comando = new SQLiteCommand("INSERT INTO Producto (nombre_producto,PrecioLocal_producto,PrecioDelivery_producto,Carne_producto,Papa_producto,Bono_producto,Categoria_producto) VALUES (@nombre_producto,@PrecioLocal_producto,@PrecioDelivery_producto,@Carne_producto,@Papa_producto,@Bono_producto,@Categoria_producto)");
            comando.Parameters.Add("@nombre_producto", DbType.String).Value = producto.Nombre_producto;
            comando.Parameters.Add("@PrecioLocal_producto", DbType.Double).Value = producto.PrecioLocal_producto;
            comando.Parameters.Add("@PrecioDelivery_producto", DbType.Double).Value = producto.PrecioDelivery_producto;
            comando.Parameters.Add("@Carne_producto", DbType.Int32).Value = producto.Carne_producto;
            comando.Parameters.Add("@Papa_producto", DbType.Int32).Value = producto.Papa_producto;
            comando.Parameters.Add("@Bono_producto", DbType.Double).Value = producto.Bono_producto;
            comando.Parameters.Add("@Categoria_producto", DbType.String).Value = producto.Categoria_producto;

            return conexion.EjecutarComando(comando);
        }

        public bool Eliminar(ProductoBLL producto)
        {

            SQLiteCommand comando = new SQLiteCommand("DELETE FROM Producto WHERE Id_producto=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = producto.Id_producto;
            return conexion.EjecutarComando(comando);
        }

        public bool Modificar(ProductoBLL producto)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Producto SET nombre_producto=@nombre_producto,PrecioLocal_producto=@PrecioLocal_producto,PrecioDelivery_producto=@PrecioDelivery_producto,Carne_producto=@Carne_producto,Papa_producto=@Papa_producto,Bono_producto=@Bono_producto,Categoria_producto=@Categoria_producto WHERE Id_producto=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = producto.Id_producto;
            comando.Parameters.Add("@nombre_producto", DbType.String).Value = producto.Nombre_producto;
            comando.Parameters.Add("@PrecioLocal_producto", DbType.Double).Value = producto.PrecioLocal_producto;
            comando.Parameters.Add("@PrecioDelivery_producto", DbType.Double).Value = producto.PrecioDelivery_producto;
            comando.Parameters.Add("@Carne_producto", DbType.Int32).Value = producto.Carne_producto;
            comando.Parameters.Add("@Papa_producto", DbType.Int32).Value = producto.Papa_producto;
            comando.Parameters.Add("@Bono_producto", DbType.Double).Value = producto.Bono_producto;
            comando.Parameters.Add("@Categoria_producto", DbType.String).Value = producto.Categoria_producto;
            return conexion.EjecutarComando(comando);
        }
        public DataSet LlenarDGV()
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Id_producto,nombre_producto,PrecioLocal_producto,PrecioDelivery_producto,Carne_producto,Papa_producto,Bono_producto,Categoria_producto FROM Producto");
            return conexion.EjecutarConsulta(comando);
        }

    }
}
