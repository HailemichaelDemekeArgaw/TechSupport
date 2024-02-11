using System.Runtime.CompilerServices;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Class reprsenting the Add Incident Form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddIncident : Form
    {
        private readonly IncidentController _incidentController;
        public AddIncident()
        {
            InitializeComponent();
            _incidentController = new IncidentController();

            //titleTxt.KeyDown += AddIncidentController.TitleKeyDown_Event;
            //descTxt.KeyDown += AddIncidentController.DescKeyDown_Event;
            //custIdTxt.KeyDown += AddIncidentController.CustIdKeyDown_Event;
            //addBtn.Click += AddIncidentController.AddButton_Event;
            //cancelBtn.Click += AddIncidentController.CancelButton_Event;


            TitleErrMsg.Hide();
            DescErrMsg.Hide();
            CustIdErrMsg.Hide();
            messageLabel.Hide();

            //AddIncidentController.title = titleTxt;
            //AddIncidentController.description = descTxt;
            //AddIncidentController.customerId = custIdTxt;
            //AddIncidentController.addIncident = this;
            //AddIncidentController.titelErrLbl = TitleErrMsg;
            //AddIncidentController.descErrLbl = DescErrMsg;
            //AddIncidentController.custIdErrLbl = CustIdErrMsg;

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
                        this.Close();

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
                //MainFormController.dataGridView.Visible = true;
                // MainFrom mainFrom = new MainFrom();
                //_incidentController.GetIncidentList();
                // mainFrom.MainDataGridBinding();

                this.Close();
            }

            private void descTxt_KeyDown(object sender, KeyEventArgs e)
            {
                DescErrMsg.Hide();
            }

            private void titleTxt_KeyDown(object sender, KeyEventArgs e)
            {
                TitleErrMsg.Hide();
            }

            private void custIdTxt_KeyDown(object sender, KeyEventArgs e)
            {
                CustIdErrMsg.Hide();
            }
        }
    }
