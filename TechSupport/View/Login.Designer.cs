namespace TechSupport.View
{
    /// <summary>
    /// Represents the Login Form
    /// </summary>
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            userNameLbl = new Label();
            passwordLbl = new Label();
            userNameTxt = new TextBox();
            passwordTxt = new TextBox();
            headerLbl = new Label();
            submitBtn = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Font = new Font("Segoe UI", 12F);
            userNameLbl.Location = new Point(103, 126);
            userNameLbl.Margin = new Padding(2, 0, 2, 0);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(108, 28);
            userNameLbl.TabIndex = 4;
            userNameLbl.Text = "User Name";

            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Segoe UI", 12F);
            passwordLbl.Location = new Point(103, 177);
            passwordLbl.Margin = new Padding(2, 0, 2, 0);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(93, 28);
            passwordLbl.TabIndex = 5;
            passwordLbl.Text = "Password";

            // 
            // userNameTxt
            // 
            userNameTxt.Font = new Font("Segoe UI", 12F);
            userNameTxt.Location = new Point(230, 126);
            userNameTxt.Margin = new Padding(2);
            userNameTxt.Name = "userNameTxt";
            userNameTxt.Size = new Size(233, 34);
            userNameTxt.TabIndex = 1;
            userNameTxt.KeyDown += UserNameTxt_KeyDown;

            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Segoe UI", 12F);
            passwordTxt.Location = new Point(230, 181);
            passwordTxt.Margin = new Padding(2);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(233, 34);
            passwordTxt.TabIndex = 2;
            passwordTxt.KeyDown += PasswordTxt_KeyDown;

            // 
            // headerLbl
            // 
            headerLbl.AutoSize = true;
            headerLbl.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            headerLbl.Location = new Point(230, 36);
            headerLbl.Margin = new Padding(2, 0, 2, 0);
            headerLbl.Name = "headerLbl";
            headerLbl.Size = new Size(130, 50);
            headerLbl.TabIndex = 0;
            headerLbl.Text = "Login ";

            // 
            // submitBtn
            // 
            submitBtn.BackColor = SystemColors.Control;
            submitBtn.Font = new Font("Segoe UI", 12F);
            submitBtn.Location = new Point(227, 265);
            submitBtn.Margin = new Padding(2);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(146, 42);
            submitBtn.TabIndex = 3;
            submitBtn.Text = "Login";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += SubmitBtn_Click;

            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = SystemColors.ControlText;
            errorLabel.Location = new Point(230, 229);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(50, 20);
            errorLabel.TabIndex = 6;
            errorLabel.Text = "label4";

            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(582, 353);
            Controls.Add(errorLabel);
            Controls.Add(submitBtn);
            Controls.Add(headerLbl);
            Controls.Add(passwordTxt);
            Controls.Add(userNameTxt);
            Controls.Add(passwordLbl);
            Controls.Add(userNameLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label userNameLbl;
        private Label passwordLbl;
        private TextBox userNameTxt;
        private TextBox passwordTxt;
        private Label headerLbl;
        private Button submitBtn;
        private Label errorLabel;
    }
}