namespace ProgramForMetodition
{
    partial class RepViewerEducoints
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.З_касетво_хакBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBMethodistDataSet = new ProgramForMetodition.DBMethodistDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.З_касетво_хакTableAdapter = new ProgramForMetodition.DBMethodistDataSetTableAdapters.З_касетво_хакTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.З_касетво_хакBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBMethodistDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // З_касетво_хакBindingSource
            // 
            this.З_касетво_хакBindingSource.DataMember = "З_касетво_хак";
            this.З_касетво_хакBindingSource.DataSource = this.DBMethodistDataSet;
            // 
            // DBMethodistDataSet
            // 
            this.DBMethodistDataSet.DataSetName = "DBMethodistDataSet";
            this.DBMethodistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.З_касетво_хакBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProgramForMetodition.ReportPredmetKhassia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(763, 233);
            this.reportViewer1.TabIndex = 0;
            // 
            // З_касетво_хакTableAdapter
            // 
            this.З_касетво_хакTableAdapter.ClearBeforeFill = true;
            // 
            // RepViewerEducoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 244);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RepViewerEducoints";
            this.Text = "RepViewerEducoints";
            this.Load += new System.EventHandler(this.RepViewerEducoints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.З_касетво_хакBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBMethodistDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource З_касетво_хакBindingSource;
        private DBMethodistDataSet DBMethodistDataSet;
        private DBMethodistDataSetTableAdapters.З_касетво_хакTableAdapter З_касетво_хакTableAdapter;
    }
}