using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;



namespace pryAutoEvaluacion
{
    internal class clsLocalidad
    {
        string cadena = "provider=microsoft.jet.oledb.4.0;data source=CLIMA.mdb";
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        public DataTable tabla;


        public clsLocalidad()
        {
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Localidades";
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);
        }
        public DataTable getAll()
        {
            return tabla;

        }


















    }
}
