using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Represents class for the Add Incident form.
    /// </summary>
    partial class AddIncident
    {

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Initializes the component.
        /// </summary>
        private void InitializeComponent()
        {
            addHeaderLbl = new Label();
            titleLbl = new Label();
            titleTxt = new TextBox();
            descLbl = new Label();
            descTxt = new TextBox();
            custIdLbl = new Label();
            custIdTxt = new TextBox();
            addBtn = new Button();
            cancelBtn = new Button();
            TitleErrMsg = new Label();
            DescErrMsg = new Label();
            CustIdErrMsg = new Label();
            messageLabel = new Label();
            SuspendLayout();
            // 
            // addHeaderLbl
            // 
            addHeaderLbl.AutoSize = true;
            addHeaderLbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            addHeaderLbl.Location = new Point(219, 21);
            addHeaderLbl.Margin = new Padding(2, 0, 2, 0);
            addHeaderLbl.Name = "addHeaderLbl";
            addHeaderLbl.Size = new Size(127, 25);
            addHeaderLbl.TabIndex = 0;
            addHeaderLbl.Text = "Add Incident";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 10F);
            titleLbl.Location = new Point(74, 60);
            titleLbl.Margin = new Padding(2, 0, 2, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(34, 19);
            titleLbl.TabIndex = 6;
            titleLbl.Text = "Title";
            // 
            // titleTxt
            // 
            titleTxt.Font = new Font("Segoe UI", 10F);
            titleTxt.Location = new Point(185, 60);
            titleTxt.Margin = new Padding(2);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(237, 25);
            titleTxt.TabIndex = 1;
            titleTxt.TextChanged += titleTxt_TextChanged;
            titleTxt.KeyDown += titleTxt_KeyDown;
            // 
            // descLbl
            // 
            descLbl.AutoSize = true;
            descLbl.Font = new Font("Segoe UI", 10F);
            descLbl.Location = new Point(74, 100);
            descLbl.Margin = new Padding(2, 0, 2, 0);
            descLbl.Name = "descLbl";
            descLbl.Size = new Size(78, 19);
            descLbl.TabIndex = 8;
            descLbl.Text = "Description";
            // 
            // descTxt
            // 
            descTxt.Font = new Font("Segoe UI", 10F);
            descTxt.Location = new Point(185, 100);
            descTxt.Margin = new Padding(2);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(237, 25);
            descTxt.TabIndex = 2;
            descTxt.KeyDown += descTxt_KeyDown;
            // 
            // custIdLbl
            // 
            custIdLbl.AutoSize = true;
            custIdLbl.Font = new Font("Segoe UI", 10F);
            custIdLbl.Location = new Point(74, 142);
            custIdLbl.Margin = new Padding(2, 0, 2, 0);
            custIdLbl.Name = "custIdLbl";
            custIdLbl.Size = new Size(85, 19);
            custIdLbl.TabIndex = 10;
            custIdLbl.Text = "Customer Id";
            // 
            // custIdTxt
            // 
            custIdTxt.Font = new Font("Segoe UI", 10F);
            custIdTxt.Location = new Point(185, 141);
            custIdTxt.Margin = new Padding(2);
            custIdTxt.Name = "custIdTxt";
            custIdTxt.Size = new Size(237, 25);
            custIdTxt.TabIndex = 3;
            custIdTxt.KeyDown += custIdTxt_KeyDown;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.Window;
            addBtn.Location = new Point(162, 215);
            addBtn.Margin = new Padding(2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(104, 32);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = SystemColors.ButtonHighlight;
            cancelBtn.Location = new Point(285, 215);
            cancelBtn.Margin = new Padding(2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(104, 32);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // TitleErrMsg
            // 
            TitleErrMsg.AutoSize = true;
            TitleErrMsg.ForeColor = SystemColors.ControlText;
            TitleErrMsg.Location = new Point(185, 84);
            TitleErrMsg.Margin = new Padding(2, 0, 2, 0);
            TitleErrMsg.Name = "TitleErrMsg";
            TitleErrMsg.Size = new Size(38, 15);
            TitleErrMsg.TabIndex = 7;
            TitleErrMsg.Text = "label5";
            // 
            // DescErrMsg
            // 
            DescErrMsg.AutoSize = true;
            DescErrMsg.ForeColor = SystemColors.ControlText;
            DescErrMsg.Location = new Point(185, 124);
            DescErrMsg.Margin = new Padding(2, 0, 2, 0);
            DescErrMsg.Name = "DescErrMsg";
            DescErrMsg.Size = new Size(38, 15);
            DescErrMsg.TabIndex = 9;
            DescErrMsg.Text = "label6";
            // 
            // CustIdErrMsg
            // 
            CustIdErrMsg.AutoSize = true;
            CustIdErrMsg.ForeColor = SystemColors.ControlText;
            CustIdErrMsg.Location = new Point(185, 165);
            CustIdErrMsg.Margin = new Padding(2, 0, 2, 0);
            CustIdErrMsg.Name = "CustIdErrMsg";
            CustIdErrMsg.Size = new Size(38, 15);
            CustIdErrMsg.TabIndex = 11;
            CustIdErrMsg.Text = "label7";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new Point(185, 192);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(0, 15);
            messageLabel.TabIndex = 12;
            // 
            // AddIncident
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 265);
            Controls.Add(messageLabel);
            Controls.Add(CustIdErrMsg);
            Controls.Add(DescErrMsg);
            Controls.Add(TitleErrMsg);
            Controls.Add(cancelBtn);
            Controls.Add(addBtn);
            Controls.Add(custIdTxt);
            Controls.Add(custIdLbl);
            Controls.Add(descTxt);
            Controls.Add(descLbl);
            Controls.Add(titleTxt);
            Controls.Add(titleLbl);
            Controls.Add(addHeaderLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddIncident";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Incident";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label addHeaderLbl;
        private Label titleLbl;
        private TextBox titleTxt;
        private Label descLbl;
        private TextBox descTxt;
        private Label custIdLbl;
        private TextBox custIdTxt;
        private Button addBtn;
        private Button cancelBtn;
        private Label TitleErrMsg;
        private Label DescErrMsg;
        private Label CustIdErrMsg;
        private Label messageLabel;
    }
}