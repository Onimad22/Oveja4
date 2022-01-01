using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using VEPO.BLL;

namespace VEPO.DAL
{
    class SueldoDAL
    {
        //ATRIBUTO DE TIPO "CONEXIONDAL" DE TAL MANERA QUE PODAMOS CREAR UN OBJETO DE ESA CLASE Y UTILIZAR LOS METODOS
        //DE ESA CLASE
        readonly conexionDAL conexion;

        //CONSTRUCTOR
        public SueldoDAL()
        {
            conexion = new conexionDAL(); //CREAMOS EL OBJETO
        }


        //CREAMOS EL METODO QUE SERVIRA PARA AGREGAR UN DEPARTAMENTO A LA TABLA
        public bool Agregar(SueldoBLL sueldo) //RECIBO UN OBJETO QUE TIENE LA INFORMACION RECOGIDA
        {
            //INGRESO EL COMANDO SQL QUE SOLICITA EL METODO "EJECUTARCOMANDO" DE LA CLASE CONEXIONDAL MEDIANTE EL OBJETO CONEXION  

            SQLiteCommand comando = new SQLiteCommand("INSERT INTO Sueldo (Fecha_sueldo,Total_sueldo,Id_empleadoS) VALUES (@Fecha_sueldo,@Total_sueldo,@Id_empleadoS)");
            comando.Parameters.Add("@Fecha_sueldo", DbType.String).Value = sueldo.Fecha_sueldo;
            comando.Parameters.Add("@Total_sueldo", DbType.Double).Value = sueldo.Total_sueldo;
            comando.Parameters.Add("@Id_empleadoS", DbType.Int32).Value = sueldo.Id_empleadoS;
            return conexion.EjecutarComando(comando);
        }

        public bool Eliminar(SueldoBLL sueldo)
        {

            SQLiteCommand comando = new SQLiteCommand("DELETE FROM Sueldo WHERE Id_sueldo=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = sueldo.Id_sueldo;
            return conexion.EjecutarComando(comando);
        }

        public bool Modificar(SueldoBLL sueldo)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Sueldo SET Fecha_sueldo=@Fecha_sueldo,Total_sueldo=@Total_sueldo,Id_empleadoS=@Id_empleadoS WHERE Id_sueldo=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = sueldo.Id_sueldo;
            comando.Parameters.Add("@Fecha_sueldo", DbType.String).Value = sueldo.Fecha_sueldo;
            comando.Parameters.Add("@Total_sueldo", DbType.Double).Value = sueldo.Total_sueldo;
            comando.Parameters.Add("@Id_empleadoS", DbType.Int32).Value = sueldo.Id_empleadoS;
            return conexion.EjecutarComando(comando);
        }
        public DataSet LlenarDGV()
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Id_sueldo,Fecha_sueldo,Total_sueldo,Id_empleadoS FROM Sueldo");
            return conexion.EjecutarConsulta(comando);
        }

        public DataSet LlenarWhere(int id)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT fecha_sueldo,total_sueldo FROM Sueldo Where id_empleadoS ='" + id + "'");
            return conexion.EjecutarConsulta(comando);
        }

        public DataSet LlenarJornal(int id)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT fecha_jornal,entrada_jornal,salida_jornal,total_jornal FROM Jornal Where id_empleadoJ = '" + id + "' AND pago_jornal=false");
            return conexion.EjecutarConsulta(comando);
        }

        public DataTable CalcularSueldo(int id)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT total_jornal FROM Jornal Where id_empleadoJ = '" + id + "' AND pago_jornal=false");
            return conexion.EjecutarDT(comando);
        }

        public bool ModificarPago(JornalBLL jornal)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Jornal SET Pago_jornal=@Pago_jornal WHERE Id_jornal=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = jornal.Id_jornal;
            comando.Parameters.Add("@Pago_jornal", DbType.Boolean).Value = true;
            return conexion.EjecutarComando(comando);
        }

        public DataTable JornalesaPagar(int id)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT id_jornal,pago_jornal FROM Jornal Where id_empleadoJ = '" + id + "' AND pago_jornal=false");
            return conexion.EjecutarDT(comando);
        }

        public DataTable CalcularTotal(string fecha)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT total_sueldo FROM Sueldo Where fecha_sueldo ='" + fecha + "'");
            return conexion.EjecutarDT(comando);
        }

    }


}
