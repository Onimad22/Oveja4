using System.Data;
using System.Data.SQLite;
using VEPO.BLL;

namespace VEPO.DAL
{
    class InsumoDAL
    {
        //ATRIBUTO DE TIPO "CONEXIONDAL" DE TAL MANERA QUE PODAMOS CREAR UN OBJETO DE ESA CLASE Y UTILIZAR LOS METODOS
        //DE ESA CLASE
        readonly conexionDAL conexion;

        //CONSTRUCTOR
        public InsumoDAL()
        {
            conexion = new conexionDAL(); //CREAMOS EL OBJETO
        }


        //CREAMOS EL METODO QUE SERVIRA PARA AGREGAR UN DEPARTAMENTO A LA TABLA
        public bool Agregar(InsumoBLL insumo) //RECIBO UN OBJETO QUE TIENE LA INFORMACION RECOGIDA
        {
            //INGRESO EL COMANDO SQL QUE SOLICITA EL METODO "EJECUTARCOMANDO" DE LA CLASE CONEXIONDAL MEDIANTE EL OBJETO CONEXION  

            SQLiteCommand comando = new SQLiteCommand("INSERT INTO Insumo (nombre_insumo,categoria_insumo) VALUES (@nombre,@categoria)");
            comando.Parameters.Add("@nombre", DbType.String).Value = insumo.Nombre_insumo;
            comando.Parameters.Add("@categoria", DbType.String).Value = insumo.Categoria_insumo;

            return conexion.EjecutarComando(comando);
        }

        public bool Eliminar(InsumoBLL insumo)
        {

            SQLiteCommand comando = new SQLiteCommand("DELETE FROM Insumo WHERE Id_insumo=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = insumo.Id_insumo;
            return conexion.EjecutarComando(comando);
        }

        public bool Modificar(InsumoBLL insumo)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Insumo SET Nombre_insumo=@nombre,Categoria_insumo=@categoria WHERE Id_insumo=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = insumo.Id_insumo;
            comando.Parameters.Add("@nombre", DbType.String).Value = insumo.Nombre_insumo;
            comando.Parameters.Add("@categoria", DbType.String).Value = insumo.Categoria_insumo;
            return conexion.EjecutarComando(comando);
        }
        public DataSet LlenarDGV()
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Id_insumo,Nombre_insumo,Categoria_insumo FROM Insumo");
            return conexion.EjecutarConsulta(comando);
        }

    }

}
