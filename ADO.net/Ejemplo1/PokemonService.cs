using Ejemplo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Example1
{
    internal class PokemonService
    {
                List<Pokemon> list = new List<Pokemon>();
        public List<Pokemon> tolist()
        {
            try
            {
                //stablish connection..
                SqlConnection connection = new SqlConnection();
                SqlCommand command = new SqlCommand();
                SqlDataReader reader;

                connection.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                command.CommandType= System.Data.CommandType.Text;
                command.CommandText = "select Numero, Nombre, Descripcion from POKEMONS";
                command.Connection = connection; 

                connection.Open();
                reader=command.ExecuteReader();

                while (reader.Read()) {
                Pokemon aux=new Pokemon();
                    aux.Number = reader.GetInt32(0);
                    aux.Name = (string)reader["Nombre"];
                    aux.Description = (string)reader["Descripcion"];

                    list.Add(aux);
                }
                connection.Close();

                return list;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        
    }
}
