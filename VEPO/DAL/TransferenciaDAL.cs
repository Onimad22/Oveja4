using System.Data;
using System.Data.SQLite;
using VEPO.BLL;

namespace VEPO.DAL
{
    class TransferenciaDAL
    {
        //ATRIBUTO DE TIPO "CONEXIONDAL" DE TAL MANERA QUE PODAMOS CREAR UN OBJETO DE ESA CLASE Y UTILIZAR LOS METODOS
        //DE ESA CLASE
        readonly conexionDAL conexion;

        //CONSTRUCTOR
        public TransferenciaDAL()
        {
            conexion = new conexionDAL(); //CREAMOS EL OBJETO
        }


        //CREAMOS EL METODO QUE SERVIRA PARA AGREGAR UN DEPARTAMENTO A LA TABLA
        public bool Agregar(TransferenciaBLL transferencia) //RECIBO UN OBJETO QUE TIENE LA INFORMACION RECOGIDA
        {
            //INGRESO EL COMANDO SQL QUE SOLICITA EL METODO "EJECUTARCOMANDO" DE LA CLASE CONEXIONDAL MEDIANTE EL OBJETO CONEXION  

            SQLiteCommand comando = new SQLiteCommand("INSERT INTO Transferencia (Total_transferencia,Fecha_transferencia) VALUES (@total,@fecha)");
            comando.Parameters.Add("@total", DbType.Double).Value = transferencia.Total_transferencia;
            comando.Parameters.Add("@fecha", DbType.String).Value = transferencia.Fecha_transferencia;

            return conexion.EjecutarComando(comando);
        }

        public bool Eliminar(TransferenciaBLL transferencia)
        {

            SQLiteCommand comando = new SQLiteCommand("DELETE FROM Transferencia WHERE Id_transferencia=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = transferencia.Id_transferencia;
            return conexion.EjecutarComando(comando);
        }

        public bool Modificar(TransferenciaBLL transferencia)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Transferencia SET Total_transferencia=@total,Fecha_transferencia=@fecha WHERE Id_transferencia=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = transferencia.Id_transferencia;
            comando.Parameters.Add("@total", DbType.Double).Value = transferencia.Total_transferencia;
            comando.Parameters.Add("@fecha", DbType.String).Value = transferencia.Fecha_transferencia;
            return conexion.EjecutarComando(comando);
        }
        public DataSet LlenarDGV()
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Id_transferencia,Total_transferencia,Fecha_transferencia FROM Transferencia");
            return conexion.EjecutarConsulta(comando);
        }

    }

}
