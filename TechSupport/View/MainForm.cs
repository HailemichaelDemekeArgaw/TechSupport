using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Declare the MainForm class.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            logoutLink.Click += MainFormController.LogoutButton_Event;
            addBtn.Click += MainFormController.AddIncidentButton_Event;
            searchBtn.Click += MainFormController.SearchIncidentButton_Event;
            MainFormController.dataGridView = incidentDatagrid;
            MainFormController.mainForm = this;
            MainFormController.MainDataGridBinding();
        }
    }
}
