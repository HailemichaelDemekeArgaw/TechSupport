using TechSupport.DAL;

namespace TechSupport.Controller
{
    /// <summary>
    /// Class representing the Search controller
    /// </summary>
    public static class SearchController
    {
        public static TextBox titleTxt;
        public static TextBox descriptionTxt;
        public static TextBox customerIdTxt;
        public static DataGridView searchGrid;

        /// <summary>
        /// Event for search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SearchButton_Event(object sender, EventArgs e)
        {
            //var title = titleTxt != null ? titleTxt.Text : null;
            //var desc = descriptionTxt != null ? descriptionTxt.Text : null;
            var customerId = !string.IsNullOrEmpty(customerIdTxt.Text.ToString()) ? Convert.ToInt32(customerIdTxt.Text) : 0;

            IncidentService incidentService = new IncidentService();
            var incidents = incidentService.GetIncidentList(customerId);
            searchGrid.DataSource = incidents;
        }

    }
}
