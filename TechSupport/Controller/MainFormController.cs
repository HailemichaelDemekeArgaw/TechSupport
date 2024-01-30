using TechSupport.View;
using TechSupport.DAL;

namespace TechSupport.Controller
{
    /// <summary>
    /// Implement MainFormController for MainFrom events and data binding.
    /// </summary>
    public static class MainFormController
    {
        public static MainForm mainForm;
        public static DataGridView dataGridView;

        /// <summary>
        /// Logout button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void LogoutButton_Event(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            mainForm.Close();
        }

        /// <summary>
        /// on load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void OnLoad_Event(object sender, EventArgs e)
        {
            MainDataGridBinding();
        }

        /// <summary>
        /// Method for binding data to datagrid
        /// </summary>
        public static void MainDataGridBinding()
        {
            IncidentService incidentService = new IncidentService();
            var incidentsList = incidentService.GetIncidentList(0);
            dataGridView.DataSource = incidentsList;
        }

        /// <summary>
        /// Add incident event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void AddIncidentButton_Event(object sender, EventArgs e)
        {
            AddIncident addIncident = new AddIncident();
            addIncident.ShowDialog();
        }

        /// <summary>
        /// search incident event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SearchIncidentButton_Event(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }
    }
}
