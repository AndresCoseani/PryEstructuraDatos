using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PryEstructuraDatos
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";


        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;//tipo de comando, tabla
                comando.CommandText = "Autor";//se le pasa lo que se quiere pasar en este caso la tabla


                DataSet DS = new DataSet();//el data set agarra el dato y la muestra asi como esta
                adaptador = new OleDbDataAdapter(comando);// se le pasa el comando al adaptador
                adaptador.Fill(DS, "Autor");//el adaptador llena el data set con la tabla autor

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Autor"];
                conexion.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }
            public void Listar(DataGridView Grilla, String InstruccionSQL)
            {
                try
                {
                    conexion.ConnectionString = CadenaConexion;
                    conexion.Open();

                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = InstruccionSQL;

                    DataSet DS = new DataSet();
                    adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(DS, "ResultadoConsulta");

                    Grilla.DataSource = null;
                    Grilla.DataSource = DS.Tables["ResultadoConsulta"];
                    conexion.Close();

                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                    conexion.Close();
                }

            }
    }
}
