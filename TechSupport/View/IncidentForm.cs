using TechSupport.Controller;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Class representing the incident form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class IncidentForm : Form
    {
        private readonly IncidentController _incidentController;
        private readonly IncidentService _incidentService;
        private readonly CustomersController _customersController;
        private readonly ProductsController _productsController;

        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentForm"/> class.
        /// </summary>
        public IncidentForm()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
            _customersController = new CustomersController();
            _productsController = new ProductsController();

            lblCustomer.Hide();
            lblProduct.Hide();
            lblTitle.Hide();
            lblDescription.Hide();
            lblMessage.Hide();
        }

        /// <summary>
        /// Products this instance.
        /// </summary>
        public void Product()
        {
            List<Products> productList;
            try
            {
                productList = this._productsController.GetProducts();
                if (productList.Count > 0)
                {
                    Products product = new Products();
                    cmbProduct.DataSource = productList;
                    cmbProduct.DisplayMember = "Name";
                    cmbProduct.ValueMember = "ProductCode";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Customers this instance.
        /// </summary>
        public void Customer()
        {
            List<Customers> customerList;
            try
            {
                customerList = this._customersController.GetCustomers();
                if (customerList.Count > 0)
                {
                    Customers customer = new Customers();
                    cmbCustomer.DataSource = customerList;
                    cmbCustomer.DisplayMember = "Name";
                    cmbCustomer.ValueMember = "CustomerID";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Handles the Load event of the AddNewIncident control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddNewIncident_Load(object sender, EventArgs e)
        {
            Customer();
            Product();
        }

        /// <summary>
        /// Handles the Click event of the CreateIncidentBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CreateIncidentBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCustomer.Text))
            {

                lblCustomer.Text = "Customer is required.";
                lblCustomer.ForeColor = Color.Red;
                lblCustomer.Show();
            }
            if (string.IsNullOrEmpty(cmbProduct.Text))
            {

                lblProduct.Text = "Product is required.";
                lblProduct.ForeColor = Color.Red;
                lblProduct.Show();
            }
            if (string.IsNullOrEmpty(txtTitle.Text))
            {

                lblTitle.Text = "Title is required.";
                lblTitle.ForeColor = Color.Red;
                lblTitle.Show();
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {

                lblDescription.Text = "description is required.";
                lblDescription.ForeColor = Color.Red;
                lblDescription.Show();
            }

            if (string.IsNullOrEmpty(cmbCustomer.Text) || string.IsNullOrEmpty(cmbProduct.Text) ||
                string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtTitle.Text))
            {
                return;
            }

            Incidents incident = new Incidents();
            incident.CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue);
            incident.ProductCode = Convert.ToString(cmbProduct.SelectedValue);
            incident.Title = txtTitle.Text;
            incident.Description = txtDescription.Text;
            lblMessage.Text = _incidentController.AddIncidentToDatabase(incident);
            lblMessage.ForeColor = Color.Green;
            lblMessage.Show();
        }

        /// <summary>
        /// Handles the Click event of the ClearIncidentBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClearIncidentBtn_Click(object sender, EventArgs e)
        {
            Customer();
            Product();
            txtTitle.Text = "";
            txtDescription.Text = "";
            lblTitle.Hide();
            lblDescription.Hide();
            lblMessage.Hide();
        }

        /// <summary>
        /// Handles the TextChanged event of the txtTitle control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            lblTitle.Hide();
        }

        /// <summary>
        /// Handles the TextChanged event of the txtDescription control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <returns></returns>
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            lblDescription.Hide();
        }
    }
}
