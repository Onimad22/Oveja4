using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using VEPO.BLL;

namespace VEPO.DAL
{
    class ComandaDAL
    {
        //ATRIBUTO DE TIPO "CONEXIONDAL" DE TAL MANERA QUE PODAMOS CREAR UN OBJETO DE ESA CLASE Y UTILIZAR LOS METODOS
        //DE ESA CLASE
        readonly conexionDAL conexion;

        //CONSTRUCTOR
        public ComandaDAL()
        {
            conexion = new conexionDAL(); //CREAMOS EL OBJETO
        }


        //CREAMOS EL METODO QUE SERVIRA PARA AGREGAR UN DEPARTAMENTO A LA TABLA
        public bool Agregar(ComandaBLL comanda) //RECIBO UN OBJETO QUE TIENE LA INFORMACION RECOGIDA
        {
            //INGRESO EL COMANDO SQL QUE SOLICITA EL METODO "EJECUTARCOMANDO" DE LA CLASE CONEXIONDAL MEDIANTE EL OBJETO CONEXION  

            SQLiteCommand comando = new SQLiteCommand("INSERT INTO Comanda (Mesa_comanda,Pago_comanda,Cerrar_comanda,Delivery_comanda,Total_comanda,Fecha_comanda) VALUES (@Mesa_comanda,@Pago_comanda,@Cerrar_comanda,@Delivery_comanda,@Total_comanda,@Fecha_comanda)");
            comando.Parameters.Add("@Mesa_comanda", DbType.String).Value = comanda.Mesa_comanda;
            comando.Parameters.Add("@Pago_comanda", DbType.Boolean).Value = comanda.Pago_comanda;
            comando.Parameters.Add("@Cerrar_comanda", DbType.Boolean).Value = comanda.Cerrar_comanda;
            comando.Parameters.Add("@Delivery_comanda", DbType.Boolean).Value = comanda.Delivery_comanda;
            comando.Parameters.Add("@Total_comanda", DbType.Double).Value = comanda.Total_comanda;
            comando.Parameters.Add("@Fecha_comanda", DbType.String).Value = comanda.Fecha_comanda;

            return conexion.EjecutarComando(comando);
        }

        public bool Eliminar(ComandaBLL comanda)
        {

            SQLiteCommand comando = new SQLiteCommand("DELETE FROM Comanda WHERE Id_comanda=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = comanda.Id_comanda;
            return conexion.EjecutarComando(comando);
        }

        public bool EliminarComanda(int id)
        {

            SQLiteCommand comando = new SQLiteCommand("DELETE FROM Comanda WHERE Id_comanda='"+id+"'");
            return conexion.EjecutarComando(comando);
        }

        internal DataTable CalcularPrecio(int id)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT PrecioLocal_producto,PrecioDelivery_producto,bono_producto FROM Producto Where id_producto = '" + id + "'");
            return conexion.EjecutarDT(comando);

        }

        public bool Modificar(ComandaBLL comanda)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Comanda SET Mesa_comanda=@Mesa_comanda,Pago_comanda=@Pago_comanda,Cerrar_comanda=@Cerrar_comanda,Delivery_comanda=@Delivery_comanda,Total_comanda=@Total_comanda,Fecha_comanda=@Fecha_comanda WHERE Id_comanda=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = comanda.Id_comanda;
            comando.Parameters.Add("@Mesa_comanda", DbType.String).Value = comanda.Mesa_comanda;
            comando.Parameters.Add("@Pago_comanda", DbType.Boolean).Value = comanda.Pago_comanda;
            comando.Parameters.Add("@Cerrar_comanda", DbType.Boolean).Value = comanda.Cerrar_comanda;
            comando.Parameters.Add("@Delivery_comanda", DbType.Boolean).Value = comanda.Delivery_comanda;
            comando.Parameters.Add("@Total_comanda", DbType.Double).Value = comanda.Total_comanda;
            comando.Parameters.Add("@Fecha_comanda", DbType.String).Value = comanda.Fecha_comanda;
            return conexion.EjecutarComando(comando);
        }

        public bool ModificarTotal(ComandaBLL comanda)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Comanda SET Total_comanda=@Total_comanda WHERE Id_comanda=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = comanda.Id_comanda;
            comando.Parameters.Add("@Total_comanda", DbType.Double).Value = comanda.Total_comanda;
            return conexion.EjecutarComando(comando);
        }


        public DataSet LlenarDGVa(string fecha)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Id_comanda,Mesa_comanda,Pago_comanda,Cerrar_comanda,Delivery_comanda,Total_comanda,Fecha_comanda FROM Comanda WHERE cerrar_comanda=0 AND fecha_comanda='"+fecha+"'");
            return conexion.EjecutarConsulta(comando);
        }

        public DataSet LlenarDGVc(string fecha)
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Id_comanda,Mesa_comanda,Pago_comanda,Cerrar_comanda,Delivery_comanda,Total_comanda,Fecha_comanda FROM Comanda WHERE cerrar_comanda=1 AND fecha_comanda='" + fecha + "'");
            return conexion.EjecutarConsulta(comando);
        }

        public DataTable UltimoId()
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT * FROM Comanda WHERE id_comanda = (SELECT MAX(id_comanda) FROM Comanda)");
            return conexion.EjecutarDT(comando);
        }

        public bool ModificarPago(ComandaBLL comanda)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Comanda SET Pago_comanda=@Pago_jornal WHERE Id_comanda=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = comanda.Id_comanda;
            comando.Parameters.Add("@Pago_jornal", DbType.Boolean).Value = comanda.Pago_comanda;
            return conexion.EjecutarComando(comando);
        }

        public bool ModificarCerrar(ComandaBLL comanda)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Comanda SET cerrar_comanda=@cerrar_jornal WHERE Id_comanda=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = comanda.Id_comanda;
            comando.Parameters.Add("@cerrar_jornal", DbType.Boolean).Value = comanda.Cerrar_comanda;
            return conexion.EjecutarComando(comando);
        }

    }
}
