﻿using TechSupport.DAL;
using TechSupport.Model;
using TechSupport.View;

namespace TechSupport.Controller
{
    /// <summary>
    /// Represents the Incident Controller Class
    /// </summary>
    public class IncidentController
    {
        private readonly IncidentDAL _incidentDAL;
        private readonly TechniciansDAL _techniciansDAL;
        private readonly CustomerDAL _customerDAL;
        private readonly IncidentService _incidentService;

        private readonly DBAccess _dbAccess;
        public MainForm mainForm;
        public DataGridView dataGridView;
        public TabbedMainForm tabbedMain;

        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentController"/> class.
        /// </summary>
        public IncidentController()
        {
            this._incidentDAL = new IncidentDAL();
            this._customerDAL = new CustomerDAL();
            this._techniciansDAL = new TechniciansDAL();
            this._incidentService = new IncidentService();
            _dbAccess = new DBAccess();
        }

        /// <summary>
        /// Adds the incident.
        /// </summary>
        /// <param name="incident">The incident.</param>
        /// <exception> incident - Incident cannot be null</exception>
        public void AddIncident(Incident incident)
        {
            if(incident == null)
            {
                throw new ArgumentNullException(nameof(incident), "Incident cannot be null");
            }
            _incidentService.AddIncident(incident);
            MainDataGridBinding();

        }

        /// <summary>
        /// Adds the incident to database.
        /// </summary>
        /// <param name="incident">The incident.</param>
        /// <returns></returns>
        public string AddIncidentToDatabase(Incidents incident)
        {
            return this._incidentDAL.AddIncident(incident);
        }


        /// <summary>
        /// Mains the data grid binding.
        /// </summary>
        public void MainDataGridBinding()
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
        /// <returns></returns>
        public List<OpenIncidentsVM> ReturnIncidentList()
        {
            string sql = "select I.ProductCode As [ProductCode],convert(varchar(10),DateOpened,101) As DateOpened, C.Name[Customer], T.Name As Technician, I.Title  from Incidents I inner join Customers C on I.CustomerID=C.CustomerID Left join Technicians T on I.TechID=T.TechID where I.DateClosed is null";
            List<OpenIncidentsVM> dataTable = _dbAccess.ReturnIncidentsDataTable(sql);

            return dataTable;
        }

    }
}
