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
    public partial class Educationseminar : Form
    {
        public static string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =DBMethodist.mdb";
        private OleDbConnection dbconnection;
        public Educationseminar()
        {
            dbconnection = new OleDbConnection(connectionString);
            dbconnection.Open();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Mainseminar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_Мероприятия_и_Семинары". При необходимости она может быть перемещена или удалена.
            this.з_Мероприятия_и_СеминарыTableAdapter.Fill(this.dBMethodistDataSet.З_Мероприятия_и_Семинары);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReprViewerMerEdSeminar rvmes = new ReprViewerMerEdSeminar();
            rvmes.ShowDialog();
        }
    }
}
