namespace TechSupport.View
{
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
            lblDescription = new Label();
            lblTitle = new Label();
            lblProduct = new Label();
            lblCustomer = new Label();
            ClearIncidentBtn = new Button();
            lblMessage = new Label();
            CreateIncidentBtn = new Button();
            txtDescription = new TextBox();
            label5 = new Label();
            txtTitle = new TextBox();
            label4 = new Label();
            cmbProduct = new ComboBox();
            label3 = new Label();
            cmbCustomer = new ComboBox();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabAddIncident = new TabPage();
            tabControl1.SuspendLayout();
            tabAddIncident.SuspendLayout();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(204, 250);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(50, 20);
            lblDescription.TabIndex = 29;
            lblDescription.Text = "label9";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(204, 187);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 20);
            lblTitle.TabIndex = 28;
            lblTitle.Text = "label8";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(204, 124);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(50, 20);
            lblProduct.TabIndex = 27;
            lblProduct.Text = "label7";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(204, 60);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(50, 20);
            lblCustomer.TabIndex = 26;
            lblCustomer.Text = "label6";
            // 
            // ClearIncidentBtn
            // 
            ClearIncidentBtn.Location = new Point(351, 341);
            ClearIncidentBtn.Name = "ClearIncidentBtn";
            ClearIncidentBtn.Size = new Size(165, 44);
            ClearIncidentBtn.TabIndex = 25;
            ClearIncidentBtn.Text = "Clear";
            ClearIncidentBtn.UseVisualStyleBackColor = true;
            ClearIncidentBtn.Click += ClearIncidentBtn_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(211, 303);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(50, 20);
            lblMessage.TabIndex = 24;
            lblMessage.Text = "label6";
            // 
            // CreateIncidentBtn
            // 
            CreateIncidentBtn.Location = new Point(133, 341);
            CreateIncidentBtn.Name = "CreateIncidentBtn";
            CreateIncidentBtn.Size = new Size(165, 44);
            CreateIncidentBtn.TabIndex = 23;
            CreateIncidentBtn.Text = "Create Incident";
            CreateIncidentBtn.UseVisualStyleBackColor = true;
            CreateIncidentBtn.Click += CreateIncidentBtn_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(204, 215);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(470, 27);
            txtDescription.TabIndex = 22;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 215);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 21;
            label5.Text = "Description";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(204, 152);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(467, 27);
            txtTitle.TabIndex = 20;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 152);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 19;
            label4.Text = "Title";
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(204, 88);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(469, 28);
            cmbProduct.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 88);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 17;
            label3.Text = "Product";
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(204, 24);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(466, 28);
            cmbCustomer.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 24);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 15;
            label2.Text = "Customer";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAddIncident);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(863, 504);
            tabControl1.TabIndex = 30;
            // 
            // tabAddIncident
            // 
            tabAddIncident.Controls.Add(ClearIncidentBtn);
            tabAddIncident.Controls.Add(lblDescription);
            tabAddIncident.Controls.Add(label2);
            tabAddIncident.Controls.Add(lblTitle);
            tabAddIncident.Controls.Add(cmbCustomer);
            tabAddIncident.Controls.Add(lblProduct);
            tabAddIncident.Controls.Add(label3);
            tabAddIncident.Controls.Add(lblCustomer);
            tabAddIncident.Controls.Add(cmbProduct);
            tabAddIncident.Controls.Add(label4);
            tabAddIncident.Controls.Add(lblMessage);
            tabAddIncident.Controls.Add(txtTitle);
            tabAddIncident.Controls.Add(CreateIncidentBtn);
            tabAddIncident.Controls.Add(label5);
            tabAddIncident.Controls.Add(txtDescription);
            tabAddIncident.Location = new Point(4, 29);
            tabAddIncident.Name = "tabAddIncident";
            tabAddIncident.Padding = new Padding(3);
            tabAddIncident.Size = new Size(855, 471);
            tabAddIncident.TabIndex = 1;
            tabAddIncident.Text = "Add";
            tabAddIncident.UseVisualStyleBackColor = true;
            // 
            // IncidentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 548);
            Controls.Add(tabControl1);
            Name = "IncidentForm";
            Text = "Add Incident";
            Load += AddNewIncident_Load;
            tabControl1.ResumeLayout(false);
            tabAddIncident.ResumeLayout(false);
            tabAddIncident.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDescription;
        private Label lblTitle;
        private Label lblProduct;
        private Label lblCustomer;
        private Button ClearIncidentBtn;
        private Label lblMessage;
        private Button CreateIncidentBtn;
        private TextBox txtDescription;
        private Label label5;
        private TextBox txtTitle;
        private Label label4;
        private ComboBox cmbProduct;
        private Label label3;
        private ComboBox cmbCustomer;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabAddIncident;
    }
}