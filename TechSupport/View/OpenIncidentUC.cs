using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Class representing the User Control.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class OpenIncidentUC : UserControl
    {
        private readonly IncidentController _incidentController;
        public OpenIncidentUC()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
        }

        /// <summary>
        /// Opens the incident list.
        /// </summary>
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

        /// <summary>
        /// Handles the Load event of the OpenIncidentUC control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OpenIncidentUC_Load(object sender, EventArgs e)
        {
            OpenIncidentList();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the incidentlistView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void incidentlistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
