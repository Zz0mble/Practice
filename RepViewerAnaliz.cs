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
    public partial class RepViewerAnaliz : Form
    {
        public RepViewerAnaliz()
        {
            InitializeComponent();
        }

        private void RepViewerAnaliz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBMethodistDataSet.З_Аттестация_педагогов". При необходимости она может быть перемещена или удалена.
            this.З_Аттестация_педагоговTableAdapter.Fill(this.DBMethodistDataSet.З_Аттестация_педагогов);

            this.reportViewer1.RefreshReport();
        }
    }
}
