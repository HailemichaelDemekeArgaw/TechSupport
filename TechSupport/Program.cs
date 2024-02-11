using TechSupport.Controller;
using TechSupport.View;

namespace TechSupport
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var loginForm = new Login();
            //loginForm.FormClosed += LoginController.LoginFormClosed_Event;
            loginForm.Show();
            Application.Run();
        }
    }
}