using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Declare the MainForm class.
    /// </summary>
    public partial class MainForm : Form
    {
        private IncidentController _incidentController;

        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
            this._incidentController.dataGridView = incidentDatagrid;
            this._incidentController.mainForm = this;
            this._incidentController.MainDataGridBinding();
        }

        /// <summary>
        /// Handles the Click event of the addBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddIncident addIncident = new AddIncident();
            addIncident.ShowDialog();
        }

        /// <summary>
        /// Handles the Load event of the MainFrom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void MainFrom_Load(object sender, EventArgs e)
        {
            this.MainDataGridBinding();
        }

        /// <summary>
        /// Mains the data grid binding.
        /// </summary>
        public void MainDataGridBinding()
        {
            this.incidentDatagrid.DataSource = null;
            this.incidentDatagrid.DataSource = _incidentController.GetIncidentList();
        }

        /// <summary>
        /// Handles the Click event of the searchBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        /// <summary>
        /// Handles the LinkClicked event of the logoutLink control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
