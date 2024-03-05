using System.Data;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Class represents the Data Base Access.
    /// </summary>
    public class DBAccess
    {
        /// <summary>
        /// Method to get Database connection
        /// </summary>
        /// <returns>return Database SQL connection</returns>
        public static SqlConnection GetSqlConnection()
        {
           var conStr = "Data Source=localhost; Initial Catalog=TechSupport; Integrated Security=true";

            return new SqlConnection(conStr);
        }

        /// <summary>
        /// Method to get list of data from database based on sql statment.
        /// </summary>
        /// <param name="sql">SQL Statement</param>
        /// <returns>Return Data table</returns>
        public static DataTable? ReturnDataTable(string sql)
        {
            try
            {
                SqlConnection connection = GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Close();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                connection.Close();
                command.Dispose();
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Returns the incidents data table.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <returns></returns>
        public List<OpenIncidentsVM> ReturnIncidentsDataTable(string sql)
        {
            try
            {
                List<OpenIncidentsVM> openIncidents = new List<OpenIncidentsVM>();

                using (SqlConnection connection = GetSqlConnection())
                {

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OpenIncidentsVM incident = new OpenIncidentsVM();
                                incident.ProductCode = reader["ProductCode"].ToString();
                                incident.DatedOpened = Convert.ToString(reader["DateOpened"]);
                                incident.Customer = reader["Customer"].ToString();
                                incident.Title = reader["Title"].ToString();
                                incident.Technician = Convert.ToString(reader["Technician"] ?? "");
                                openIncidents.Add(incident);
                            }
                        }
                        connection.Close();
                        command.Dispose();
                    }
                }
                return openIncidents;
            }
            catch
            {
                return null;
            }
        }

    }
}
