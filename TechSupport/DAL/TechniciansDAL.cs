using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class TechniciansDAL
    {
        public List<Technicians> GetTechnicians()
        {
            List<Technicians> technicianList = new List<Technicians>();
            string sqlStatement = "select * from Technicians";
            using (SqlConnection connection = DBAccess.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Technicians technician = new Technicians();
                            technician.TechID = (int)reader["TechID"];
                            technician.Name = (string)reader["Name"];
                            technician.Email = (string)reader["email"];
                            technician.Phone = (string)reader["Phone"];
                            technicianList.Add(technician);
                        }
                    }
                }
            }
            return technicianList;
        }

    }
}
