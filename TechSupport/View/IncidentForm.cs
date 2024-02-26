using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.DAL;
using TechSupport.Model;


namespace TechSupport.View
{
    public partial class IncidentForm : Form
    {
        private readonly IncidentController _incidentController;
        private readonly IncidentService _incidentService;
        private readonly CustomersController _customersController;
        private readonly ProductsController _productsController;

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


        private void AddNewIncident_Load(object sender, EventArgs e)
        {
            Customer();
            Product();
        }

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
        }

        private void ClearIncidentBtn_Click(object sender, EventArgs e)
        {
            Customer();
            Product();
            txtTitle.Text = "";
            txtDescription.Text = "";
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            lblTitle.Hide();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Hide();
        }
    }
}
