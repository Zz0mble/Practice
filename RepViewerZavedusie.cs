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
    public partial class RepViewerZavedusie : Form
    {
        public RepViewerZavedusie()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RepViewerZavedusie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DBMethodistDataSet.З_Заведущие". При необходимости она может быть перемещена или удалена.
            this.З_ЗаведущиеTableAdapter.Fill(this.DBMethodistDataSet.З_Заведущие);

            this.reportViewer1.RefreshReport();
        }
    }
}
