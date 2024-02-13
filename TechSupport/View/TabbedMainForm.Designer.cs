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
            incidentlistView = new ListView();
            addIncident = new TabPage();
            messageLabel = new Label();
            CustIdErrMsg = new Label();
            DescErrMsg = new Label();
            TitleErrMsg = new Label();
            cancelBtn = new Button();
            addBtn = new Button();
            custIdTxt = new TextBox();
            custIdLbl = new Label();
            descTxt = new TextBox();
            descLbl = new Label();
            titleTxt = new TextBox();
            titleLbl = new Label();
            addHeaderLbl = new Label();
            inciedentList = new TabPage();
            incidentDatagrid = new DataGridView();
            searchIncident = new TabPage();
            searchDataGrid = new DataGridView();
            customerIdTxt = new TextBox();
            label1 = new Label();
            searchBtn = new Button();
            userNameLbl = new Label();
            logoutLink = new LinkLabel();
            tabControl.SuspendLayout();
            openIncident.SuspendLayout();
            addIncident.SuspendLayout();
            inciedentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)incidentDatagrid).BeginInit();
            searchIncident.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(addIncident);
            tabControl.Controls.Add(inciedentList);
            tabControl.Controls.Add(searchIncident);
            tabControl.Controls.Add(openIncident);
            tabControl.Location = new Point(55, 66);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(690, 318);
            tabControl.TabIndex = 1;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // openIncident
            // 
            openIncident.Controls.Add(incidentlistView);
            openIncident.Location = new Point(4, 24);
            openIncident.Name = "openIncident";
            openIncident.Padding = new Padding(3);
            openIncident.Size = new Size(682, 290);
            openIncident.TabIndex = 3;
            openIncident.Text = "Display Open Incident";
            openIncident.UseVisualStyleBackColor = true;
            openIncident.Click += openIncident_Click;
            // 
            // incidentlistView
            // 
            incidentlistView.Location = new Point(3, 3);
            incidentlistView.Name = "incidentlistView";
            incidentlistView.Size = new Size(673, 291);
            incidentlistView.TabIndex = 0;
            incidentlistView.UseCompatibleStateImageBehavior = false;
            // 
            // addIncident
            // 
            addIncident.Controls.Add(messageLabel);
            addIncident.Controls.Add(CustIdErrMsg);
            addIncident.Controls.Add(DescErrMsg);
            addIncident.Controls.Add(TitleErrMsg);
            addIncident.Controls.Add(cancelBtn);
            addIncident.Controls.Add(addBtn);
            addIncident.Controls.Add(custIdTxt);
            addIncident.Controls.Add(custIdLbl);
            addIncident.Controls.Add(descTxt);
            addIncident.Controls.Add(descLbl);
            addIncident.Controls.Add(titleTxt);
            addIncident.Controls.Add(titleLbl);
            addIncident.Controls.Add(addHeaderLbl);
            addIncident.Location = new Point(4, 24);
            addIncident.Margin = new Padding(3, 2, 3, 2);
            addIncident.Name = "addIncident";
            addIncident.Padding = new Padding(3, 2, 3, 2);
            addIncident.Size = new Size(682, 290);
            addIncident.TabIndex = 0;
            addIncident.Text = "Add Incident";
            addIncident.UseVisualStyleBackColor = true;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new Point(214, 210);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(0, 15);
            messageLabel.TabIndex = 25;
            // 
            // CustIdErrMsg
            // 
            CustIdErrMsg.AutoSize = true;
            CustIdErrMsg.ForeColor = SystemColors.ControlText;
            CustIdErrMsg.Location = new Point(214, 183);
            CustIdErrMsg.Margin = new Padding(2, 0, 2, 0);
            CustIdErrMsg.Name = "CustIdErrMsg";
            CustIdErrMsg.Size = new Size(38, 15);
            CustIdErrMsg.TabIndex = 24;
            CustIdErrMsg.Text = "label7";
            // 
            // DescErrMsg
            // 
            DescErrMsg.AutoSize = true;
            DescErrMsg.ForeColor = SystemColors.ControlText;
            DescErrMsg.Location = new Point(214, 142);
            DescErrMsg.Margin = new Padding(2, 0, 2, 0);
            DescErrMsg.Name = "DescErrMsg";
            DescErrMsg.Size = new Size(38, 15);
            DescErrMsg.TabIndex = 22;
            DescErrMsg.Text = "label6";
            // 
            // TitleErrMsg
            // 
            TitleErrMsg.AutoSize = true;
            TitleErrMsg.ForeColor = SystemColors.ControlText;
            TitleErrMsg.Location = new Point(214, 102);
            TitleErrMsg.Margin = new Padding(2, 0, 2, 0);
            TitleErrMsg.Name = "TitleErrMsg";
            TitleErrMsg.Size = new Size(38, 15);
            TitleErrMsg.TabIndex = 20;
            TitleErrMsg.Text = "label5";
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = SystemColors.ButtonHighlight;
            cancelBtn.Location = new Point(312, 231);
            cancelBtn.Margin = new Padding(2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(104, 32);
            cancelBtn.TabIndex = 18;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.Window;
            addBtn.Location = new Point(188, 231);
            addBtn.Margin = new Padding(2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(104, 32);
            addBtn.TabIndex = 17;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // custIdTxt
            // 
            custIdTxt.Font = new Font("Segoe UI", 10F);
            custIdTxt.Location = new Point(211, 157);
            custIdTxt.Margin = new Padding(2);
            custIdTxt.Name = "custIdTxt";
            custIdTxt.Size = new Size(237, 25);
            custIdTxt.TabIndex = 16;
            // 
            // custIdLbl
            // 
            custIdLbl.AutoSize = true;
            custIdLbl.Font = new Font("Segoe UI", 10F);
            custIdLbl.Location = new Point(104, 160);
            custIdLbl.Margin = new Padding(2, 0, 2, 0);
            custIdLbl.Name = "custIdLbl";
            custIdLbl.Size = new Size(85, 19);
            custIdLbl.TabIndex = 23;
            custIdLbl.Text = "Customer Id";
            // 
            // descTxt
            // 
            descTxt.Font = new Font("Segoe UI", 10F);
            descTxt.Location = new Point(211, 116);
            descTxt.Margin = new Padding(2);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(237, 25);
            descTxt.TabIndex = 15;
            // 
            // descLbl
            // 
            descLbl.AutoSize = true;
            descLbl.Font = new Font("Segoe UI", 10F);
            descLbl.Location = new Point(104, 118);
            descLbl.Margin = new Padding(2, 0, 2, 0);
            descLbl.Name = "descLbl";
            descLbl.Size = new Size(78, 19);
            descLbl.TabIndex = 21;
            descLbl.Text = "Description";
            // 
            // titleTxt
            // 
            titleTxt.Font = new Font("Segoe UI", 10F);
            titleTxt.Location = new Point(211, 76);
            titleTxt.Margin = new Padding(2);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(237, 25);
            titleTxt.TabIndex = 14;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 10F);
            titleLbl.Location = new Point(104, 78);
            titleLbl.Margin = new Padding(2, 0, 2, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(34, 19);
            titleLbl.TabIndex = 19;
            titleLbl.Text = "Title";
            // 
            // addHeaderLbl
            // 
            addHeaderLbl.AutoSize = true;
            addHeaderLbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            addHeaderLbl.Location = new Point(248, 39);
            addHeaderLbl.Margin = new Padding(2, 0, 2, 0);
            addHeaderLbl.Name = "addHeaderLbl";
            addHeaderLbl.Size = new Size(127, 25);
            addHeaderLbl.TabIndex = 13;
            addHeaderLbl.Text = "Add Incident";
            // 
            // inciedentList
            // 
            inciedentList.Controls.Add(incidentDatagrid);
            inciedentList.Location = new Point(4, 24);
            inciedentList.Margin = new Padding(3, 2, 3, 2);
            inciedentList.Name = "inciedentList";
            inciedentList.Padding = new Padding(3, 2, 3, 2);
            inciedentList.Size = new Size(682, 290);
            inciedentList.TabIndex = 2;
            inciedentList.Text = "Incident List";
            inciedentList.UseVisualStyleBackColor = true;
            // 
            // incidentDatagrid
            // 
            incidentDatagrid.BackgroundColor = SystemColors.Window;
            incidentDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            incidentDatagrid.Location = new Point(130, 21);
            incidentDatagrid.Margin = new Padding(2);
            incidentDatagrid.Name = "incidentDatagrid";
            incidentDatagrid.RowHeadersWidth = 62;
            incidentDatagrid.Size = new Size(424, 251);
            incidentDatagrid.TabIndex = 6;
            // 
            // searchIncident
            // 
            searchIncident.Controls.Add(searchDataGrid);
            searchIncident.Controls.Add(customerIdTxt);
            searchIncident.Controls.Add(label1);
            searchIncident.Controls.Add(searchBtn);
            searchIncident.Location = new Point(4, 24);
            searchIncident.Margin = new Padding(3, 2, 3, 2);
            searchIncident.Name = "searchIncident";
            searchIncident.Padding = new Padding(3, 2, 3, 2);
            searchIncident.Size = new Size(682, 290);
            searchIncident.TabIndex = 1;
            searchIncident.Text = "Search Incident";
            searchIncident.UseVisualStyleBackColor = true;
            // 
            // searchDataGrid
            // 
            searchDataGrid.BackgroundColor = SystemColors.Window;
            searchDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGrid.Location = new Point(153, 135);
            searchDataGrid.Margin = new Padding(2);
            searchDataGrid.Name = "searchDataGrid";
            searchDataGrid.RowHeadersWidth = 62;
            searchDataGrid.Size = new Size(398, 118);
            searchDataGrid.TabIndex = 10;
            // 
            // customerIdTxt
            // 
            customerIdTxt.Location = new Point(284, 39);
            customerIdTxt.Margin = new Padding(2);
            customerIdTxt.Name = "customerIdTxt";
            customerIdTxt.Size = new Size(252, 23);
            customerIdTxt.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(134, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 9;
            label1.Text = "Customer Id";
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ButtonHighlight;
            searchBtn.Location = new Point(301, 74);
            searchBtn.Margin = new Padding(2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(108, 26);
            searchBtn.TabIndex = 8;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Location = new Point(632, 21);
            userNameLbl.Margin = new Padding(2, 0, 2, 0);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(62, 15);
            userNameLbl.TabIndex = 7;
            userNameLbl.Text = "UserName";
            // 
            // logoutLink
            // 
            logoutLink.AutoSize = true;
            logoutLink.Cursor = Cursors.Hand;
            logoutLink.Location = new Point(720, 21);
            logoutLink.Margin = new Padding(2, 0, 2, 0);
            logoutLink.Name = "logoutLink";
            logoutLink.Size = new Size(45, 15);
            logoutLink.TabIndex = 8;
            logoutLink.TabStop = true;
            logoutLink.Text = "Logout";
            logoutLink.LinkClicked += logoutLink_LinkClicked;
            // 
            // TabbedMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userNameLbl);
            Controls.Add(logoutLink);
            Controls.Add(tabControl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TabbedMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += TabbedMainForm_Load;
            tabControl.ResumeLayout(false);
            openIncident.ResumeLayout(false);
            addIncident.ResumeLayout(false);
            addIncident.PerformLayout();
            inciedentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)incidentDatagrid).EndInit();
            searchIncident.ResumeLayout(false);
            searchIncident.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage addIncident;
        private Label messageLabel;
        private Label CustIdErrMsg;
        private Label DescErrMsg;
        private Label TitleErrMsg;
        private Button cancelBtn;
        private Button addBtn;
        private TextBox custIdTxt;
        private Label custIdLbl;
        private TextBox descTxt;
        private Label descLbl;
        private TextBox titleTxt;
        private Label titleLbl;
        private Label addHeaderLbl;
        private TabPage inciedentList;
        private DataGridView incidentDatagrid;
        private TabPage searchIncident;
        private DataGridView searchDataGrid;
        private TextBox customerIdTxt;
        private Label label1;
        private Button searchBtn;
        private Label userNameLbl;
        private LinkLabel logoutLink;
        private TabPage openIncident;
        private ListView incidentlistView;
    }
}