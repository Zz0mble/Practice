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
    public partial class RepViewerEducoints : Form
    {
        public RepViewerEducoints()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RepViewerEducoints_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBMethodistDataSet.З_касетво_хак". При необходимости она может быть перемещена или удалена.
            this.З_касетво_хакTableAdapter.Fill(this.DBMethodistDataSet.З_касетво_хак);

            this.reportViewer1.RefreshReport();
        }
    }
}
