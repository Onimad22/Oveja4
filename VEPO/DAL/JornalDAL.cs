using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using VEPO.BLL;

namespace VEPO.DAL
{
    class JornalDAL
    {
        //ATRIBUTO DE TIPO "CONEXIONDAL" DE TAL MANERA QUE PODAMOS CREAR UN OBJETO DE ESA CLASE Y UTILIZAR LOS METODOS
        //DE ESA CLASE
        readonly conexionDAL conexion;

        //CONSTRUCTOR
        public JornalDAL()
        {
            conexion = new conexionDAL(); //CREAMOS EL OBJETO
        }


        //CREAMOS EL METODO QUE SERVIRA PARA AGREGAR UN DEPARTAMENTO A LA TABLA
        public bool Agregar(JornalBLL jornal) //RECIBO UN OBJETO QUE TIENE LA INFORMACION RECOGIDA
        {
            //INGRESO EL COMANDO SQL QUE SOLICITA EL METODO "EJECUTARCOMANDO" DE LA CLASE CONEXIONDAL MEDIANTE EL OBJETO CONEXION  

            SQLiteCommand comando = new SQLiteCommand("INSERT INTO Jornal (Fecha_jornal,Entrada_jornal,Salida_jornal,Bono_jornal,Total_jornal,Pago_jornal,Id_empleadoJ) VALUES (@Fecha_jornal,@Entrada_jornal,@Salida_jornal,@Bono_jornal,@Total_jornal,@Pago_jornal,@Id_empleadoJ)");
            comando.Parameters.Add("@Fecha_jornal", DbType.String).Value = jornal.Fecha_jornal;
            comando.Parameters.Add("@Entrada_jornal", DbType.String).Value = jornal.Entrada_jornal;
            comando.Parameters.Add("@Salida_jornal", DbType.String).Value = jornal.Salida_jornal;
            comando.Parameters.Add("@Bono_jornal", DbType.Double).Value = jornal.Bono_jornal;
            comando.Parameters.Add("@Total_jornal", DbType.Double).Value = jornal.Total_jornal;
            comando.Parameters.Add("@Pago_jornal", DbType.Boolean).Value = jornal.Pago_jornal;
            comando.Parameters.Add("@Id_empleadoJ", DbType.Int32).Value = jornal.Id_empleadoJ;

            return conexion.EjecutarComando(comando);
        }

        public bool Eliminar(JornalBLL jornal)
        {

            SQLiteCommand comando = new SQLiteCommand("DELETE FROM Jornal WHERE Id_jornal=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = jornal.Id_jornal;
            return conexion.EjecutarComando(comando);
        }

        public bool Modificar(JornalBLL jornal)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Jornal SET Fecha_jornal=@Fecha_jornal,Entrada_jornal=@Entrada_jornal,Salida_jornal=@Salida_jornal,Bono_jornal=@Bono_jornal,Total_jornal=@Total_jornal,Id_empleadoJ=@Id_empleadoJ WHERE Id_jornal=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = jornal.Id_jornal;
            comando.Parameters.Add("@Fecha_jornal", DbType.String).Value = jornal.Fecha_jornal;
            comando.Parameters.Add("@Entrada_jornal", DbType.String).Value = jornal.Entrada_jornal;
            comando.Parameters.Add("@Salida_jornal", DbType.String).Value = jornal.Salida_jornal;
            comando.Parameters.Add("@Bono_jornal", DbType.Double).Value = jornal.Bono_jornal;
            comando.Parameters.Add("@Total_jornal", DbType.Double).Value = jornal.Total_jornal;
            comando.Parameters.Add("@Id_empleadoJ", DbType.Int32).Value = jornal.Id_empleadoJ;
            return conexion.EjecutarComando(comando);
        }
        public DataSet LlenarDGV()
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Id_jornal,Fecha_jornal,Entrada_jornal,Salida_jornal,Bono_jornal,Total_jornal,Pago_jornal,Id_empleadoJ FROM Jornal");
            return conexion.EjecutarConsulta(comando);
        }

        public DataSet LlenarWhereFecha(string fecha)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT nombre_empleado,Id_jornal,Fecha_jornal,Entrada_jornal,Salida_jornal,Bono_jornal,Total_jornal,Id_empleadoJ FROM Jornal INNER JOIN Empleado ON id_empleadoJ=Empleado.id_empleado Where fecha_jornal ='" + fecha + "'");
            return conexion.EjecutarConsulta(comando);
        }

        public DataTable CalcularBono(string fecha)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Bono_item FROM Item INNER JOIN Comanda ON id_comandaI=Comanda.id_comanda Where fecha_comanda ='" + fecha + "'");
            return conexion.EjecutarDT(comando);
        }

        public DataTable CalcularJornal(int id)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT convenio_empleado FROM Empleado Where id_empleado = '" + id + "'");
            return conexion.EjecutarDT(comando);
        }

       

    }


}
