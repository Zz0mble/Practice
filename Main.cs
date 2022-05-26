using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProgramForMetodition
{
    public partial class Main : Form
    {
        public static string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =DBMethodist.mdb";
        private OleDbConnection dbconnection;
        public Main()
        {
            InitializeComponent();
            dbconnection = new OleDbConnection(connectionString);
            dbconnection.Open();
            //dataGridView6= Properties.Settings.Default.SaveApp;
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.История_Общество_Право". При необходимости она может быть перемещена или удалена.
            this.история_Общество_ПравоTableAdapter.Fill(this.dBMethodistDataSet.История_Общество_Право);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.Муниципальные_Олимпиады". При необходимости она может быть перемещена или удалена.
            this.муниципальные_ОлимпиадыTableAdapter.Fill(this.dBMethodistDataSet.Муниципальные_Олимпиады);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.МБОУ". При необходимости она может быть перемещена или удалена.
            this.мБОУTableAdapter.Fill(this.dBMethodistDataSet.МБОУ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_Муниц_Олимпиады". При необходимости она может быть перемещена или удалена.
            this.з_Муниц_ОлимпиадыTableAdapter.Fill(this.dBMethodistDataSet.З_Муниц_Олимпиады);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_Методисты". При необходимости она может быть перемещена или удалена.
            this.з_МетодистыTableAdapter.Fill(this.dBMethodistDataSet.З_Методисты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_Директора". При необходимости она может быть перемещена или удалена.
            this.з_ДиректораTableAdapter.Fill(this.dBMethodistDataSet.З_Директора);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_Заведущие". При необходимости она может быть перемещена или удалена.
            this.з_ЗаведущиеTableAdapter.Fill(this.dBMethodistDataSet.З_Заведущие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_МБОУ". При необходимости она может быть перемещена или удалена.
            this.з_МБОУTableAdapter.Fill(this.dBMethodistDataSet.З_МБОУ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_МБДОУ". При необходимости она может быть перемещена или удалена.
            this.з_МБДОУTableAdapter.Fill(this.dBMethodistDataSet.З_МБДОУ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_МБДОУ". При необходимости она может быть перемещена или удалена.
            this.з_МБДОУTableAdapter.Fill(this.dBMethodistDataSet.З_МБДОУ);
            ClientSize = new Size(1100, 700);
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Программа для работы с РМО";
        }

        public void найстройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Сообщение","Настройки",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);

            Nastroyki rgbehb = new Nastroyki();
            rgbehb.Owner = this;
            rgbehb.ShowDialog();
        }
        public void color_changed()
        {
            this.BackgroundImage = ProgramForMetodition.Properties.Resources.theme;
            
        }
        public void color_change()
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                this.BackColor = colorDialog1.Color;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Children chldrn = new Children();
            chldrn.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram abprm = new AboutProgram();
            abprm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeachiesSubject sb = new TeachiesSubject();
            sb.ShowDialog(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.labirint.ru/series/17129/");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.BackgroundImage = ProgramForMetodition.Properties.Resources.theme;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnalysisWork anwrk = new AnalysisWork();
            anwrk.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Konkurs cntst = new Konkurs();
            cntst.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Educationseminar smnrs = new Educationseminar();
            smnrs.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Events evn = new Events();
            evn.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbconnection.Close();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            this.з_МБДОУTableAdapter.Fill(this.dBMethodistDataSet.З_МБДОУ);
        }


        private void button9_Click_1(object sender, EventArgs e)
        {
            /*
            int ID = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM МБДОУ WHERE [ID_ДОУ] = " + ID;
            OleDbCommand dbcommand = new OleDbCommand(query, dbconnection);
            dbcommand.ExecuteNonQuery();
            MessageBox.Show("Данные о Садике удалены");*/
        }

        private void otchet_Click(object sender, EventArgs e)
        {
            RepViewerMDB rvmdb = new RepViewerMDB();
            rvmdb.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.з_МБДОУTableAdapter.Fill(this.dBMethodistDataSet.З_МБДОУ);
        }

        private void button10_Click(object sender, EventArgs e)
        {
           /* int namev = Convert.ToInt32(textBox1.Text);
            string query = "UPDATE МБДОУ SET Название_МБДОУ  ='" + textBox2.Text + "' WHERE [ID_ДОУ] = " + namev;
            string query1 = "UPDATE МБДОУ SET Email  ='" + textBox3.Text + "' WHERE [ID_ДОУ] = " + namev;
            OleDbCommand dbcommand = new OleDbCommand(query, dbconnection);

            dbcommand.ExecuteNonQuery();
            MessageBox.Show("Название изменено");
            this.з_МБДОУTableAdapter.Fill(this.dBMethodistDataSet.З_МБДОУ);*/

        }

        private void сохранитьПриложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.SaveApp = dataGridView6.Update();
            Properties.Settings.Default.Save();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT * FROM З_Заведущие";
            OleDbDataAdapter sv = new OleDbDataAdapter(query, dbconnection);
            //da = new SqlDataAdapter(query, connectionString);
            OleDbCommandBuilder bulder = new OleDbCommandBuilder(sv);
            //SqlCommandBuilder cBuilder = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
              //  dt = new DataTable();
            sv.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
        }

        private void update_Click_1(object sender, EventArgs e)
        {
           // sv.Update(dt);
        }

        private void mbou_Click_1(object sender, EventArgs e)
        {
            RepViewerMB rvmb = new RepViewerMB();
            rvmb.ShowDialog();
        }

        private void Zavbutton_Click(object sender, EventArgs e)
        {
            RepViewerZavedusie rvz = new RepViewerZavedusie();
            rvz.ShowDialog();
        }

        private void directory_Click(object sender, EventArgs e)
        {
            RepViewerDirector rvd = new RepViewerDirector();
            rvd.ShowDialog();
        }

        private void MunOlimpbutton_Click(object sender, EventArgs e)
        {
            RepViewerMNOlmp rvmne = new RepViewerMNOlmp();
            rvmne.ShowDialog();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"Справка.hmxp");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox47.Text);
            string Name = textBox48.Text;
            string email = comboBox1.Text;
            string create = comboBox2.Text;
            string pobeditel = comboBox3.Text;
            string teacher = textbox50.Text;
            //запрос

            string query = "INSERT INTO [Муниципальные Олимпиады] ([ID_главные_победители], [ФИО], [Id_МБОУ], [Id_предмет], [Id_победитель], Учитель) VALUES (" + number + ",'" + Name + "','" + email + "','" + create + "','"+pobeditel+ "','"+ teacher + "')";
            OleDbCommand dbcommand = new OleDbCommand(query, dbconnection);
            dbcommand.ExecuteNonQuery();
            MessageBox.Show("Данные о садике добавлены");
            dbconnection.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox41.Text);
            string query = "DELETE FROM [Муниципальные Олимпиады] WHERE [ID_главные_победители] = " + ID;
            OleDbCommand dbcommand = new OleDbCommand(query, dbconnection);
            dbcommand.ExecuteNonQuery();
            this.з_Муниц_ОлимпиадыTableAdapter.Fill(this.dBMethodistDataSet.З_Муниц_Олимпиады);
            MessageBox.Show("Данные о Олимпиаде удалены");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.з_Муниц_ОлимпиадыTableAdapter.Fill(this.dBMethodistDataSet.З_Муниц_Олимпиады);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int namev = Convert.ToInt32(textBox47.Text);
            string query = "UPDATE [Муниципальные Олимпиады] SET [ID_главные_победители]  ='" + textBox48.Text + "' WHERE [ID_ДОУ] = " + namev;
            OleDbCommand dbcommand = new OleDbCommand(query, dbconnection);
            dbcommand.ExecuteNonQuery();
            string query1 = "UPDATE [Муниципальные Олимпиады] SET [Id_МБОУ]  ='" + textBox48.Text + "' WHERE [ID_ДОУ] = " + namev;
            OleDbCommand dbcommand1 = new OleDbCommand(query, dbconnection);
            dbcommand.ExecuteNonQuery();
            MessageBox.Show("Данные Изменены");
            this.з_МБДОУTableAdapter.Fill(this.dBMethodistDataSet.З_МБДОУ);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
