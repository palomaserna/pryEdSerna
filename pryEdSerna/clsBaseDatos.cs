using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Runtime.CompilerServices;



namespace pryEdSerna
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando= new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        private String CadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Autor";

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Autor");

                Grilla.DataSource = DS.Tables["Autor"];

                conexion.Close();
            }
            catch(Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void Listar(String Tabla, DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, Tabla);

                Grilla.DataSource = DS.Tables[Tabla];

                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void Listar(DataGridView Grilla, String SQL)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = SQL;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Tabla");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Tabla"];

                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
