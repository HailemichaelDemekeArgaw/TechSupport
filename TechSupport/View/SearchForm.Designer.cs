namespace TechSupport.View
{
    /// <summary>
    ///  Manages the components that are used by the Search Form.
    /// </summary>
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing"> </param>
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
            searchBtn = new Button();
            custIdLbl = new Label();
            custIdTxt = new TextBox();
            searchDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)searchDataGrid).BeginInit();
            SuspendLayout();
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ButtonHighlight;
            searchBtn.Location = new Point(228, 48);
            searchBtn.Margin = new Padding(2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(108, 26);
            searchBtn.TabIndex = 4;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            // 
            // custIdLbl
            // 
            custIdLbl.AutoSize = true;
            custIdLbl.Font = new Font("Segoe UI", 9F);
            custIdLbl.Location = new Point(59, 14);
            custIdLbl.Margin = new Padding(2, 0, 2, 0);
            custIdLbl.Name = "custIdLbl";
            custIdLbl.Size = new Size(72, 15);
            custIdLbl.TabIndex = 5;
            custIdLbl.Text = "Customer Id";
            // 
            // custIdTxt
            // 
            custIdTxt.Location = new Point(211, 13);
            custIdTxt.Margin = new Padding(2);
            custIdTxt.Name = "custIdTxt";
            custIdTxt.Size = new Size(252, 23);
            custIdTxt.TabIndex = 1;
            // 
            // searchDataGrid
            // 
            searchDataGrid.BackgroundColor = SystemColors.Window;
            searchDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGrid.Location = new Point(10, 106);
            searchDataGrid.Margin = new Padding(2);
            searchDataGrid.Name = "searchDataGrid";
            searchDataGrid.RowHeadersWidth = 62;
            searchDataGrid.Size = new Size(529, 118);
            searchDataGrid.TabIndex = 6;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 265);
            Controls.Add(searchDataGrid);
            Controls.Add(custIdTxt);
            Controls.Add(custIdLbl);
            Controls.Add(searchBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Incident";
            ((System.ComponentModel.ISupportInitialize)searchDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button searchBtn;
        private Label custIdLbl;
        private TextBox custIdTxt;
        private DataGridView searchDataGrid;
    }
}