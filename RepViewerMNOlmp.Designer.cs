namespace ProgramForMetodition
{
    partial class RepViewerMNOlmp
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
            this.З_Муниц_ОлимпиадыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBMethodistDataSet = new ProgramForMetodition.DBMethodistDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.З_Муниц_ОлимпиадыTableAdapter = new ProgramForMetodition.DBMethodistDataSetTableAdapters.З_Муниц_ОлимпиадыTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.З_Муниц_ОлимпиадыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBMethodistDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // З_Муниц_ОлимпиадыBindingSource
            // 
            this.З_Муниц_ОлимпиадыBindingSource.DataMember = "З_Муниц_Олимпиады";
            this.З_Муниц_ОлимпиадыBindingSource.DataSource = this.DBMethodistDataSet;
            // 
            // DBMethodistDataSet
            // 
            this.DBMethodistDataSet.DataSetName = "DBMethodistDataSet";
            this.DBMethodistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.З_Муниц_ОлимпиадыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProgramForMetodition.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(931, 302);
            this.reportViewer1.TabIndex = 0;
            // 
            // З_Муниц_ОлимпиадыTableAdapter
            // 
            this.З_Муниц_ОлимпиадыTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Английский язык",
            "Биология",
            "География",
            "Информатика",
            "История",
            "Литература",
            "Математика",
            "Обществознание",
            "ОБЖ",
            "Право",
            "Русский язык",
            "Технология",
            "Физика",
            "Физическая культура",
            "МХК",
            "Химия",
            "Экология",
            "Экономика",
            "Хакасский язык",
            "Хакасская литература"});
            this.comboBox1.Location = new System.Drawing.Point(61, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Предмет";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Загрузить предметы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Победитель",
            "Призер",
            "Участник",
            "1 Место",
            "2 Место",
            "3 Место"});
            this.comboBox2.Location = new System.Drawing.Point(355, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Места";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Загрузить места";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(604, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RepViewerMNOlmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 353);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RepViewerMNOlmp";
            this.Text = "RepViewerMNOlmp";
            this.Load += new System.EventHandler(this.RepViewerMNOlmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.З_Муниц_ОлимпиадыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBMethodistDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource З_Муниц_ОлимпиадыBindingSource;
        private DBMethodistDataSet DBMethodistDataSet;
        private DBMethodistDataSetTableAdapters.З_Муниц_ОлимпиадыTableAdapter З_Муниц_ОлимпиадыTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}