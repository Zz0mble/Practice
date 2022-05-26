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
    public partial class RepViewerMHKandTech : Form
    {
        public static string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = DBMethodist.mdb";
        private OleDbConnection dbconnection;
        public RepViewerMHKandTech()
        {
            dbconnection = new OleDbConnection(connectionString);
            dbconnection.Open();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RepaViewerMHKandTech_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBMethodistDataSet.З_МХК_и_Технология". При необходимости она может быть перемещена или удалена.
            this.З_МХК_и_ТехнологияTableAdapter.Fill(this.DBMethodistDataSet.З_МХК_и_Технология);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBMethodistDataSet.З_ИЗО_Музыка_начальные". При необходимости она может быть перемещена или удалена.
            this.З_ИЗО_Музыка_начальныеTableAdapter.Fill(this.DBMethodistDataSet.З_ИЗО_Музыка_начальные);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subject = comboBox1.Text;
            string query = "SELECT * FROM З_МХК_и_Технология WHERE Класс ='" + subject + "'";
            OleDbDataAdapter dbcommand = new OleDbDataAdapter(query, dbconnection);
            DataTable dt = new DataTable();
            dbcommand.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = @"ReportPredmetMHK.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
            dbconnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string subject = comboBox2.Text;
            string query = "SELECT * FROM З_МХК_и_Технология WHERE Название ='" + subject + "'";
            OleDbDataAdapter dbcommand = new OleDbDataAdapter(query, dbconnection);
            DataTable dt = new DataTable();
            dbcommand.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = @"ReportPredmetMHK.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
            dbconnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string subject = comboBox3.Text;
            string query = "SELECT * FROM З_МХК_и_Технология WHERE Победитель ='" + subject + "'";
            OleDbDataAdapter dbcommand = new OleDbDataAdapter(query, dbconnection);
            DataTable dt = new DataTable();
            dbcommand.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = @"ReportPredmetMHK.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
            dbconnection.Close();
        }
    }
}
