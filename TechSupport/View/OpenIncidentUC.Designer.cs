namespace TechSupport.View
{
    partial class OpenIncidentUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            incidentlistView = new ListView();
            SuspendLayout();
            // 
            // incidentlistView
            // 
            incidentlistView.Location = new Point(3, 2);
            incidentlistView.Margin = new Padding(3, 2, 3, 2);
            incidentlistView.Name = "incidentlistView";
            incidentlistView.Size = new Size(900, 320);
            incidentlistView.TabIndex = 0;
            incidentlistView.UseCompatibleStateImageBehavior = false;
            incidentlistView.SelectedIndexChanged += IncidentlistView_SelectedIndexChanged;
            // 
            // OpenIncidentUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(incidentlistView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OpenIncidentUC";
            Size = new Size(921, 334);
            Load += OpenIncidentUC_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView incidentlistView;
    }
}
