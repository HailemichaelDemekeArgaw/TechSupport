using System.Data.SqlClient;
using TechSupport.Model;


namespace TechSupport.DAL
{
    /// <summary>
    /// This the DAL class that deals with Customer.
    /// </summary>
    public class CustomerDAL
    {
        /// <summary>
        /// Gets the customers.
        /// </summary>
        /// <returns>customerList</returns>
        public List<Customers> GetCustomers()
        {
            List<Customers> customerList = new List<Customers>();
            string sqlStatement = "select CustomerID,Name from Customers";
            using (SqlConnection connection = DBAccess.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customers customer = new Customers();

                            customer.CustomerId = (int)reader["CustomerID"];
                            customer.Name = (string)reader["Name"];
                            customerList.Add(customer);


                        }
                    }
                }
            }
            return customerList;
        }
    }
}

