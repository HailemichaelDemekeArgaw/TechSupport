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
            //searchBtn.Click += SearchController.SearchButton_Event;
            //SearchController.titleTxt = titleTxt;
            //SearchController.descriptionTxt = descTxt;
            //SearchController.customerIdTxt = custIdTxt;
            //SearchController.searchGrid = searchDataGrid;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var customerId = !string.IsNullOrEmpty(custIdTxt.Text.ToString()) ? Convert.ToInt32(custIdTxt.Text) : 0;
            var incidents = _incidentController.GetIncidentList(customerId);
            searchDataGrid.DataSource = incidents;

        }
    }
}
