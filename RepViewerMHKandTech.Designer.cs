namespace ProgramForMetodition
{
    partial class RepViewerMHKandTech
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
            this.З_МХК_и_ТехнологияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBMethodistDataSet = new ProgramForMetodition.DBMethodistDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.З_ИЗО_Музыка_начальныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.З_ИЗО_Музыка_начальныеTableAdapter = new ProgramForMetodition.DBMethodistDataSetTableAdapters.З_ИЗО_Музыка_начальныеTableAdapter();
            this.З_МХК_и_ТехнологияTableAdapter = new ProgramForMetodition.DBMethodistDataSetTableAdapters.З_МХК_и_ТехнологияTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.З_МХК_и_ТехнологияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBMethodistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.З_ИЗО_Музыка_начальныеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // З_МХК_и_ТехнологияBindingSource
            // 
            this.З_МХК_и_ТехнологияBindingSource.DataMember = "З_МХК_и_Технология";
            this.З_МХК_и_ТехнологияBindingSource.DataSource = this.DBMethodistDataSet;
            // 
            // DBMethodistDataSet
            // 
            this.DBMethodistDataSet.DataSetName = "DBMethodistDataSet";
            this.DBMethodistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.З_МХК_и_ТехнологияBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProgramForMetodition.ReportPredmetMHK.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(801, 448);
            this.reportViewer1.TabIndex = 0;
            // 
            // З_ИЗО_Музыка_начальныеBindingSource
            // 
            this.З_ИЗО_Музыка_начальныеBindingSource.DataMember = "З_ИЗО_Музыка_начальные";
            this.З_ИЗО_Музыка_начальныеBindingSource.DataSource = this.DBMethodistDataSet;
            // 
            // З_ИЗО_Музыка_начальныеTableAdapter
            // 
            this.З_ИЗО_Музыка_начальныеTableAdapter.ClearBeforeFill = true;
            // 
            // З_МХК_и_ТехнологияTableAdapter
            // 
            this.З_МХК_и_ТехнологияTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Класс";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.comboBox1.Location = new System.Drawing.Point(56, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Загрузить Классы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "МБОШИ Аскизский лицей-интернат",
            "Усть-Чульская СОШ",
            "Кызласовская СОШ",
            "Калининская СОШ",
            "Бискамжинская СОШ",
            "Балыксинская СОШ",
            "Бирикчульская СОШ",
            "Болгановская СОШ",
            "Верх-Аскизская СОШ",
            "В-Тейская СОШ",
            "Есинская СОШ",
            "Катановская СОШ",
            "Лесоперевалочная СОШ-1",
            "Лесоперевалочная СОШ-2",
            "Лестранхозовская СОШ",
            "Нижне-Тейская СОШ",
            "Усть-Камыштинская СОШ",
            "Базинская СОШ",
            "СОШ поселок Аскиз ",
            "Баланкульская ООШ",
            "Казановская ООШ",
            "Усть-Есинская СОШ"});
            this.comboBox2.Location = new System.Drawing.Point(312, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Школы";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Загрузить школы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Победитель",
            "Призер",
            "Участник",
            "1 Место",
            "2 Место",
            "3 Место"});
            this.comboBox3.Location = new System.Drawing.Point(599, 9);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(114, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(719, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Загрузить победителей";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Победитель";
            // 
            // RepaViewerMHKandTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 508);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RepaViewerMHKandTech";
            this.Text = "RepaViewerMHKandTech";
            this.Load += new System.EventHandler(this.RepaViewerMHKandTech_Load);
            ((System.ComponentModel.ISupportInitialize)(this.З_МХК_и_ТехнологияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBMethodistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.З_ИЗО_Музыка_начальныеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource З_ИЗО_Музыка_начальныеBindingSource;
        private DBMethodistDataSet DBMethodistDataSet;
        private DBMethodistDataSetTableAdapters.З_ИЗО_Музыка_начальныеTableAdapter З_ИЗО_Музыка_начальныеTableAdapter;
        private System.Windows.Forms.BindingSource З_МХК_и_ТехнологияBindingSource;
        private DBMethodistDataSetTableAdapters.З_МХК_и_ТехнологияTableAdapter З_МХК_и_ТехнологияTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}