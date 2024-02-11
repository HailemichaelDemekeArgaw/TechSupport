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
            //logoutLink.Click += MainFormController.LogoutButton_Event;
            //addBtn.Click += MainFormController.AddIncidentButton_Event;
            //searchBtn.Click += MainFormController.SearchIncidentButton_Event;
            //MainFormController.dataGridView = incidentDatagrid;
            //MainFormController.mainForm = this;
            //MainFormController.MainDataGridBinding();

            IncidentController.dataGridView = incidentDatagrid;
            IncidentController.mainForm = this;
            IncidentController.MainDataGridBinding();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddIncident addIncident = new AddIncident();
            addIncident.ShowDialog();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            this.MainDataGridBinding();
        }

        public void MainDataGridBinding()
        {
            this.incidentDatagrid.DataSource = null;
            this.incidentDatagrid.DataSource = _incidentController.GetIncidentList();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
