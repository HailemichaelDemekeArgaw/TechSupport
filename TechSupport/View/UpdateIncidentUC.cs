using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Class representing the Update Incidnet UI.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class UpdateIncidentUC : UserControl
    {
        private readonly IncidentController _incidentController;
        private readonly TechniciansController _techniciansController;
        public UpdateIncidentUC()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
            this._techniciansController = new TechniciansController();

            cmbTechnician.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTextAddOn.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnClose.Enabled = false;
            lblMessage.Visible = false;
            this.BackColor = Color.LightGray;
        }

        /// <summary>
        /// Technicians this instance.
        /// </summary>
        public void Technician()
        {
            List<Technicians> technicianList;
            try
            {
                technicianList = this._techniciansController.GetTechnicians();
                if (technicianList.Count > 0)
                {
                    Technicians technicians = new Technicians();

                    technicians.Name = "-- Unassigned --";
                    technicianList.Insert(0, technicians);
                    cmbTechnician.DataSource = technicianList;
                    cmbTechnician.DisplayMember = "Name";
                    cmbTechnician.ValueMember = "TechId";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Clears the fields.
        /// </summary>
        public void ClearFields()
        {
            txtCustomer.Text = "";
            txtProduct.Text = "";

            Technician();
            //txtIncidentId.Text = "";
            txtDateOpen.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtTextAddOn.Text = "";
            txtTextAddOn.Enabled = false;
            txtTextAddOn.ReadOnly = true;
            BtnUpdate.Enabled = false;
            BtnClose.Enabled = false;

        }

        /// <summary>
        /// Handles the Click event of the BtnGet control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGet_Click(object sender, EventArgs e)
        {
            ClearFields();
            if (txtIncidentId.Text.Trim().Length > 0)
            {
                SearchIncidentVM searchIncident = _incidentController.SearchIncidentList(Convert.ToInt32(txtIncidentId.Text));
                if (searchIncident != null)
                {
                    txtCustomer.Text = searchIncident.Customer;
                    txtProduct.Text = searchIncident.ProductCode;
                    if (searchIncident.TechId != null)
                    {
                        cmbTechnician.Text = searchIncident.Technician;
                        cmbTechnician.SelectedValue = searchIncident.TechId;
                    }

                    txtDateOpen.Text = Convert.ToDateTime(searchIncident.DatedOpened).ToString("MM/dd/yyyy");
                    txtTitle.Text = searchIncident.Title;
                    txtDescription.Text = searchIncident.Description;
                    txtTextAddOn.ReadOnly = false;
                    txtTextAddOn.Enabled = true;
                    BtnUpdate.Enabled = true;
                    BtnClose.Enabled = true;

                }
                else
                {
                    MessageBox.Show("No incident found by this id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                }

            }
            else
            {

                MessageBox.Show("Please specify Incident ID", "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Handles the Click event of the BtnUpdate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //check incident is closed

            SearchIncidentVM searchIncident = _incidentController.SearchIncidentList(Convert.ToInt16(txtIncidentId.Text));

            if (searchIncident.DateClosed != null)
            {
                MessageBox.Show("You can't modify closed incident!", "Incident Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //check change is made on update

            if (searchIncident.Description == (txtDescription.Text.Trim() + " " + txtTextAddOn.Text.Trim()).Trim() && searchIncident.TechId == Convert.ToInt16(cmbTechnician.SelectedValue))
            {
                MessageBox.Show("Please made change before update.", "Incident Update", MessageBoxButtons.OK);
                return;
            }


            //-----------checking Description already 200 character length
            if (txtDescription.Text.Trim().Length > 200)
            {
                MessageBox.Show("Description chararcter more than 200 characters, you can't add more charcter.", "Descrption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            // ----------concatenate texet description , text add on and date and check lengeth of description character  is >200
            string description = txtDescription.Text.Trim();
            if (txtTextAddOn.Text.Trim().Length > 0)
            {
                description = description + Environment.NewLine + txtTextAddOn.Text.Trim() + " " + DateTime.Now.ToLongDateString();
            }

            if (description.Length > 200)
            {
                if (MessageBox.Show("Description chararcter more than 200 character, Do you wont truncket?", "Descrption Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    description = description.Substring(0, 200);
                }
                else
                {
                    return;
                }

            }
            Incidents incidents = new Incidents();

            incidents.IncidentID = Convert.ToInt16(txtIncidentId.Text);
            incidents.ProductCode = searchIncident.ProductCode;
            incidents.CustomerId = searchIncident.CustomerId;
            incidents.TechId = Convert.ToInt16(cmbTechnician.SelectedValue);
            incidents.DateOpened = searchIncident.DatedOpened;
            incidents.Description = description;
            txtDescription.Text = description;
            if (searchIncident.TechId == (incidents.TechId == 0 ? null : incidents.TechId)  && string.IsNullOrEmpty(txtTextAddOn.Text))
            {
                MessageBox.Show("You didn't make any change in form could not be update.", "No Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string message = _incidentController.UpdateIncidents(incidents);
            MessageBox.Show(message, "Update Incident", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTextAddOn.Text = "";
        }

        /// <summary>
        /// Handles the Click event of the BtnClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (cmbTechnician.Text == "-- Unassigned --" || cmbTechnician.SelectedValue == null)
            {
                MessageBox.Show("Please select technician befor closing incidet!", "Closing Incident", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SearchIncidentVM searchIncident = _incidentController.SearchIncidentList(Convert.ToInt16(txtIncidentId.Text));
            if (searchIncident.DateClosed != null)
            {
                MessageBox.Show("You can't Close already closed incident!", "Incident Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string description = txtDescription.Text.Trim();
            if (txtTextAddOn.Text.Trim().Length > 0)
            {
                description = description + Environment.NewLine + txtTextAddOn.Text.Trim() + " " + DateTime.Now.ToLongDateString();
            }

            if (description.Length > 200)
            {
                if (MessageBox.Show("Description chararcter more than 200 character, Do you wont truncket?", "Descrption Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    description = description.Substring(0, 200);
                }
                else
                {
                    return;
                }

            }


            Incidents incidents = new Incidents();
            incidents.IncidentID = Convert.ToInt16(txtIncidentId.Text);
            incidents.ProductCode = searchIncident.ProductCode;
            incidents.TechId = Convert.ToInt16(cmbTechnician.SelectedValue);
            incidents.DateOpened = searchIncident.DatedOpened;
            incidents.Description = description;

            string message = _incidentController.CloseIncidents(incidents);
            MessageBox.Show(message, "Incident Close", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        /// <summary>
        /// Handles the Click event of the BtnClear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        /// <summary>
        /// Handles the TextChanged event of the TxtIncidentId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtIncidentId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtIncidentId.Text);
            }
            catch (Exception)
            {
                ClearFields();
            }
        }

        /// <summary>
        /// Handles the Load event of the UpdateIncidentUC control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void UpdateIncidentUC_Load(object sender, EventArgs e)
        {
            Technician();
        }
    }
}
