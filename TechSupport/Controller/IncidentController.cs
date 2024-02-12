using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;
using TechSupport.View;

///

namespace TechSupport.Controller
{
    public class IncidentController
    {
        private readonly IncidentService _incidentService;

        public static MainForm mainForm;
        public static DataGridView dataGridView;

        public IncidentController()
        {
            _incidentService = new IncidentService();
        }

        public void AddIncident(Incident incident)
        {
            if(incident == null)
            {
                throw new ArgumentNullException(nameof(incident), "Incident cannot be null");
            }
            _incidentService.AddIncident(incident);
            MainDataGridBinding();
         
        }
        public static void MainDataGridBinding()
        {
            IncidentService incidentService = new IncidentService();
            var incidentsList = incidentService.GetIncidentList(0);
            dataGridView.DataSource = incidentsList;
        }

        public List<Incident> GetIncidentList(int custId = 0)
        {
           return _incidentService.GetIncidentList(custId);
        }


    }
}
