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
    public partial class Konkurs : Form
    {
        public Konkurs()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Contest_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_Конкурсы". При необходимости она может быть перемещена или удалена.
            this.з_КонкурсыTableAdapter.Fill(this.dBMethodistDataSet.З_Конкурсы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepViewerConcurs rvc = new RepViewerConcurs();
            rvc.ShowDialog();
        }
    }
}
