﻿using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This the DAL class that deals with Product.
    /// </summary>
    public class ProductDAL
    {
        
        /// <summary>
        /// Method to get list of customer data from database based on sql statment.
        /// </summary>
        /// <returns>Return Product list</returns>
        public List<Products> GetProducts()
        {
            List<Products> productList = new List<Products>();
            string sqlStatement = "select ProductCode,Name from Products";
            using (SqlConnection connection = DBAccess.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Products products = new Products();
                            products.ProductCode = (string)reader["ProductCode"];
                            products.Name = (string)reader["Name"];
                            productList.Add(products);
                        }
                    }
                }
            }
            return productList;

        }
    }
}
