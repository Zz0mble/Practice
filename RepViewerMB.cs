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
    public partial class RepViewerMB : Form
    {
        public static string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = DBMethodist.mdb";
        private OleDbConnection dbconnection;
        public RepViewerMB()
        {
            dbconnection = new OleDbConnection(connectionString);
            dbconnection.Open();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RepViewerMB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBMethodistDataSet.З_МБОУ". При необходимости она может быть перемещена или удалена.
            this.З_МБОУTableAdapter.Fill(this.DBMethodistDataSet.З_МБОУ);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subject = comboBox1.Text;
            string query = "SELECT * FROM З_МБОУ WHERE Районы ='" + subject + "'";
            OleDbDataAdapter dbcommand = new OleDbDataAdapter(query, dbconnection);
            DataTable dt = new DataTable();
            dbcommand.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = @"Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
            dbconnection.Close();
        }
    }
}
