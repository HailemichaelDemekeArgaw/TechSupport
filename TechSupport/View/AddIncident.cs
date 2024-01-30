using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Class reprsenting the Add Incident Form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddIncident : Form
    {
        public AddIncident()
        {
            InitializeComponent();
            titleTxt.KeyDown += AddIncidentController.TitleKeyDown_Event;
            descTxt.KeyDown += AddIncidentController.DescKeyDown_Event;
            custIdTxt.KeyDown += AddIncidentController.CustIdKeyDown_Event;
            addBtn.Click += AddIncidentController.AddButton_Event;
            cancelBtn.Click += AddIncidentController.CancelButton_Event;
            TitleErrMsg.Hide();
            DescErrMsg.Hide();
            CustIdErrMsg.Hide();
            AddIncidentController.title = titleTxt;
            AddIncidentController.description = descTxt;
            AddIncidentController.customerId = custIdTxt;
            AddIncidentController.addIncident = this;
            AddIncidentController.titelErrLbl = TitleErrMsg;
            AddIncidentController.descErrLbl = DescErrMsg;
            AddIncidentController.custIdErrLbl = CustIdErrMsg;
        }
    }
}
