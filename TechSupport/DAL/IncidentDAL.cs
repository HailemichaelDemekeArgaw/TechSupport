using System.Data;
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
        public IncidentResponse AddIncident(Incidents incident)
        {
            try
            {
                string insertIncident = "insert into Incidents(CustomerID, ProductCode, DateOpened,Title, Description) " +
                          "values(@customerID, @productCode,@dateOpened, @title, @description)";

                string message = "";
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
                            return new IncidentResponse
                            {
                                Success = true,
                                Message = message
                            };
                        }
                    }
                    catch
                    {
                        connection.Close();
                        return new IncidentResponse
                        {
                            Success = false,
                            Message = "Exception during incident registration"
                        };

                    }

                }
            }
            catch
            {
                return new IncidentResponse
                {
                    Success = false,
                    Message = "Exception during incident registration"
                };
            }

        }


        /// <summary>
        /// Method to check registratio asociatated customer with product
        /// </summary>
        /// <param name="CustomerId">Customer ID</param>
        /// /// <param name="ProductCode">Product Code</param>
        /// <returns>return registration incident is associated  customer with product</returns>
        public Registration GetCustomerAssociatedRegistration(int CustomerId, string ProductCode)
        {
            string sqlStatement = "select top 1 CustomerID,ProductCode from Registrations " +
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
                            while (reader.Read())
                            {
                                return new Registration
                                {

                                    CustomerId = (int)reader["CustomerID"],
                                    ProductCode = reader["ProductCode"]?.ToString()
                                };
                            };
                        }

                    }
                }
            }

            return null;
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

        /// <summary>
        /// Search  incidents.
        /// </summary>
        /// <param name="sql">SQL Statement</param>
        /// <returns>incidet</returns>
        public SearchIncidentVM SearchIncidents(string sql)
        {
            try
            {
                SearchIncidentVM searchIncident = new SearchIncidentVM();

                using (SqlConnection connection = DBAccess.GetSqlConnection())
                {

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows == true)
                            {
                                reader.Read();

                                if (!Convert.IsDBNull(reader["TechID"]))
                                {
                                    searchIncident.TechId = Convert.ToInt16(reader["TechID"]);
                                }

                                searchIncident.ProductCode = Convert.ToString(reader["ProductCode"] ?? "");
                                searchIncident.DatedOpened = Convert.ToDateTime(reader["DateOpened"]);
                                if (!Convert.IsDBNull(reader["DateClosed"]))
                                {
                                    searchIncident.DateClosed = Convert.ToDateTime(reader["DateClosed"]);
                                }
                                searchIncident.Customer = Convert.ToString(reader["Customer"] ?? "");
                                searchIncident.Title = Convert.ToString(reader["Title"] ?? "");
                                searchIncident.Description = Convert.ToString(reader["Description"] ?? "");
                                searchIncident.Technician = Convert.ToString(reader["Technician"] ?? "");

                            }
                            else
                            {
                                searchIncident = null;
                            }
                        }
                        connection.Close();
                        command.Dispose();
                    }
                }
                return searchIncident;
            }
            catch
            {
                return null;
            }
        }


        /// <summary>
        /// Method to update incident
        /// </summary>
        /// <param name="incident">Customer ID</param>
        /// <returns>return confirmation or error message</returns>

        public string UpdateIncidents(Incidents incident)
        {
            try
            {
                string updateIncident = "update Incidents set  Description = @description, TechID = @techID where IncidentID = @incidentID";
                if (incident.TechId == 0)
                {
                    updateIncident = "update Incidents set  Description = @description where IncidentID = @incidentID";
                }

                //string updateIncident = "update Incidents set  Description = @description, TechID = @techID where IncidentID = @incidentID";

                string message = "";


                message = "Inncident is updated";
                using (SqlConnection connection = DBAccess.GetSqlConnection())
                {
                    try
                    {


                        using (SqlCommand selectCommand = new SqlCommand(updateIncident, connection))
                        {
                            connection.Open();
                            selectCommand.Parameters.Add("@incidentID", System.Data.SqlDbType.Int);
                            selectCommand.Parameters["@incidentID"].Value = incident.IncidentID;
                            selectCommand.Parameters.Add("@techID", System.Data.SqlDbType.Int);
                            selectCommand.Parameters["@techID"].Value = incident.TechId;
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
            catch (Exception ex)
            {
                return "Exception during update incident. " + ex.Message;
            }
        }

        /// <summary>
        /// Method to Close incident
        /// </summary>
        /// <param name="incident">Customer ID</param>
        /// <returns>return confirmation or error message</returns>
        public string CloseIncidents(Incidents incident)
        {
            try
            {
                string updateIncident = "update Incidents set  Description = @description, TechID=@techID, DateClosed = @dateClosed " +
                          "where IncidentID =@incidentID";

                string message = "";


                message = "Inncident closed";
                using (SqlConnection connection = DBAccess.GetSqlConnection())
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand selectCommand = new SqlCommand(updateIncident, connection))
                        {

                            selectCommand.Parameters.Add("@incidentID", System.Data.SqlDbType.Int);
                            selectCommand.Parameters["@incidentID"].Value = incident.IncidentID;
                            selectCommand.Parameters.Add("@techID", System.Data.SqlDbType.Int);
                            selectCommand.Parameters["@techID"].Value = incident.TechId;
                            selectCommand.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
                            selectCommand.Parameters["@description"].Value = incident.Description;
                            selectCommand.Parameters.Add("@dateClosed", System.Data.SqlDbType.DateTime);
                            selectCommand.Parameters["@dateClosed"].Value = DateTime.Now;
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
            catch (Exception ex)
            {
                return "Exception during incident closing " + ex.Message;
            }
        }


    }
}
