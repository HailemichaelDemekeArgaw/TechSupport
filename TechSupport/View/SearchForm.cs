using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Represents the search form for querying and displaying incident data.
    /// </summary>
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the SearchForm class.
        /// </summary>
        public SearchForm()
        {
            InitializeComponent();
            searchBtn.Click += SearchController.SearchButton_Event;
            //SearchController.titleTxt = titleTxt;
            //SearchController.descriptionTxt = descTxt;
            SearchController.customerIdTxt = custIdTxt;
            SearchController.searchGrid = searchDataGrid;

        }
    }
}
