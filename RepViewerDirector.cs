using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForMetodition
{
    public partial class RepViewerDirector : Form
    {
        public RepViewerDirector()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RepViewerDirector_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBMethodistDataSet.З_Директора". При необходимости она может быть перемещена или удалена.
            this.З_ДиректораTableAdapter.Fill(this.DBMethodistDataSet.З_Директора);

            this.reportViewer1.RefreshReport();
        }
    }
}
