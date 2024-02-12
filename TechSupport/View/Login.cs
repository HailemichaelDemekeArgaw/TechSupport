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
            //userNameTxt.KeyDown += LoginController.KeyDown_Event;
            //passwordTxt.KeyDown += LoginController.KeyDown_Event;
            //submitBtn.Click += LoginController.LoginButton_Click;
            //errorLabel.Hide();
            //LoginController.errorLabel = errorLabel;
            //LoginController.loginText = userNameTxt;
            //LoginController.passwordText = passwordTxt;
            //LoginController.login = this;
        }

        private void submitBtn_Click(object sender, EventArgs e)
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

        private void Login_Load(object sender, EventArgs e)
        {
            errorLabel.Hide();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void userNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            errorLabel.Hide();
        }

        private void passwordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            errorLabel.Hide();
        }
    }
}
