using System.Data;
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
            IncidentController.dataGridView = incidentDatagrid;
            IncidentController.tabbedMain = this;
            IncidentController.MainDataGridBinding();
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
        /// Opens the incident list.
        /// </summary>
        public void OpenIncidentList()
        {
            try
            {

                incidentlistView.Clear();
                incidentlistView.View = System.Windows.Forms.View.Details;
                incidentlistView.GridLines = true;
                incidentlistView.Columns.Add("Product Code", 110);
                incidentlistView.Columns.Add("Date Open", 90);
                incidentlistView.Columns.Add("Customer", 150);
                incidentlistView.Columns.Add("Technician", 150);
                incidentlistView.Columns.Add("Ttile", 250);
                DataTable dataSet = _incidentController.ReturnIncidentList();
                foreach (DataRow dr in dataSet.Rows)
                {
                    var incidentList = incidentlistView.Items.Add(dr[0].ToString());
                    incidentList.SubItems.Add(dr[1].ToString());
                    incidentList.SubItems.Add(dr[2].ToString());
                    incidentList.SubItems.Add(dr[3].ToString());
                    incidentList.SubItems.Add(dr[4].ToString());
                }
            }
            catch (Exception)
            {
                incidentlistView.Clear();
                return;
            }

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
            else if (tabControl.SelectedTab == tabControl.TabPages["openIncident"])
            {
                OpenIncidentList();
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

        private void openIncident_Click(object sender, EventArgs e)
        {
            OpenIncidentList();
        }
    }
}
