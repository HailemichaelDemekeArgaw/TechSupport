using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Represents the search form for querying and displaying incident data.
    /// </summary>
    public partial class SearchForm : Form
    {
        private readonly IncidentController _incidentController;

        /// <summary>
        /// Initializes a new instance of the SearchForm class.
        /// </summary>
        public SearchForm()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
        }

        /// <summary>
        /// Handles the Click event of the searchBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see instance containing the event data.</param>
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var customerId = !string.IsNullOrEmpty(custIdTxt.Text.ToString()) ? Convert.ToInt32(custIdTxt.Text) : 0;
            var incidents = _incidentController.GetIncidentList(customerId);
            searchDataGrid.DataSource = incidents;

        }
    }
}
