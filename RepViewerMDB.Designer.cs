namespace ProgramForMetodition
{
    partial class RepViewerMDB
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DBMethodistDataSet = new ProgramForMetodition.DBMethodistDataSet();
            this.З_МБДОУBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.З_МБДОУTableAdapter = new ProgramForMetodition.DBMethodistDataSetTableAdapters.З_МБДОУTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DBMethodistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.З_МБДОУBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.З_МБДОУBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProgramForMetodition.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(8, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1048, 472);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Район";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Аскизский",
            "Бельтирский",
            "Бирикчульский",
            "Бискамжинский",
            "Вершино-Тейский",
            "Есинский",
            "Катановский",
            "Кызласский",
            "Усть-Камыштинский",
            "Усть-Чульский",
            "Балыксинский",
            "Болгановски",
            "Верх-Аскизский",
            "Нижне-Тейская",
            "Казановская",
            "Усть Есинская"});
            this.comboBox1.Location = new System.Drawing.Point(70, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // DBMethodistDataSet
            // 
            this.DBMethodistDataSet.DataSetName = "DBMethodistDataSet";
            this.DBMethodistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // З_МБДОУBindingSource
            // 
            this.З_МБДОУBindingSource.DataMember = "З_МБДОУ";
            this.З_МБДОУBindingSource.DataSource = this.DBMethodistDataSet;
            // 
            // З_МБДОУTableAdapter
            // 
            this.З_МБДОУTableAdapter.ClearBeforeFill = true;
            // 
            // RepViewerMDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 521);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RepViewerMDB";
            this.Text = "RepViewerMDB";
            this.Load += new System.EventHandler(this.RepViewerMDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBMethodistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.З_МБДОУBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource З_МБДОУBindingSource;
        private DBMethodistDataSet DBMethodistDataSet;
        private DBMethodistDataSetTableAdapters.З_МБДОУTableAdapter З_МБДОУTableAdapter;
    }
}