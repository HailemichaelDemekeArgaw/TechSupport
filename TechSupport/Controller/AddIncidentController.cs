using TechSupport.DAL;
using TechSupport.Model;
using TechSupport.View;


namespace TechSupport.Controller

{ /// <summary>
  /// Class representing the AddIncident Controller.
  /// </summary>
    public static class AddIncidentController
    {
        public static TextBox title;
        public static TextBox description;
        public static TextBox customerId;
        public static AddIncident addIncident;
        public static Label titelErrLbl;
        public static Label descErrLbl;
        public static Label custIdErrLbl;

        /// <summary>
        /// Add button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void AddButton_Event(object sender, EventArgs e)
        {

            bool checkCustomerIdisNumeric = int.TryParse(customerId.Text, out int id);

            if (!string.IsNullOrEmpty(title.Text) && !string.IsNullOrEmpty(description.Text) && !string.IsNullOrEmpty(customerId.Text) && checkCustomerIdisNumeric == true)
            {
                Incident incident = new Incident();
                incident.Title = title.Text;
                incident.Description = description.Text;
                incident.CustomerId = Convert.ToInt16(customerId.Text);

                IncidentService incidentService = new IncidentService();
                incidentService.AddIncident(incident);
                addIncident.Close();
                MainFormController.MainDataGridBinding();
            }
            else
            {
                if (string.IsNullOrEmpty(title.Text))
                {
                    titelErrLbl.Text = "Title is required.";
                    titelErrLbl.ForeColor = Color.Red;
                    titelErrLbl.Show();
                }
                if (string.IsNullOrEmpty(description.Text))
                {
                    descErrLbl.Text = "description is required.";
                    descErrLbl.ForeColor = Color.Red;
                    descErrLbl.Show();
                }
                if (string.IsNullOrEmpty(customerId.Text))
                {

                    custIdErrLbl.Text = "CustomerId is required.";
                    custIdErrLbl.ForeColor = Color.Red;
                    custIdErrLbl.Show();
                }

                if (checkCustomerIdisNumeric == false && !string.IsNullOrEmpty(customerId.Text))
                {
                    custIdErrLbl.Text = "CustomerId is should be number.";
                    custIdErrLbl.ForeColor = Color.Red;
                    custIdErrLbl.Show();
                }
            }

        }

        /// <summary>
        /// Cancel button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void CancelButton_Event(object sender, EventArgs e)
        {
            MainFormController.dataGridView.Visible = true;
            addIncident.Close();
        }

        /// <summary>
        /// key down event for title
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void TitleKeyDown_Event(object sender, KeyEventArgs e)
        {
            titelErrLbl.Hide();
        }

        /// <summary>
        /// key down event for description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void DescKeyDown_Event(object sender, KeyEventArgs e)
        {
            descErrLbl.Hide();
        }

        /// <summary>
        /// key down event for customer id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void CustIdKeyDown_Event(object sender, KeyEventArgs e)
        {
            custIdErrLbl.Hide();
        }

    }
}
