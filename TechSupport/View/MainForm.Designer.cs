using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Represents the Main FORM UI features
    /// </summary>
    partial class MainForm
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
            logoutLink = new LinkLabel();
            userNameLbl = new Label();
            incidentDatagrid = new DataGridView();
            addBtn = new Button();
            searchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)incidentDatagrid).BeginInit();
            SuspendLayout();

            // 
            // logoutLink
            // 
            logoutLink.AutoSize = true;
            logoutLink.Cursor = Cursors.Hand;
            logoutLink.Location = new Point(574, 18);
            logoutLink.Margin = new Padding(2, 0, 2, 0);
            logoutLink.Name = "logoutLink";
            logoutLink.Size = new Size(56, 20);
            logoutLink.TabIndex = 4;
            logoutLink.TabStop = true;
            logoutLink.Text = "Logout";

            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Location = new Point(473, 18);
            userNameLbl.Margin = new Padding(2, 0, 2, 0);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(78, 20);
            userNameLbl.TabIndex = 3;
            userNameLbl.Text = "UserName";

            // 
            // incidentDatagrid
            // 
            incidentDatagrid.BackgroundColor = SystemColors.Window;
            incidentDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            incidentDatagrid.Location = new Point(105, 116);
            incidentDatagrid.Margin = new Padding(2);
            incidentDatagrid.Name = "incidentDatagrid";
            incidentDatagrid.RowHeadersWidth = 62;
            incidentDatagrid.Size = new Size(485, 335);
            incidentDatagrid.TabIndex = 5;

            // 
            // addBtn
            // 
            addBtn.BackColor = Color.White;
            addBtn.Location = new Point(63, 18);
            addBtn.Margin = new Padding(2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(121, 36);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add Incident";
            addBtn.UseVisualStyleBackColor = false;

            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ButtonHighlight;
            searchBtn.Location = new Point(189, 18);
            searchBtn.Margin = new Padding(2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(121, 36);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search Incident";
            searchBtn.UseVisualStyleBackColor = false;

            // 
            // MainFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(732, 553);
            Controls.Add(searchBtn);
            Controls.Add(addBtn);
            Controls.Add(incidentDatagrid);
            Controls.Add(userNameLbl);
            Controls.Add(logoutLink);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "MainFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)incidentDatagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private LinkLabel logoutLink;
        private Label userNameLbl;
        private DataGridView incidentDatagrid;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn customerID;
        private Button addBtn;
        private Button searchBtn;
    }
}