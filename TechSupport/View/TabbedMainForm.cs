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
            TitleErrMsg.Hide();
            DescErrMsg.Hide();
            CustIdErrMsg.Hide();
            messageLabel.Hide();
            this._incidentController.dataGridView = incidentDatagrid;
            this._incidentController.tabbedMain = this;
            this._incidentController.MainDataGridBinding();
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
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages["inciedentList"])
            {
                MainDataGridBinding();
            }
            else if (tabControl.SelectedTab == tabControl.TabPages["tabAdd"])
            {
                IncidentForm incidentForm = new IncidentForm();
                incidentForm.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Click event of the addBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool checkCustomerIdisNumeric = int.TryParse(custIdTxt.Text, out int id);
                if (!string.IsNullOrEmpty(titleTxt.Text) && !string.IsNullOrEmpty(descTxt.Text) && !string.IsNullOrEmpty(custIdTxt.Text) && checkCustomerIdisNumeric == true)
                {

                    var incident = new Incident()
                    {
                        Title = titleTxt.Text,
                        Description = descTxt.Text,
                        CustomerId = Convert.ToInt32(custIdTxt.Text)
                    };
                    _incidentController.AddIncident(incident);
                    messageLabel.ForeColor = Color.Green;
                    messageLabel.Text = "Add incident is successful!";
                    MainDataGridBinding();
                    tabControl.SelectedIndex = 1;

                }
                else
                {
                    if (string.IsNullOrEmpty(titleTxt.Text))
                    {

                        TitleErrMsg.Text = "Title is required.";
                        TitleErrMsg.ForeColor = Color.Red;
                        TitleErrMsg.Show();
                    }
                    if (string.IsNullOrEmpty(descTxt.Text))
                    {
                        DescErrMsg.Text = "description is required.";
                        DescErrMsg.ForeColor = Color.Red;
                        DescErrMsg.Show();
                    }
                    if (string.IsNullOrEmpty(custIdTxt.Text))
                    {

                        CustIdErrMsg.Text = "CustomerId is required.";
                        CustIdErrMsg.ForeColor = Color.Red;
                        CustIdErrMsg.Show();
                    }

                    if (checkCustomerIdisNumeric == false && !string.IsNullOrEmpty(custIdTxt.Text))
                    {
                        CustIdErrMsg.Text = "CustomerId is should be number.";
                        CustIdErrMsg.ForeColor = Color.Red;
                        CustIdErrMsg.Show();
                    }
                    messageLabel.Hide();
                }

            }
            catch (Exception)
            {
                messageLabel.Text = "Exception during adding incident!";
                messageLabel.ForeColor = Color.Red;
            }
            messageLabel.Visible = true;
        }

        /// <summary>
        /// Handles the Click event of the cancelBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        /// <summary>
        /// Handles the Click event of the searchBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            var customerId = !string.IsNullOrEmpty(customerIdTxt.Text.ToString()) ? Convert.ToInt32(customerIdTxt.Text) : 0;
            var incidents = _incidentController.GetIncidentList(customerId);
            searchDataGrid.DataSource = incidents;
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

        /// <summary>
        /// Handles the Click event of the openIncident control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void openIncident_Click(object sender, EventArgs e)
        {
            //OpenIncidentList();
        }

        /// <summary>
        /// Handles the TextChanged event of the titleTxt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void titleTxt_TextChanged(object sender, EventArgs e)
        {
            TitleErrMsg.Hide();
        }

        /// <summary>
        /// Handles the TextChanged event of the descTxt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void descTxt_TextChanged(object sender, EventArgs e)
        {
            DescErrMsg.Hide();
        }

        /// <summary>
        /// Handles the TextChanged event of the custIdTxt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void custIdTxt_TextChanged(object sender, EventArgs e)
        {
            CustIdErrMsg.Hide();
        }
    }
}
