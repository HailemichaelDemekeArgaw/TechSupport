﻿namespace TechSupport.View
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
            lblDescription.Location = new Point(178, 188);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(38, 15);
            lblDescription.TabIndex = 29;
            lblDescription.Text = "label9";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(178, 140);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 15);
            lblTitle.TabIndex = 28;
            lblTitle.Text = "label8";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(178, 93);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(38, 15);
            lblProduct.TabIndex = 27;
            lblProduct.Text = "label7";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(178, 45);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(38, 15);
            lblCustomer.TabIndex = 26;
            lblCustomer.Text = "label6";
            // 
            // ClearIncidentBtn
            // 
            ClearIncidentBtn.Location = new Point(393, 256);
            ClearIncidentBtn.Margin = new Padding(3, 2, 3, 2);
            ClearIncidentBtn.Name = "ClearIncidentBtn";
            ClearIncidentBtn.Size = new Size(144, 33);
            ClearIncidentBtn.TabIndex = 25;
            ClearIncidentBtn.Text = "Clear";
            ClearIncidentBtn.UseVisualStyleBackColor = true;
            ClearIncidentBtn.Click += ClearIncidentBtn_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(185, 227);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(38, 15);
            lblMessage.TabIndex = 24;
            lblMessage.Text = "label6";
            // 
            // CreateIncidentBtn
            // 
            CreateIncidentBtn.Location = new Point(178, 256);
            CreateIncidentBtn.Margin = new Padding(3, 2, 3, 2);
            CreateIncidentBtn.Name = "CreateIncidentBtn";
            CreateIncidentBtn.Size = new Size(144, 33);
            CreateIncidentBtn.TabIndex = 23;
            CreateIncidentBtn.Text = "Create Incident";
            CreateIncidentBtn.UseVisualStyleBackColor = true;
            CreateIncidentBtn.Click += CreateIncidentBtn_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(178, 161);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(412, 23);
            txtDescription.TabIndex = 22;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 161);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 21;
            label5.Text = "Description";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(178, 114);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(409, 23);
            txtTitle.TabIndex = 20;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 114);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 19;
            label4.Text = "Title";
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(178, 66);
            cmbProduct.Margin = new Padding(3, 2, 3, 2);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(411, 23);
            cmbProduct.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 66);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 17;
            label3.Text = "Product";
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(178, 18);
            cmbCustomer.Margin = new Padding(3, 2, 3, 2);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(408, 23);
            cmbCustomer.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 18);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 15;
            label2.Text = "Customer";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAddIncident);
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(656, 378);
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
            tabAddIncident.Location = new Point(4, 24);
            tabAddIncident.Margin = new Padding(3, 2, 3, 2);
            tabAddIncident.Name = "tabAddIncident";
            tabAddIncident.Padding = new Padding(3, 2, 3, 2);
            tabAddIncident.Size = new Size(648, 350);
            tabAddIncident.TabIndex = 1;
            tabAddIncident.Text = "Add";
            tabAddIncident.UseVisualStyleBackColor = true;
            // 
            // IncidentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 411);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "IncidentForm";
            StartPosition = FormStartPosition.CenterScreen;
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