namespace TechSupport.View
{
    partial class UpdateIncidentUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMessage = new Label();
            BtnClear = new Button();
            BtnClose = new Button();
            BtnUpdate = new Button();
            txtTextAddOn = new TextBox();
            lblTextAddOn = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtDateOpen = new TextBox();
            lblDate = new Label();
            txtTitle = new TextBox();
            lblTitle = new Label();
            cmbTechnician = new ComboBox();
            lblTechncian = new Label();
            txtProduct = new TextBox();
            lblProduct = new Label();
            txtCustomer = new TextBox();
            lblCusotmer = new Label();
            BtnGet = new Button();
            txtIncidentId = new TextBox();
            lblIncidentId = new Label();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(150, 402);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 48;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(430, 413);
            BtnClear.Margin = new Padding(3, 2, 3, 2);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(116, 26);
            BtnClear.TabIndex = 47;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnClose
            // 
            BtnClose.Enabled = false;
            BtnClose.Location = new Point(287, 413);
            BtnClose.Margin = new Padding(3, 2, 3, 2);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(116, 26);
            BtnClose.TabIndex = 46;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Enabled = false;
            BtnUpdate.Location = new Point(144, 413);
            BtnUpdate.Margin = new Padding(3, 2, 3, 2);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(116, 26);
            BtnUpdate.TabIndex = 45;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // txtTextAddOn
            // 
            txtTextAddOn.Location = new Point(142, 314);
            txtTextAddOn.Margin = new Padding(3, 2, 3, 2);
            txtTextAddOn.Multiline = true;
            txtTextAddOn.Name = "txtTextAddOn";
            txtTextAddOn.ReadOnly = true;
            txtTextAddOn.Size = new Size(451, 69);
            txtTextAddOn.TabIndex = 44;
            // 
            // lblTextAddOn
            // 
            lblTextAddOn.AutoSize = true;
            lblTextAddOn.Location = new Point(45, 314);
            lblTextAddOn.Name = "lblTextAddOn";
            lblTextAddOn.Size = new Size(73, 15);
            lblTextAddOn.TabIndex = 43;
            lblTextAddOn.Text = "Text Add on:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(142, 242);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(451, 57);
            txtDescription.TabIndex = 42;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(45, 242);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 41;
            lblDescription.Text = "Description:";
            // 
            // txtDateOpen
            // 
            txtDateOpen.Location = new Point(142, 206);
            txtDateOpen.Margin = new Padding(3, 2, 3, 2);
            txtDateOpen.Name = "txtDateOpen";
            txtDateOpen.ReadOnly = true;
            txtDateOpen.Size = new Size(451, 23);
            txtDateOpen.TabIndex = 40;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(45, 205);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(66, 15);
            lblDate.TabIndex = 39;
            lblDate.Text = "Date Open:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(142, 170);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(451, 23);
            txtTitle.TabIndex = 38;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(45, 169);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 37;
            lblTitle.Text = "Title:";
            // 
            // cmbTechnician
            // 
            cmbTechnician.FormattingEnabled = true;
            cmbTechnician.Location = new Point(142, 133);
            cmbTechnician.Margin = new Padding(3, 2, 3, 2);
            cmbTechnician.Name = "cmbTechnician";
            cmbTechnician.Size = new Size(451, 23);
            cmbTechnician.TabIndex = 36;
            // 
            // lblTechncian
            // 
            lblTechncian.AutoSize = true;
            lblTechncian.Location = new Point(45, 133);
            lblTechncian.Name = "lblTechncian";
            lblTechncian.Size = new Size(63, 15);
            lblTechncian.TabIndex = 35;
            lblTechncian.Text = "Techncian:";
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(142, 97);
            txtProduct.Margin = new Padding(3, 2, 3, 2);
            txtProduct.Name = "txtProduct";
            txtProduct.ReadOnly = true;
            txtProduct.Size = new Size(451, 23);
            txtProduct.TabIndex = 34;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(45, 97);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(45, 15);
            lblProduct.TabIndex = 33;
            lblProduct.Text = "Prodct:";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(142, 61);
            txtCustomer.Margin = new Padding(3, 2, 3, 2);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(451, 23);
            txtCustomer.TabIndex = 32;
            // 
            // lblCusotmer
            // 
            lblCusotmer.AutoSize = true;
            lblCusotmer.Location = new Point(45, 61);
            lblCusotmer.Name = "lblCusotmer";
            lblCusotmer.Size = new Size(62, 15);
            lblCusotmer.TabIndex = 31;
            lblCusotmer.Text = "Customer:";
            // 
            // BtnGet
            // 
            BtnGet.Location = new Point(503, 23);
            BtnGet.Margin = new Padding(3, 2, 3, 2);
            BtnGet.Name = "BtnGet";
            BtnGet.Size = new Size(66, 22);
            BtnGet.TabIndex = 30;
            BtnGet.Text = "Get";
            BtnGet.UseVisualStyleBackColor = true;
            BtnGet.Click += BtnGet_Click;
            // 
            // txtIncidentId
            // 
            txtIncidentId.Location = new Point(142, 25);
            txtIncidentId.Margin = new Padding(3, 2, 3, 2);
            txtIncidentId.Name = "txtIncidentId";
            txtIncidentId.Size = new Size(327, 23);
            txtIncidentId.TabIndex = 29;
            txtIncidentId.TextChanged += TxtIncidentId_TextChanged;
            // 
            // lblIncidentId
            // 
            lblIncidentId.AutoSize = true;
            lblIncidentId.Location = new Point(45, 25);
            lblIncidentId.Name = "lblIncidentId";
            lblIncidentId.Size = new Size(67, 15);
            lblIncidentId.TabIndex = 28;
            lblIncidentId.Text = "Incident ID:";
            // 
            // UpdateIncidentUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMessage);
            Controls.Add(BtnClear);
            Controls.Add(BtnClose);
            Controls.Add(BtnUpdate);
            Controls.Add(txtTextAddOn);
            Controls.Add(lblTextAddOn);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtDateOpen);
            Controls.Add(lblDate);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(cmbTechnician);
            Controls.Add(lblTechncian);
            Controls.Add(txtProduct);
            Controls.Add(lblProduct);
            Controls.Add(txtCustomer);
            Controls.Add(lblCusotmer);
            Controls.Add(BtnGet);
            Controls.Add(txtIncidentId);
            Controls.Add(lblIncidentId);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UpdateIncidentUC";
            Size = new Size(657, 453);
            Load += UpdateIncidentUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Button BtnClear;
        private Button BtnClose;
        private Button BtnUpdate;
        private TextBox txtTextAddOn;
        private Label lblTextAddOn;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtDateOpen;
        private Label lblDate;
        private TextBox txtTitle;
        private Label lblTitle;
        private ComboBox cmbTechnician;
        private Label lblTechncian;
        private TextBox txtProduct;
        private Label lblProduct;
        private TextBox txtCustomer;
        private Label lblCusotmer;
        private Button BtnGet;
        private TextBox txtIncidentId;
        private Label lblIncidentId;
    }
}
