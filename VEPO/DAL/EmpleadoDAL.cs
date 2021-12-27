using System.Data;
using System.Data.SQLite;
using VEPO.BLL;

namespace VEPO.DAL
{
    class EmpleadoDAL
    {
        //ATRIBUTO DE TIPO "CONEXIONDAL" DE TAL MANERA QUE PODAMOS CREAR UN OBJETO DE ESA CLASE Y UTILIZAR LOS METODOS
        //DE ESA CLASE
        readonly conexionDAL conexion;

        //CONSTRUCTOR
        public EmpleadoDAL()
        {
            conexion = new conexionDAL(); //CREAMOS EL OBJETO
        }


        //CREAMOS EL METODO QUE SERVIRA PARA AGREGAR UN DEPARTAMENTO A LA TABLA
        public bool Agregar(EmpleadoBLL empleado) //RECIBO UN OBJETO QUE TIENE LA INFORMACION RECOGIDA
        {
            //INGRESO EL COMANDO SQL QUE SOLICITA EL METODO "EJECUTARCOMANDO" DE LA CLASE CONEXIONDAL MEDIANTE EL OBJETO CONEXION  

            SQLiteCommand comando = new SQLiteCommand("INSERT INTO Empleado (nombre_empleado,convenio_empleado) VALUES (@nombre,@convenio)");
            comando.Parameters.Add("@nombre", DbType.String).Value = empleado.Nombre_empleado;
            comando.Parameters.Add("@convenio", DbType.Double).Value = empleado.Convenio_empleado;

            return conexion.EjecutarComando(comando);
        }

        public bool Eliminar(EmpleadoBLL empleado)
        {

            SQLiteCommand comando = new SQLiteCommand("DELETE FROM Empleado WHERE Id_empleado=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = empleado.Id_empleado;
            return conexion.EjecutarComando(comando);
        }

        public bool Modificar(EmpleadoBLL empleado)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Empleado SET Nombre_empleado=@nombre,Convenio_empleado=@convenio WHERE Id_empleado=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = empleado.Id_empleado;
            comando.Parameters.Add("@nombre", DbType.String).Value = empleado.Nombre_empleado;
            comando.Parameters.Add("@categoria", DbType.Double).Value = empleado.Convenio_empleado;
            return conexion.EjecutarComando(comando);
        }
        public DataSet LlenarDGV()
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Id_empleado,Nombre_empleado,Convenio_empleado FROM Empleado");
            return conexion.EjecutarConsulta(comando);
        }

    }

}
