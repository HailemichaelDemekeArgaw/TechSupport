using Microsoft.VisualBasic.Logging;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Class Representing the Log in Form
    /// </summary>
    public partial class Login : Form
    {
        /// <summary>
        /// Initializes a new instance of the Login class.
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(userNameTxt.Text) && !string.IsNullOrEmpty(passwordTxt.Text))
                {
                    if (userNameTxt.Text == "jane" && passwordTxt.Text == "test1234")
                    {
                        TabbedMainForm tabbedMainForm = new TabbedMainForm();
                        tabbedMainForm.Show();
                        tabbedMainForm.Controls["userNameLbl"].Text = userNameTxt.Text;
                        this.Close();

                    }
                    else
                    {
                        errorLabel.Text = "Invalid username/password.";
                        errorLabel.ForeColor = Color.Red;
                        errorLabel.Show();
                    }

                }
                else
                {
                    errorLabel.Text = "Invalid username/password.";
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Show();
                }
            }
            catch (Exception)
            {
                errorLabel.Text = "Invalid username/password.";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Show();
            }

        }

        /// <summary>
        /// Handles the Load event of the Login control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void Login_Load(object sender, EventArgs e)
        {
            errorLabel.Hide();
        }

        /// <summary>
        /// Handles the KeyDown event of the Login control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {

        }

        /// <summary>
        /// Handles the KeyDown event of the userNameTxt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void UserNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            errorLabel.Hide();
        }

        /// <summary>
        /// Handles the KeyDown event of the passwordTxt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void PasswordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            errorLabel.Hide();
        }
    }
}
