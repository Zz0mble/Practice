namespace ProgramForMetodition
{
    partial class ReprViewerMerEdSeminar
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
            this.З_Мероприятия_и_СеминарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBMethodistDataSet = new ProgramForMetodition.DBMethodistDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.З_Мероприятия_и_СеминарыTableAdapter = new ProgramForMetodition.DBMethodistDataSetTableAdapters.З_Мероприятия_и_СеминарыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.З_Мероприятия_и_СеминарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBMethodistDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // З_Мероприятия_и_СеминарыBindingSource
            // 
            this.З_Мероприятия_и_СеминарыBindingSource.DataMember = "З_Мероприятия_и_Семинары";
            this.З_Мероприятия_и_СеминарыBindingSource.DataSource = this.DBMethodistDataSet;
            // 
            // DBMethodistDataSet
            // 
            this.DBMethodistDataSet.DataSetName = "DBMethodistDataSet";
            this.DBMethodistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.З_Мероприятия_и_СеминарыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProgramForMetodition.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 34);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(894, 371);
            this.reportViewer1.TabIndex = 0;
            // 
            // З_Мероприятия_и_СеминарыTableAdapter
            // 
            this.З_Мероприятия_и_СеминарыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 26);
            this.button1.TabIndex = 24;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Республиканский",
            "Региональный ",
            "Всероссийский",
            "Межрегиональный",
            "Муниципальный"});
            this.comboBox1.Location = new System.Drawing.Point(77, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Уровень";
            // 
            // ReprViewerMerEdSeminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReprViewerMerEdSeminar";
            this.Text = "ReprViewerMerEdSeminar";
            this.Load += new System.EventHandler(this.ReprViewerMerEdSeminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.З_Мероприятия_и_СеминарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBMethodistDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource З_Мероприятия_и_СеминарыBindingSource;
        private DBMethodistDataSet DBMethodistDataSet;
        private DBMethodistDataSetTableAdapters.З_Мероприятия_и_СеминарыTableAdapter З_Мероприятия_и_СеминарыTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}