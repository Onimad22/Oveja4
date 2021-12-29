using System.Data;
using System.Data.SQLite;

namespace VEPO.DAL
{
    class conexionDAL
    {
        //string CadenaConexion = "Data Source=C:\\Users\\Angel\\Desktop\\Programacion\\DBsqlite\\VEPO.db";
        //string CadenaConexion = "Data Source=C:\\VEPO\\VEPO.db";
        string CadenaConexion = "Data Source=.\\ovejaDB.db;Version=3";
        SQLiteConnection Conexion;

        public SQLiteConnection EstablecerConexion()
        {
            Conexion = new SQLiteConnection(CadenaConexion);
            return Conexion;

        }

        public bool EjecutarComando(SQLiteCommand sqlcomando)
        {
            try
            {

                SQLiteCommand Comando = sqlcomando;//AGREGAMOS EL VALOR SQLCOMMAND QUE RECIBIMOS COMO PARAMETRO A LA VARIABLE

                Comando.Connection = EstablecerConexion();//LE ASIGNAMOS EL RETURN DE "ESTABLECERCONEXION"
                Conexion.Open();//ABRIMOS LA CONEXION
                Comando.ExecuteNonQuery();//EJECUTAMOS EL COMANDO SQL INGRESADO EN EL OBJETO "COMANDO"
                Conexion.Close();//CERRAMOS LA CONEXION

                return true;
            }

            catch
            {
                return false;

            }
        }

        public DataSet EjecutarConsulta(SQLiteCommand sqlcomando)
        {
            DataSet DS = new DataSet();
            SQLiteDataAdapter Adaptador = new SQLiteDataAdapter();

            try
            {
                sqlcomando.Connection = EstablecerConexion();
                Adaptador.SelectCommand = sqlcomando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                return DS;
            }
            catch
            {
                return DS;
            }

        }

        public DataTable EjecutarDT(SQLiteCommand sqlcomando)
        {
            DataTable DT = new DataTable();
            SQLiteDataAdapter Adaptador = new SQLiteDataAdapter();

            try
            {
                sqlcomando.Connection = EstablecerConexion();
                Adaptador.SelectCommand = sqlcomando;
                Conexion.Open();
                Adaptador.Fill(DT);
                Conexion.Close();
                return DT;
            }
            catch
            {
                return DT;
            }
        }
    }

}