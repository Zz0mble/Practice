namespace ProgramForMetodition
{
    partial class Events
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.зМероприяПедМастерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMethodistDataSet = new ProgramForMetodition.DBMethodistDataSet();
            this.з_МероприяПедМастерTableAdapter = new ProgramForMetodition.DBMethodistDataSetTableAdapters.З_МероприяПедМастерTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.iDМероприятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мероприятиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уровеньместоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зМероприяПедМастерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMethodistDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мероприятия";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМероприятияDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.мероприятиеDataGridViewTextBoxColumn,
            this.формаDataGridViewTextBoxColumn,
            this.уровеньместоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.зМероприяПедМастерBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 394);
            this.dataGridView1.TabIndex = 1;
            // 
            // зМероприяПедМастерBindingSource
            // 
            this.зМероприяПедМастерBindingSource.DataMember = "З_МероприяПедМастер";
            this.зМероприяПедМастерBindingSource.DataSource = this.dBMethodistDataSet;
            // 
            // dBMethodistDataSet
            // 
            this.dBMethodistDataSet.DataSetName = "DBMethodistDataSet";
            this.dBMethodistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // з_МероприяПедМастерTableAdapter
            // 
            this.з_МероприяПедМастерTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(222, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 29;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iDМероприятияDataGridViewTextBoxColumn
            // 
            this.iDМероприятияDataGridViewTextBoxColumn.DataPropertyName = "ID_Мероприятия";
            this.iDМероприятияDataGridViewTextBoxColumn.HeaderText = "№";
            this.iDМероприятияDataGridViewTextBoxColumn.Name = "iDМероприятияDataGridViewTextBoxColumn";
            this.iDМероприятияDataGridViewTextBoxColumn.Width = 35;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // мероприятиеDataGridViewTextBoxColumn
            // 
            this.мероприятиеDataGridViewTextBoxColumn.DataPropertyName = "Мероприятие";
            this.мероприятиеDataGridViewTextBoxColumn.HeaderText = "Мероприятие";
            this.мероприятиеDataGridViewTextBoxColumn.Name = "мероприятиеDataGridViewTextBoxColumn";
            this.мероприятиеDataGridViewTextBoxColumn.Width = 178;
            // 
            // формаDataGridViewTextBoxColumn
            // 
            this.формаDataGridViewTextBoxColumn.DataPropertyName = "Форма";
            this.формаDataGridViewTextBoxColumn.HeaderText = "Форма";
            this.формаDataGridViewTextBoxColumn.Name = "формаDataGridViewTextBoxColumn";
            // 
            // уровеньместоDataGridViewTextBoxColumn
            // 
            this.уровеньместоDataGridViewTextBoxColumn.DataPropertyName = "уровень_место";
            this.уровеньместоDataGridViewTextBoxColumn.HeaderText = "уровень место";
            this.уровеньместоDataGridViewTextBoxColumn.Name = "уровеньместоDataGridViewTextBoxColumn";
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зМероприяПедМастерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMethodistDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBMethodistDataSet dBMethodistDataSet;
        private System.Windows.Forms.BindingSource зМероприяПедМастерBindingSource;
        private DBMethodistDataSetTableAdapters.З_МероприяПедМастерTableAdapter з_МероприяПедМастерTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМероприятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn мероприятиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn формаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уровеньместоDataGridViewTextBoxColumn;
    }
}