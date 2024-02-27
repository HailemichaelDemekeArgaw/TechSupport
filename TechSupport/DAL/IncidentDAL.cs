using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class IncidentDAL
    {
        /// <summary>
        /// Method to Add incident to database
        /// </summary>
        /// <param name="incident">Incidents model</param>
        /// <returns>return confiremation Message</returns>
        public string AddIncident(Incidents incident)
        {
            try
            {
                string insertIncident = "insert into Incidents(CustomerID, ProductCode, DateOpened,Title, Description) " +
                          "values(@customerID, @productCode,@dateOpened, @title, @description)";

                string message = "";
                bool customerAssoc = CheckRegistratioAssociation(incident.CustomerId, incident.ProductCode);
                if (customerAssoc == true)
                {
                    message = "Incident is succefully added! ";
                    using (SqlConnection connection = DBAccess.GetSqlConnection())
                    {
                        try
                        {
                            connection.Open();

                            using (SqlCommand selectCommand = new SqlCommand(insertIncident, connection))
                            {

                                selectCommand.Parameters.Add("@customerID", System.Data.SqlDbType.Int);
                                selectCommand.Parameters["@customerID"].Value = incident.CustomerId;
                                selectCommand.Parameters.Add("@productCode", System.Data.SqlDbType.VarChar);
                                selectCommand.Parameters["@productCode"].Value = incident.ProductCode;
                                selectCommand.Parameters.Add("@dateOpened", System.Data.SqlDbType.DateTime);
                                selectCommand.Parameters["@dateOpened"].Value = DateTime.Now;
                                selectCommand.Parameters.Add("@title", System.Data.SqlDbType.VarChar);
                                selectCommand.Parameters["@title"].Value = incident.Title;
                                selectCommand.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
                                selectCommand.Parameters["@description"].Value = incident.Description;
                                selectCommand.ExecuteNonQuery();
                                return message;
                            }
                        }
                        catch
                        {
                            connection.Close();
                            return "Exception during incident registration";
                        }

                    }
                }
                else
                {
                    return "Incident registration is not associated with the customer for the product";
                }

            }
            catch
            {
                return "Exception during incident registration";
            }

        }


        /// <summary>
        /// Method to check registratio asociatated customer with product
        /// </summary>
        /// <param name="CustomerId">Customer ID</param>
        /// /// <param name="ProductCode">Product Code</param>
        /// <returns>return registration incident is associated  customer with product</returns>
        public Boolean CheckRegistratioAssociation(int CustomerId, string ProductCode)
        {
            bool associated = false;
            string sqlStatement = "select * from Registrations " +
                "where CustomerID=@customerID and ProductCode=@productCode";
            using (SqlConnection connection = DBAccess.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {
                    selectCommand.Parameters.Add("@customerID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@customerID"].Value = CustomerId;
                    selectCommand.Parameters.Add("@productCode", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@productCode"].Value = ProductCode;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.HasRows == true)
                        {
                            associated = true;
                        }

                    }
                }
            }

            return associated;
        }


        /// <summary>
        /// Gets the incidents.
        /// </summary>
        /// <returns></returns>
        public List<Incidents> GetIncidents()
        {
            List<Incidents> incidentList = new List<Incidents>();
            string sqlStatement = "select * from Incidents where DateClosed is null";
            using (SqlConnection connection = DBAccess.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Incidents incident = new Incidents();

                            incident.IncidentID = (int)reader["IncidentID"];
                            incident.CustomerId = (int)reader["CustomerID"];
                            incident.ProductCode = (string)reader["ProductCode"];
                            incident.TechId = (int)(Convert.IsDBNull(reader["TechId"]) ? 0 : reader["TechId"]);
                            if (!Convert.IsDBNull(reader["DateOpened"]))
                            {
                                incident.DateOpened = Convert.ToDateTime(reader["DateOpened"]);
                            }
                            if (!Convert.IsDBNull(reader["DateClosed"]))
                            {
                                incident.DateClosed = (DateTime)reader["DateClosed"];
                            }
                            incident.Title = (string)reader["Title"];
                            incident.Description = (string)reader["Description"];
                            incidentList.Add(incident);


                        }
                    }
                }
            }
            return incidentList;
        }

    }
}
