namespace TechSupport.View
{
    /// <summary>
    /// Class representing the Incident form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class IncidentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ClearIncidentBtn = new Button();
            lblDescription = new Label();
            label2 = new Label();
            lblTitle = new Label();
            cmbCustomer = new ComboBox();
            lblProduct = new Label();
            label3 = new Label();
            lblCustomer = new Label();
            cmbProduct = new ComboBox();
            label4 = new Label();
            lblMessage = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            CreateIncidentBtn = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // ClearIncidentBtn
            // 
            ClearIncidentBtn.Location = new Point(453, 389);
            ClearIncidentBtn.Name = "ClearIncidentBtn";
            ClearIncidentBtn.Size = new Size(165, 44);
            ClearIncidentBtn.TabIndex = 40;
            ClearIncidentBtn.Text = "Clear";
            ClearIncidentBtn.UseVisualStyleBackColor = true;
            ClearIncidentBtn.Click += ClearIncidentBtn_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(210, 302);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(50, 20);
            lblDescription.TabIndex = 44;
            lblDescription.Text = "label9";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 75);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 30;
            label2.Text = "Customer";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(210, 238);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 20);
            lblTitle.TabIndex = 43;
            lblTitle.Text = "label8";
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(207, 72);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(466, 28);
            cmbCustomer.TabIndex = 31;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(210, 175);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(50, 20);
            lblProduct.TabIndex = 42;
            lblProduct.Text = "label7";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 139);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 32;
            label3.Text = "Product";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(210, 111);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(50, 20);
            lblCustomer.TabIndex = 41;
            lblCustomer.Text = "label6";
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(207, 136);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(469, 28);
            cmbProduct.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 203);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 34;
            label4.Text = "Title";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(218, 354);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(50, 20);
            lblMessage.TabIndex = 39;
            lblMessage.Text = "label6";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(207, 200);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(467, 27);
            txtTitle.TabIndex = 35;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(207, 263);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(470, 27);
            txtDescription.TabIndex = 37;
            // 
            // CreateIncidentBtn
            // 
            CreateIncidentBtn.Location = new Point(207, 389);
            CreateIncidentBtn.Name = "CreateIncidentBtn";
            CreateIncidentBtn.Size = new Size(165, 44);
            CreateIncidentBtn.TabIndex = 38;
            CreateIncidentBtn.Text = "Create Incident";
            CreateIncidentBtn.UseVisualStyleBackColor = true;
            CreateIncidentBtn.Click += CreateIncidentBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 266);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 36;
            label5.Text = "Description";
            // 
            // IncidentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClearIncidentBtn);
            Controls.Add(lblDescription);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(cmbCustomer);
            Controls.Add(lblProduct);
            Controls.Add(label3);
            Controls.Add(lblCustomer);
            Controls.Add(cmbProduct);
            Controls.Add(label4);
            Controls.Add(lblMessage);
            Controls.Add(txtTitle);
            Controls.Add(txtDescription);
            Controls.Add(CreateIncidentBtn);
            Controls.Add(label5);
            Name = "IncidentForm";
            Size = new Size(774, 548);
            Load += AddNewIncident_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearIncidentBtn;
        private Label lblDescription;
        private Label label2;
        private Label lblTitle;
        private ComboBox cmbCustomer;
        private Label lblProduct;
        private Label label3;
        private Label lblCustomer;
        private ComboBox cmbProduct;
        private Label label4;
        private Label lblMessage;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Button CreateIncidentBtn;
        private Label label5;
    }
}