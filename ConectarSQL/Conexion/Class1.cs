using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Conexion
{
    public class Class1
    {
        private SqlConnection conn;
        private string cnx;

        public Class1()
        {
           
        }
        private void conectar()
        {
            //cnx = ("Server=s2x4.database.windows.net;Database=s2x4;User Id=s2x4;Password = 123456aA; ");
        
                cnx = ConfigurationManager.ConnectionStrings["PruebaConectar.Properties.Settings.Valor"].ConnectionString;
                conn = new SqlConnection(cnx);
                conn.Open();
         
        }

        public DataSet PortarTaula(string nomtaula)
        {
            SqlDataAdapter adapter;
            String query;
            query = "select * from " + nomtaula;
            conectar();
            adapter = new SqlDataAdapter(query, conn);
            

            DataSet dts = new DataSet();
            try
            {
                adapter.Fill(dts);
                
            }
            catch { }
            conn.Close();
            return dts;

        }

        public void Actualitzar(string query, DataSet dts)
        {
            conectar();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);
            if (dts.HasChanges())
            {
               int result = adapter.Update(dts.Tables[0]);
            }

        }
        /* public DataSet PortarPerConsulta()
        {
        }*/

    }
}
