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
    public partial class AnalysisWork : Form
    {
        public AnalysisWork()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AnalysisWork_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_Аттестация_педагогов". При необходимости она может быть перемещена или удалена.
            this.з_Аттестация_педагоговTableAdapter.Fill(this.dBMethodistDataSet.З_Аттестация_педагогов);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepViewerAnaliz rvanl = new RepViewerAnaliz();
            rvanl.ShowDialog();
        }
    }
}
