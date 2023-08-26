using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using domain;
using System.ComponentModel.Design;

namespace service
{
    public class DataAccess
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public DataAccess()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true");
            command = new SqlCommand();
        }

        public void setConsult(string consult)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = consult;
        }
        public void executeReading()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void executenonquery()
        {
            command.Connection=connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void setParameter(string name, object value)
        {
            command.Parameters.AddWithValue(name,value);
        }
        public void closeConnection()
        {
            if (reader != null)
            {
                reader.Close();
            }
            connection.Close();
        }
    }
}
