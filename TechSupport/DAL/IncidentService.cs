using System.Text.Json;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Service class providing functionality for managing incidents.
    /// </summary>
    public class IncidentService
    {
        /// <summary>
        /// Method to get list of data
        /// </summary>
        /// <param name="title">Title</param>
        /// <param name="desc">Description</param>
        /// <param name="custId">Customer Id</param>
        /// <returns>List of Incidents</returns>
        public List<Incident> GetIncidentList(int custId = 0)
        {
            List<Incident> incidentsList = new List<Incident>();
            var incidents = IncidentListFromFile().AsQueryable();

            if (custId > 0)
            {
                incidents = incidents.Where(x => x.CustomerId == custId);
            }
            incidentsList = incidents.ToList();

            return incidentsList;
        }

        /// <summary>
        /// Method to add incident
        /// </summary>
        /// <param name="incident">Incident object</param>
        public void AddIncident(Incident incident)
        {
            var incidentFile = @"./IncidentData/IncidentDataFile.json";
            if (File.Exists(incidentFile))
            {
                List<Incident> existingIncidents = new List<Incident>();

                using (var reader = new StreamReader(incidentFile))
                {
                    var json = reader.ReadToEnd();
                    if (!string.IsNullOrEmpty(json))
                    {
                        existingIncidents = JsonSerializer.Deserialize<List<Incident>>(json);
                    }
                }

                existingIncidents.Add(incident);

                using (var sw = new StreamWriter(incidentFile))
                {
                    sw.Write(JsonSerializer.Serialize<List<Incident>>(existingIncidents));
                }

            }
        }

        /// <summary>
        /// Method to get and read data from file
        /// </summary>
        /// <returns>List of incident from file</returns>
        public List<Incident> IncidentListFromFile()
        {
            List<Incident> incidents = new List<Incident>();

            if (!Directory.Exists(@"./IncidentData"))
            {
                System.IO.Directory.CreateDirectory(@"./IncidentData");

                if (!File.Exists(@"./IncidentData/IncidentDataFile.json"))
                {
                    using (FileStream fs = File.Create(@"./IncidentData/IncidentDataFile.json"))
                    {
                    }
                }
            }

            using (var stream = File.Open(@"./IncidentData/IncidentDataFile.json", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = new StreamReader(stream))
                {
                    var json = reader.ReadToEnd();
                    if (!string.IsNullOrEmpty(json))
                    {
                        incidents = JsonSerializer.Deserialize<List<Incident>>(json);
                    }
                }
            }

            GC.Collect();

            return incidents;
        }
    }
}
