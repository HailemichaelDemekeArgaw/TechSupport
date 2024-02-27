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

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public AddIncident()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
            TitleErrMsg.Hide();
            DescErrMsg.Hide();
            CustIdErrMsg.Hide();
            messageLabel.Hide();

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

        /// <summary>
        /// Handles the Click event of the cancelBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the KeyDown event of the descTxt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void descTxt_KeyDown(object sender, KeyEventArgs e)
        {
            DescErrMsg.Hide();
        }

        /// <summary>
        /// Handles the KeyDown event of the titleTxt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void titleTxt_KeyDown(object sender, KeyEventArgs e)
        {
            TitleErrMsg.Hide();
        }

        /// <summary>
        /// Handles the KeyDown event of the custIdTxt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void custIdTxt_KeyDown(object sender, KeyEventArgs e)
        {
            CustIdErrMsg.Hide();
        }

        private void titleTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
