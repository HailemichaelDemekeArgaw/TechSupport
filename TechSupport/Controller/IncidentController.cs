using TechSupport.DAL;
using TechSupport.Model;
using TechSupport.View;
using System.Data;

namespace TechSupport.Controller
{
    /// <summary>
    /// Represents the Incident Controller Class
    /// </summary>
    public class IncidentController
    {
        private readonly IncidentService _incidentService;

        public static MainForm mainForm;
        public static DataGridView dataGridView;
        public static TabbedMainForm tabbedMain;

        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentController"/> class.
        /// </summary>
        public IncidentController()
        {
            _incidentService = new IncidentService();
        }

        /// <summary>
        /// Adds the incident.
        /// </summary>
        /// <param name="incident">The incident.</param>
        /// <exception> incident - Incident cannot be null</exception>
        public void AddIncident(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException(nameof(incident), "Incident cannot be null");
            }
            _incidentService.AddIncident(incident);
            MainDataGridBinding();

        }
        /// <summary>
        /// Mains the data grid binding.
        /// </summary>
        public static void MainDataGridBinding()
        {
            IncidentService incidentService = new IncidentService();
            var incidentsList = incidentService.GetIncidentList(0);
            dataGridView.DataSource = incidentsList;
        }

        /// <summary>
        /// Gets the incident list.
        /// </summary>
        /// <param name="custId">The customer identifier.</param>
        /// <returns></returns>
        public List<Incident> GetIncidentList(int custId = 0)
        {
            return _incidentService.GetIncidentList(custId);
        }

        /// <summary>
        /// Returns the incident list.
        /// </summary>
        /// <returns>data table</returns>
        public DataTable ReturnIncidentList()
        {
            string sql = "select I.ProductCode, convert(varchar(10),DateOpened,101) , C.Name[Customer], T.Name, I.Title  from Incidents I inner join Customers C on I.CustomerID=C.CustomerID Left join Technicians T on I.TechID=T.TechID";
            DataTable dataTable = DBAccess.ReturnDataTable(sql);
            return dataTable;
        }

    }
}
