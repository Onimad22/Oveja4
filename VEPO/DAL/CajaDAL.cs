using System.Data;
using System.Data.SQLite;
using VEPO.BLL;

namespace VEPO.DAL
{
    class CajaDAL
    {
        //ATRIBUTO DE TIPO "CONEXIONDAL" DE TAL MANERA QUE PODAMOS CREAR UN OBJETO DE ESA CLASE Y UTILIZAR LOS METODOS
        //DE ESA CLASE
        readonly conexionDAL conexion;

        //CONSTRUCTOR
        public CajaDAL()
        {
            conexion = new conexionDAL(); //CREAMOS EL OBJETO
        }


        //CREAMOS EL METODO QUE SERVIRA PARA AGREGAR UN DEPARTAMENTO A LA TABLA
        public bool Agregar(CajaBLL caja) //RECIBO UN OBJETO QUE TIENE LA INFORMACION RECOGIDA
        {
            //INGRESO EL COMANDO SQL QUE SOLICITA EL METODO "EJECUTARCOMANDO" DE LA CLASE CONEXIONDAL MEDIANTE EL OBJETO CONEXION  

            SQLiteCommand comando = new SQLiteCommand("INSERT INTO Caja (DiezC_caja,VeinteC_caja,CincuentaC_caja,UnB_caja,DosB_caja,CincoB_caja,DiezB_caja,VeinteB_caja,CincuentaB_caja,CienB_caja,DoscientosB_caja,Total_caja,Fecha_caja) VALUES (@DiezC_caja,@VeinteC_caja,@CincuentaC_caja,@UnB_caja,@DosB_caja,@CincoB_caja,@DiezB_caja,@VeinteB_caja,@CincuentaB_caja,@CienB_caja,@DoscientosB_caja,@Total_caja,@Fecha_caja)");
            comando.Parameters.Add("@DiezC_caja", DbType.Int32).Value = caja.DiezC_caja;
            comando.Parameters.Add("@VeinteC_caja", DbType.Int32).Value = caja.VeinteC_caja;
            comando.Parameters.Add("@CincuentaC_caja", DbType.Int32).Value = caja.CincuentaC_caja;
            comando.Parameters.Add("@UnB_caja", DbType.Int32).Value = caja.UnB_caja;
            comando.Parameters.Add("@DosB_caja", DbType.Int32).Value = caja.DosB_caja;
            comando.Parameters.Add("@CincoB_caja", DbType.Int32).Value = caja.CincoB_caja;
            comando.Parameters.Add("@DiezB_caja", DbType.Int32).Value = caja.DiezB_caja;
            comando.Parameters.Add("@VeinteB_caja", DbType.Int32).Value = caja.VeinteB_caja;
            comando.Parameters.Add("@CincuentaB_caja", DbType.Int32).Value = caja.CincuentaB_caja;
            comando.Parameters.Add("@CienB_caja", DbType.Int32).Value = caja.CienB_caja;
            comando.Parameters.Add("@DoscientosB_caja", DbType.Int32).Value = caja.DoscientosB_caja;
            comando.Parameters.Add("@Total_caja", DbType.Double).Value = caja.Total_caja;
            comando.Parameters.Add("@Fecha_caja", DbType.String).Value = caja.Fecha_caja;

            return conexion.EjecutarComando(comando);
        }

        public bool Eliminar(CajaBLL caja)
        {

            SQLiteCommand comando = new SQLiteCommand("DELETE FROM Caja WHERE Id_caja=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = caja.ID_caja;
            return conexion.EjecutarComando(comando);
        }

        public bool Modificar(CajaBLL caja)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Caja SET DiezC_caja=@DiezC_caja,VeinteC_caja=@VeinteC_caja,CincuentaC_caja=@CincuentaC_caja,UnB_caja=@UnB_caja,DosB_caja=@DosB_caja,CincoB_caja=@CincoB_caja,DiezB_caja=@DiezB_caja,VeinteB_caja=@VeinteB_caja,CincuentaB_caja=@CincuentaB_caja,CienB_caja=@CienB_caja,DoscientosB_caja=@DoscientosB_caja,Total_caja=@Total_caja,Fecha_caja=@Fecha_caja WHERE Id_caja=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = caja.ID_caja;
            comando.Parameters.Add("@DiezC_caja", DbType.Int32).Value = caja.DiezC_caja;
            comando.Parameters.Add("@VeinteC_caja", DbType.Int32).Value = caja.VeinteC_caja;
            comando.Parameters.Add("@CincuentaC_caja", DbType.Int32).Value = caja.CincuentaC_caja;
            comando.Parameters.Add("@UnB_caja", DbType.Int32).Value = caja.UnB_caja;
            comando.Parameters.Add("@DosB_caja", DbType.Int32).Value = caja.DosB_caja;
            comando.Parameters.Add("@CincoB_caja", DbType.Int32).Value = caja.CincoB_caja;
            comando.Parameters.Add("@DiezB_caja", DbType.Int32).Value = caja.DiezB_caja;
            comando.Parameters.Add("@VeinteB_caja", DbType.Int32).Value = caja.VeinteB_caja;
            comando.Parameters.Add("@CincuentaB_caja", DbType.Int32).Value = caja.CincuentaB_caja;
            comando.Parameters.Add("@CienB_caja", DbType.Int32).Value = caja.CienB_caja;
            comando.Parameters.Add("@DoscientosB_caja", DbType.Int32).Value = caja.DoscientosB_caja;
            comando.Parameters.Add("@Total_caja", DbType.Double).Value = caja.Total_caja;
            comando.Parameters.Add("@Fecha_caja", DbType.String).Value = caja.Fecha_caja;
            return conexion.EjecutarComando(comando);
        }
        public DataSet LlenarDGV()
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Id_caja,DiezC_caja,VeinteC_caja,CincuentaC_caja,UnB_caja,DosB_caja,CincoB_caja,DiezB_caja,VeinteB_caja,CincuentaB_caja,CienB_caja,DoscientosB_caja,Total_caja,Fecha_caja FROM Caja");
            return conexion.EjecutarConsulta(comando);
        }

        public DataTable CalcularTotal(string fecha)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT total_caja FROM Caja Where fecha_caja ='" + fecha + "'");
            return conexion.EjecutarDT(comando);
        }

        public DataSet LlenarWhereFecha(string fecha)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Id_caja,DiezC_caja,VeinteC_caja,CincuentaC_caja,UnB_caja,DosB_caja,CincoB_caja,DiezB_caja,VeinteB_caja,CincuentaB_caja,CienB_caja,DoscientosB_caja,Total_caja FROM Caja Where fecha_caja ='" + fecha + "'");
            return conexion.EjecutarConsulta(comando);
        }

        internal DataTable CajaDT(string fecha)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Id_caja,DiezC_caja,VeinteC_caja,CincuentaC_caja,UnB_caja,DosB_caja,CincoB_caja,DiezB_caja,VeinteB_caja,CincuentaB_caja,CienB_caja,DoscientosB_caja,Total_caja FROM Caja Where fecha_caja ='" + fecha + "'");
            return conexion.EjecutarDT(comando);

        }

    }

}
