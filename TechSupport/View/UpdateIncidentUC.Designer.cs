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
            label8 = new Label();
            txtDescription = new TextBox();
            label7 = new Label();
            txtDateOpen = new TextBox();
            label6 = new Label();
            txtTitle = new TextBox();
            label5 = new Label();
            cmbTechnician = new ComboBox();
            label4 = new Label();
            txtProduct = new TextBox();
            label3 = new Label();
            txtCustomer = new TextBox();
            label2 = new Label();
            BtnGet = new Button();
            txtIncidentId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(171, 536);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 48;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(492, 551);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(133, 34);
            BtnClear.TabIndex = 47;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnClose
            // 
            BtnClose.Enabled = false;
            BtnClose.Location = new Point(328, 551);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(133, 34);
            BtnClose.TabIndex = 46;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Enabled = false;
            BtnUpdate.Location = new Point(164, 551);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(133, 34);
            BtnUpdate.TabIndex = 45;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // txtTextAddOn
            // 
            txtTextAddOn.Location = new Point(162, 418);
            txtTextAddOn.Multiline = true;
            txtTextAddOn.Name = "txtTextAddOn";
            txtTextAddOn.ReadOnly = true;
            txtTextAddOn.Size = new Size(515, 91);
            txtTextAddOn.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 418);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 43;
            label8.Text = "Text Add on:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(162, 322);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(515, 75);
            txtDescription.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 322);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 41;
            label7.Text = "Description:";
            // 
            // txtDateOpen
            // 
            txtDateOpen.Location = new Point(162, 274);
            txtDateOpen.Name = "txtDateOpen";
            txtDateOpen.ReadOnly = true;
            txtDateOpen.Size = new Size(515, 27);
            txtDateOpen.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 273);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 39;
            label6.Text = "Date Open:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(162, 226);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(515, 27);
            txtTitle.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 225);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 37;
            label5.Text = "Title:";
            // 
            // cmbTechnician
            // 
            cmbTechnician.FormattingEnabled = true;
            cmbTechnician.Location = new Point(162, 177);
            cmbTechnician.Name = "cmbTechnician";
            cmbTechnician.Size = new Size(515, 28);
            cmbTechnician.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 177);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 35;
            label4.Text = "Techncian:";
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(162, 129);
            txtProduct.Name = "txtProduct";
            txtProduct.ReadOnly = true;
            txtProduct.Size = new Size(515, 27);
            txtProduct.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 129);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 33;
            label3.Text = "Prodct:";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(162, 81);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(515, 27);
            txtCustomer.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 81);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 31;
            label2.Text = "Customer:";
            // 
            // BtnGet
            // 
            BtnGet.Location = new Point(575, 31);
            BtnGet.Name = "BtnGet";
            BtnGet.Size = new Size(76, 29);
            BtnGet.TabIndex = 30;
            BtnGet.Text = "Get";
            BtnGet.UseVisualStyleBackColor = true;
            BtnGet.Click += BtnGet_Click;
            // 
            // txtIncidentId
            // 
            txtIncidentId.Location = new Point(162, 33);
            txtIncidentId.Name = "txtIncidentId";
            txtIncidentId.Size = new Size(373, 27);
            txtIncidentId.TabIndex = 29;
            txtIncidentId.TextChanged += TxtIncidentId_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 33);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 28;
            label1.Text = "Incident ID:";
            // 
            // UpdateIncidentUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMessage);
            Controls.Add(BtnClear);
            Controls.Add(BtnClose);
            Controls.Add(BtnUpdate);
            Controls.Add(txtTextAddOn);
            Controls.Add(label8);
            Controls.Add(txtDescription);
            Controls.Add(label7);
            Controls.Add(txtDateOpen);
            Controls.Add(label6);
            Controls.Add(txtTitle);
            Controls.Add(label5);
            Controls.Add(cmbTechnician);
            Controls.Add(label4);
            Controls.Add(txtProduct);
            Controls.Add(label3);
            Controls.Add(txtCustomer);
            Controls.Add(label2);
            Controls.Add(BtnGet);
            Controls.Add(txtIncidentId);
            Controls.Add(label1);
            Name = "UpdateIncidentUC";
            Size = new Size(751, 604);
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
        private Label label8;
        private TextBox txtDescription;
        private Label label7;
        private TextBox txtDateOpen;
        private Label label6;
        private TextBox txtTitle;
        private Label label5;
        private ComboBox cmbTechnician;
        private Label label4;
        private TextBox txtProduct;
        private Label label3;
        private TextBox txtCustomer;
        private Label label2;
        private Button BtnGet;
        private TextBox txtIncidentId;
        private Label label1;
    }
}
