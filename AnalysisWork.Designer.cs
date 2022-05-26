namespace ProgramForMetodition
{
    partial class AnalysisWork
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDcertificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.месяцыГодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наIККDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аттестованыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.навысшуюККDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аттестованынавысшуюККDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итогоатестованыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зАттестацияпедагоговBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMethodistDataSet = new ProgramForMetodition.DBMethodistDataSet();
            this.з_Аттестация_педагоговTableAdapter = new ProgramForMetodition.DBMethodistDataSetTableAdapters.З_Аттестация_педагоговTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зАттестацияпедагоговBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMethodistDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(17, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 457);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Список Анализов Учителей:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(439, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Аттестация педагогов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDcertificationDataGridViewTextBoxColumn,
            this.месяцыГодаDataGridViewTextBoxColumn,
            this.наIККDataGridViewTextBoxColumn,
            this.аттестованыDataGridViewTextBoxColumn,
            this.навысшуюККDataGridViewTextBoxColumn,
            this.аттестованынавысшуюККDataGridViewTextBoxColumn,
            this.итогоатестованыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.зАттестацияпедагоговBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(331, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(790, 407);
            this.dataGridView1.TabIndex = 11;
            // 
            // iDcertificationDataGridViewTextBoxColumn
            // 
            this.iDcertificationDataGridViewTextBoxColumn.DataPropertyName = "ID_certification";
            this.iDcertificationDataGridViewTextBoxColumn.HeaderText = "ID_certification";
            this.iDcertificationDataGridViewTextBoxColumn.Name = "iDcertificationDataGridViewTextBoxColumn";
            // 
            // месяцыГодаDataGridViewTextBoxColumn
            // 
            this.месяцыГодаDataGridViewTextBoxColumn.DataPropertyName = "Месяцы_Года";
            this.месяцыГодаDataGridViewTextBoxColumn.HeaderText = "Месяцы_Года";
            this.месяцыГодаDataGridViewTextBoxColumn.Name = "месяцыГодаDataGridViewTextBoxColumn";
            // 
            // наIККDataGridViewTextBoxColumn
            // 
            this.наIККDataGridViewTextBoxColumn.DataPropertyName = "На_I_КК";
            this.наIККDataGridViewTextBoxColumn.HeaderText = "На_I_КК";
            this.наIККDataGridViewTextBoxColumn.Name = "наIККDataGridViewTextBoxColumn";
            // 
            // аттестованыDataGridViewTextBoxColumn
            // 
            this.аттестованыDataGridViewTextBoxColumn.DataPropertyName = "Аттестованы";
            this.аттестованыDataGridViewTextBoxColumn.HeaderText = "Аттестованы";
            this.аттестованыDataGridViewTextBoxColumn.Name = "аттестованыDataGridViewTextBoxColumn";
            // 
            // навысшуюККDataGridViewTextBoxColumn
            // 
            this.навысшуюККDataGridViewTextBoxColumn.DataPropertyName = "На_высшую_КК";
            this.навысшуюККDataGridViewTextBoxColumn.HeaderText = "На_высшую_КК";
            this.навысшуюККDataGridViewTextBoxColumn.Name = "навысшуюККDataGridViewTextBoxColumn";
            // 
            // аттестованынавысшуюККDataGridViewTextBoxColumn
            // 
            this.аттестованынавысшуюККDataGridViewTextBoxColumn.DataPropertyName = "Аттестованы_на_высшую_КК";
            this.аттестованынавысшуюККDataGridViewTextBoxColumn.HeaderText = "Аттестованы_на_высшую_КК";
            this.аттестованынавысшуюККDataGridViewTextBoxColumn.Name = "аттестованынавысшуюККDataGridViewTextBoxColumn";
            // 
            // итогоатестованыDataGridViewTextBoxColumn
            // 
            this.итогоатестованыDataGridViewTextBoxColumn.DataPropertyName = "Итого_атестованы";
            this.итогоатестованыDataGridViewTextBoxColumn.HeaderText = "Итого_атестованы";
            this.итогоатестованыDataGridViewTextBoxColumn.Name = "итогоатестованыDataGridViewTextBoxColumn";
            // 
            // зАттестацияпедагоговBindingSource
            // 
            this.зАттестацияпедагоговBindingSource.DataMember = "З_Аттестация_педагогов";
            this.зАттестацияпедагоговBindingSource.DataSource = this.dBMethodistDataSet;
            // 
            // dBMethodistDataSet
            // 
            this.dBMethodistDataSet.DataSetName = "DBMethodistDataSet";
            this.dBMethodistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // з_Аттестация_педагоговTableAdapter
            // 
            this.з_Аттестация_педагоговTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(836, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnalysisWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnalysisWork";
            this.Text = "AnalysisWork";
            this.Load += new System.EventHandler(this.AnalysisWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зАттестацияпедагоговBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMethodistDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBMethodistDataSet dBMethodistDataSet;
        private System.Windows.Forms.BindingSource зАттестацияпедагоговBindingSource;
        private DBMethodistDataSetTableAdapters.З_Аттестация_педагоговTableAdapter з_Аттестация_педагоговTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcertificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn месяцыГодаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наIККDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аттестованыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn навысшуюККDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аттестованынавысшуюККDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn итогоатестованыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}