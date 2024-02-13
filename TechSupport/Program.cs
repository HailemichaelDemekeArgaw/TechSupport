using TechSupport.Controller;
using TechSupport.View;

namespace TechSupport
{
    /// <summary>
    /// Application Entry Point.
    /// </summary>
    internal static class Program
    {

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var loginForm = new Login();
            loginForm.Show();
            Application.Run();
        }
    }
}