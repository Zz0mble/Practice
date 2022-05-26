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
    public partial class RepViewerMNOlmp : Form
    {
        public static string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = DBMethodist.mdb";
        private OleDbConnection dbconnection;
        public RepViewerMNOlmp()
        {
            dbconnection = new OleDbConnection(connectionString);
            dbconnection.Open();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RepViewerMNOlmp_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBMethodistDataSet.З_Муниц_Олимпиады". При необходимости она может быть перемещена или удалена.
            this.З_Муниц_ОлимпиадыTableAdapter.Fill(this.DBMethodistDataSet.З_Муниц_Олимпиады);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subject = comboBox1.Text;
            string query = "SELECT * FROM З_Муниц_Олимпиады WHERE Школьные_предметы ='" + subject + "'";
            OleDbDataAdapter dbcommand = new OleDbDataAdapter(query, dbconnection);
            DataTable dt = new DataTable();
            dbcommand.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = @"Report5.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
            dbconnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string subject = comboBox2.Text;
            string query = "SELECT * FROM З_Муниц_Олимпиады WHERE Победитель ='" + subject + "'";
            OleDbDataAdapter dbcommand = new OleDbDataAdapter(query, dbconnection);
            DataTable dt = new DataTable();
            dbcommand.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = @"Report5.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
            dbconnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "UPDATE * FROM З_Муниц_Олимпиады";
            OleDbDataAdapter dbcommand = new OleDbDataAdapter(query, dbconnection);
            reportViewer1.RefreshReport();
            dbconnection.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
