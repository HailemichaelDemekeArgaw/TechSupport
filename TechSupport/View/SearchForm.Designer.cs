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
            searchBtn.Location = new Point(261, 64);
            searchBtn.Margin = new Padding(2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(124, 34);
            searchBtn.TabIndex = 4;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;

            // 
            // custIdLbl
            // 
            custIdLbl.AutoSize = true;
            custIdLbl.Font = new Font("Segoe UI", 9F);
            custIdLbl.Location = new Point(67, 18);
            custIdLbl.Margin = new Padding(2, 0, 2, 0);
            custIdLbl.Name = "custIdLbl";
            custIdLbl.Size = new Size(89, 20);
            custIdLbl.TabIndex = 5;
            custIdLbl.Text = "Customer Id";

            // 
            // custIdTxt
            // 
            custIdTxt.Location = new Point(241, 17);
            custIdTxt.Margin = new Padding(2);
            custIdTxt.Name = "custIdTxt";
            custIdTxt.Size = new Size(288, 27);
            custIdTxt.TabIndex = 1;

            // 
            // searchDataGrid
            // 
            searchDataGrid.BackgroundColor = SystemColors.Window;
            searchDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGrid.Location = new Point(11, 142);
            searchDataGrid.Margin = new Padding(2);
            searchDataGrid.Name = "searchDataGrid";
            searchDataGrid.RowHeadersWidth = 62;
            searchDataGrid.Size = new Size(605, 158);
            searchDataGrid.TabIndex = 6;

            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 353);
            Controls.Add(searchDataGrid);
            Controls.Add(custIdTxt);
            Controls.Add(custIdLbl);
            Controls.Add(searchBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
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