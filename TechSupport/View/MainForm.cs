using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.DAL;

namespace TechSupport.View
{
    /// <summary>
    /// Declare the MainForm class.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IncidentController _incidentController;

        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
            IncidentController.dataGridView = incidentDatagrid;
            IncidentController.mainForm = this;
            IncidentController.MainDataGridBinding();
        }

        /// <summary>
        /// Handles the Click event of the addBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void addBtn_Click(object sender, EventArgs e)
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
        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        /// <summary>
        /// Handles the LinkClicked event of the logoutLink control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
