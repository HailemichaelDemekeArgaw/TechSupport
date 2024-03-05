using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This the DAL class that deals with Technicians.
    /// </summary>
    public class TechniciansDAL
    {
        /// <summary>
        /// Gets the technicians.
        /// </summary>
        /// <returns></returns>
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
