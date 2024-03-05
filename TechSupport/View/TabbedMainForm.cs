using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Class representing the main form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class TabbedMainForm : Form
    {
        private readonly IncidentController _incidentController;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public TabbedMainForm()
        {
            InitializeComponent();
            _incidentController = new IncidentController();

            ;
            this._incidentController.tabbedMain = this;

        }



        /// <summary>
        /// Handles the Load event of the TabbedMainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void TabbedMainForm_Load(object sender, EventArgs e)
        {
            //OpenIncidentList();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the tabControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages["openIncident"])
            {
                openIncidentuc1.OpenIncidentList();
            }
        }

        /// <summary>
        /// Handles the Click event of the cancelBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
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

        /// <summary>
        /// Handles the Click event of the openIncident control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OpenIncident_Click(object sender, EventArgs e)
        {
            openIncidentuc1.OpenIncidentList();
        }





    }
}
