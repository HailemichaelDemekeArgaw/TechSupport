using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    partial class OpenIncidentUC : UserControl
    {
        private readonly IncidentController _incidentController;
        public OpenIncidentUC()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();

        }

        public void OpenIncidentList()
        {
            try
            {

                incidentlistView.Clear();
                incidentlistView.View = System.Windows.Forms.View.Details;
                incidentlistView.GridLines = true;
                incidentlistView.Columns.Add("Product Code", 110);
                incidentlistView.Columns.Add("Date Opened", 125);
                incidentlistView.Columns.Add("Customer", 170);
                incidentlistView.Columns.Add("Technician", 170);
                incidentlistView.Columns.Add("Title", 340);
                List<OpenIncidentsVM> dataSet = _incidentController.ReturnIncidentList();
                foreach (var dr in dataSet)
                {
                    var incidentList = incidentlistView.Items.Add(dr.ProductCode.ToString());
                    incidentList.SubItems.Add(dr.DatedOpened.ToString());
                    incidentList.SubItems.Add(dr.Customer.ToString());
                    incidentList.SubItems.Add(dr.Technician.ToString());
                    incidentList.SubItems.Add(dr.Title.ToString());
                }
            }
            catch (Exception)
            {
                incidentlistView.Clear();
                return;
            }

        }

        private void OpenIncidentUC_Load(object sender, EventArgs e)
        {
            OpenIncidentList();
        }
    }
}
