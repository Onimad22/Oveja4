using System.Data;
using System.Data.SQLite;
using VEPO.BLL;

namespace VEPO.DAL
{
    class CompraDAL
    {
        //ATRIBUTO DE TIPO "CONEXIONDAL" DE TAL MANERA QUE PODAMOS CREAR UN OBJETO DE ESA CLASE Y UTILIZAR LOS METODOS
        //DE ESA CLASE
        readonly conexionDAL conexion;

        //CONSTRUCTOR
        public CompraDAL()
        {
            conexion = new conexionDAL(); //CREAMOS EL OBJETO
        }


        //CREAMOS EL METODO QUE SERVIRA PARA AGREGAR UN DEPARTAMENTO A LA TABLA
        public bool Agregar(CompraBLL compra) //RECIBO UN OBJETO QUE TIENE LA INFORMACION RECOGIDA
        {
            //INGRESO EL COMANDO SQL QUE SOLICITA EL METODO "EJECUTARCOMANDO" DE LA CLASE CONEXIONDAL MEDIANTE EL OBJETO CONEXION  

            SQLiteCommand comando = new SQLiteCommand("INSERT INTO Compra (Total_compra,Fecha_compra,Id_insumoC) VALUES (@Total_compra,@Fecha_compra,@Id_insumoC)");
            comando.Parameters.Add("@Total_compra", DbType.Double).Value = compra.Total_compra;
            comando.Parameters.Add("@Fecha_compra", DbType.String).Value = compra.Fecha_compra;
            comando.Parameters.Add("@Id_insumoC", DbType.Int32).Value = compra.Id_insumoC;
            return conexion.EjecutarComando(comando);
        }

        public bool Eliminar(CompraBLL compra)
        {

            SQLiteCommand comando = new SQLiteCommand("DELETE FROM Compra WHERE Id_compra=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = compra.Id_compra;
            return conexion.EjecutarComando(comando);
        }

        public bool Modificar(CompraBLL compra)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Compra SET Total_compra=@Total_compra,Fecha_compra=@Fecha_compra,Id_insumoC=@Id_insumoC WHERE Id_compra=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = compra.Id_compra;
            comando.Parameters.Add("@Total_compra", DbType.Double).Value = compra.Total_compra;
            comando.Parameters.Add("@Fecha_compra", DbType.String).Value = compra.Fecha_compra;
            comando.Parameters.Add("@Id_insumoC", DbType.Int32).Value = compra.Id_insumoC;
            return conexion.EjecutarComando(comando);
        }
        public DataSet LlenarDGV()
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Id_compra,Total_compra,Fecha_compra,Id_insumoC FROM Compra");
            return conexion.EjecutarConsulta(comando);
        }

        public DataSet LlenarWhereFecha(string fecha)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT nombre_insumo,Id_compra,Total_compra,Fecha_compra,Id_insumoC FROM Compra INNER JOIN Insumo ON id_insumoC=Insumo.id_insumo Where fecha_compra ='" + fecha + "'");
            return conexion.EjecutarConsulta(comando);
        }

        public DataTable CalcularTotal(string fecha)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT total_compra FROM Compra Where fecha_compra ='" + fecha + "'");
            return conexion.EjecutarDT(comando);
        }

    }
}
