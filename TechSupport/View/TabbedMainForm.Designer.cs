namespace TechSupport.View
{
    partial class TabbedMainForm
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
            tabControl = new TabControl();
            openIncident = new TabPage();
            openIncidentuc1 = new OpenIncidentUC();
            tabAdd = new TabPage();
            IncidentForm = new IncidentForm();
            updateIncident = new TabPage();
            updateIncidentuc1 = new UpdateIncidentUC();
            userNameLbl = new Label();
            logoutLink = new LinkLabel();
            tabControl.SuspendLayout();
            openIncident.SuspendLayout();
            tabAdd.SuspendLayout();
            updateIncident.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(openIncident);
            tabControl.Controls.Add(tabAdd);
            tabControl.Controls.Add(updateIncident);
            tabControl.Location = new Point(63, 68);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1065, 705);
            tabControl.TabIndex = 1;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // openIncident
            // 
            openIncident.Controls.Add(openIncidentuc1);
            openIncident.Location = new Point(4, 29);
            openIncident.Margin = new Padding(3, 4, 3, 4);
            openIncident.Name = "openIncident";
            openIncident.Padding = new Padding(3, 4, 3, 4);
            openIncident.Size = new Size(1057, 672);
            openIncident.TabIndex = 3;
            openIncident.Text = "Display Open Incident";
            openIncident.UseVisualStyleBackColor = true;
            // 
            // openIncidentuc1
            // 
            openIncidentuc1.Location = new Point(3, 7);
            openIncidentuc1.Name = "openIncidentuc1";
            openIncidentuc1.Size = new Size(1061, 443);
            openIncidentuc1.TabIndex = 0;
            // 
            // tabAdd
            // 
            tabAdd.Controls.Add(IncidentForm);
            tabAdd.Location = new Point(4, 29);
            tabAdd.Margin = new Padding(3, 4, 3, 4);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3, 4, 3, 4);
            tabAdd.Size = new Size(1057, 672);
            tabAdd.TabIndex = 4;
            tabAdd.Text = "Add";
            tabAdd.UseVisualStyleBackColor = true;
            // 
            // IncidentForm
            // 
            IncidentForm.Location = new Point(3, 7);
            IncidentForm.Name = "IncidentForm";
            IncidentForm.Size = new Size(1050, 641);
            IncidentForm.TabIndex = 0;
            // 
            // updateIncident
            // 
            updateIncident.Controls.Add(updateIncidentuc1);
            updateIncident.Location = new Point(4, 29);
            updateIncident.Name = "updateIncident";
            updateIncident.Padding = new Padding(3);
            updateIncident.Size = new Size(1057, 672);
            updateIncident.TabIndex = 1;
            updateIncident.Text = "Update";
            updateIncident.UseVisualStyleBackColor = true;
            // 
            // updateIncidentuc1
            // 
            updateIncidentuc1.BackColor = Color.Gray;
            updateIncidentuc1.Location = new Point(6, 3);
            updateIncidentuc1.Name = "updateIncidentuc1";
            updateIncidentuc1.Size = new Size(790, 644);
            updateIncidentuc1.TabIndex = 0;
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Location = new Point(951, 25);
            userNameLbl.Margin = new Padding(2, 0, 2, 0);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(78, 20);
            userNameLbl.TabIndex = 7;
            userNameLbl.Text = "UserName";
            // 
            // logoutLink
            // 
            logoutLink.AutoSize = true;
            logoutLink.Cursor = Cursors.Hand;
            logoutLink.Location = new Point(1051, 25);
            logoutLink.Margin = new Padding(2, 0, 2, 0);
            logoutLink.Name = "logoutLink";
            logoutLink.Size = new Size(56, 20);
            logoutLink.TabIndex = 8;
            logoutLink.TabStop = true;
            logoutLink.Text = "Logout";
            logoutLink.LinkClicked += LogoutLink_LinkClicked;
            // 
            // TabbedMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 780);
            Controls.Add(userNameLbl);
            Controls.Add(logoutLink);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TabbedMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += TabbedMainForm_Load;
            tabControl.ResumeLayout(false);
            openIncident.ResumeLayout(false);
            tabAdd.ResumeLayout(false);
            updateIncident.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage updateIncident;
        private Label userNameLbl;
        private LinkLabel logoutLink;
        private TabPage openIncident;
        private OpenIncidentUC openIncidentuc1;
        private TabPage tabAdd;
        private UpdateIncidentUC updateIncidentuc1;
        private IncidentForm IncidentForm;
    }
}