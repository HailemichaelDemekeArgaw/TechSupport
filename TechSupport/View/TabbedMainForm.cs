using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    public partial class TabbedMainForm : Form
    {
        private readonly IncidentController _incidentController;
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

        public void MainDataGridBinding()
        {

            this.incidentDatagrid.DataSource = null;
            this.incidentDatagrid.DataSource = _incidentController.GetIncidentList();

        }


        private void TabbedMainForm_Load(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages["inciedentList"])
            {
                MainDataGridBinding();
            }
        }

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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var customerId = !string.IsNullOrEmpty(customerIdTxt.Text.ToString()) ? Convert.ToInt32(customerIdTxt.Text) : 0;
            var incidents = _incidentController.GetIncidentList(customerId);
            searchDataGrid.DataSource = incidents;
        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
