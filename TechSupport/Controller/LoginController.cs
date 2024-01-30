using TechSupport.View;
using Application = System.Windows.Forms.Application;

namespace TechSupport.Controller
{
    static class LoginController
    {
        public static Login login;
        public static TextBox loginText;
        public static TextBox passwordText;
        public static Label errorLabel;

        /// <summary>
        /// Handles the Click event of the LoginButton control.
        /// </summary>
        /// <param name="senser"> </param>
        /// <param name="e"> </param>
        public static void LoginButton_Click(object senser, EventArgs e)
        {

            string userName = loginText.Text.ToString();
            string password = passwordText.Text.ToString();
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                if (userName == "jane" && password == "test1234")
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    mainForm.Controls["userNameLbl"].Text = userName;
                    login.Close();

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

        /// <summary>
        /// Handles the Event event of the LoginFormClosed control.
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        public static void LoginFormClosed_Event(object sender, EventArgs e)
        {
            ((Form)sender).FormClosed -= LoginFormClosed_Event;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += LoginFormClosed_Event;
        }

        /// <summary>
        /// Handles the Event event of the KeyDown control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">.</param>
        public static void KeyDown_Event(object sender, KeyEventArgs e)
        {
            errorLabel.Hide();
        }

    }
}
