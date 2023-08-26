using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace service
{
    public class ElementService
    {
        public List<Element> tolist()
        {
            List<Element> list = new List<Element>();
            DataAccess data= new DataAccess();

            try
            {
                data.setConsult("Select Id, Descripcion from ELEMENTOS");
                data.executeReading();

                while (data.Reader.Read())  
                {
                    Element aux = new Element();
                    aux.Id = (int)data.Reader["Id"];
                    aux.Description = (string)data.Reader["Descripcion"];
                    list.Add(aux);
                }

                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.closeConnection();
            }
        }
    }
}
