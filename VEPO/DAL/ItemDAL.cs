using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using VEPO.BLL;

namespace VEPO.DAL
{
    class ItemDAL
    {
        //ATRIBUTO DE TIPO "CONEXIONDAL" DE TAL MANERA QUE PODAMOS CREAR UN OBJETO DE ESA CLASE Y UTILIZAR LOS METODOS
        //DE ESA CLASE
        readonly conexionDAL conexion;

        //CONSTRUCTOR
        public ItemDAL()
        {
            conexion = new conexionDAL(); //CREAMOS EL OBJETO
        }


        //CREAMOS EL METODO QUE SERVIRA PARA AGREGAR UN DEPARTAMENTO A LA TABLA
        public bool Agregar(ItemBLL item) //RECIBO UN OBJETO QUE TIENE LA INFORMACION RECOGIDA
        {
            //INGRESO EL COMANDO SQL QUE SOLICITA EL METODO "EJECUTARCOMANDO" DE LA CLASE CONEXIONDAL MEDIANTE EL OBJETO CONEXION  

            SQLiteCommand comando = new SQLiteCommand("INSERT INTO Item (Cantidad_item,Vegetariana_item,Total_item,Bono_item,Id_comandaI,Id_productoI) VALUES (@Cantidad_item,@Vegetariana_item,@Total_item,@Bono_item,@Id_comandaI,@Id_productoI)");
            comando.Parameters.Add("@Cantidad_item", DbType.Int32).Value = item.Cantidad_item;
            comando.Parameters.Add("@Vegetariana_item", DbType.Boolean).Value = item.Vegetariana_item;
            comando.Parameters.Add("@Total_item", DbType.Double).Value = item.Total_item;
            comando.Parameters.Add("@Bono_item", DbType.Double).Value = item.Bono_item;
            comando.Parameters.Add("@Id_comandaI", DbType.Int32).Value = item.Id_comandaI;
            comando.Parameters.Add("@Id_productoI", DbType.Int32).Value = item.Id_productoI;

            return conexion.EjecutarComando(comando);
        }

        public bool Eliminar(ItemBLL item)
        {

            SQLiteCommand comando = new SQLiteCommand("DELETE FROM Item WHERE Id_item=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = item.Id_item;
            return conexion.EjecutarComando(comando);
        }

        public bool Modificar(ItemBLL item)
        {

            SQLiteCommand comando = new SQLiteCommand("UPDATE Item SET Cantidad_item=@Cantidad_item,Vegetariana_item=@Vegetariana_item,Total_item=@Total_item,Bono_item=@Bono_item,Id_comandaI=@Id_comandaI,Id_productoI=@Id_productoI WHERE Id_item=@Id");
            comando.Parameters.Add("@Id", DbType.Int32).Value = item.Id_item;
            comando.Parameters.Add("@Cantidad_item", DbType.Int32).Value = item.Cantidad_item;
            comando.Parameters.Add("@Vegetariana_item", DbType.Boolean).Value = item.Vegetariana_item;
            comando.Parameters.Add("@Total_item", DbType.Double).Value = item.Total_item;
            comando.Parameters.Add("@Bono_item", DbType.Double).Value = item.Bono_item;
            comando.Parameters.Add("@Id_comandaI", DbType.Int32).Value = item.Id_comandaI;
            comando.Parameters.Add("@Id_productoI", DbType.Int32).Value = item.Id_productoI;
            return conexion.EjecutarComando(comando);
        }
        public DataSet LlenarDGV()
        {
            SQLiteCommand comando = new SQLiteCommand("SELECT Id_item,Cantidad_item,Vegetariana_item,Total_item,Bono_item,Id_comandaI,Id_productoI FROM Item");
            return conexion.EjecutarConsulta(comando);
        }

    }


}
