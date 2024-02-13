using System.Data;
using System.Data.SqlClient;

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

    }
}

