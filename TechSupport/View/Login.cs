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
            userNameTxt.KeyDown += LoginController.KeyDown_Event;
            passwordTxt.KeyDown += LoginController.KeyDown_Event;
            submitBtn.Click += LoginController.LoginButton_Click;
            errorLabel.Hide();
            LoginController.errorLabel = errorLabel;
            LoginController.loginText = userNameTxt;
            LoginController.passwordText = passwordTxt;
            LoginController.login = this;
        }
    }
}
