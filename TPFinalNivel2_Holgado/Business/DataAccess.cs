﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Business
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
            connection=new SqlConnection("server=.\\SQLEXPRESS; database= CATALOGO_DB; integrated security=true");
            command = new SqlCommand("");
        }

        public void SetQuery(string query)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }

        public void ExecuteQuery()
        {
            try
            {
            command.Connection= connection;
            connection.Open();
            reader= command.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void executeNonQuery()
        {
            try
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CloseConnection()
        {
            if(reader != null)
            {
                reader.Close();
            }
            connection.Close();
        }

        public void setParameter(string name, object value)
        {
            command.Parameters.AddWithValue(name, value);
        }
    }
}
