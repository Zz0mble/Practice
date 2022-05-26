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
    public partial class TeachiesSubject : Form
    {
        public TeachiesSubject()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TeachiesSubject_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_РегИПам". При необходимости она может быть перемещена или удалена.
            this.з_РегИПамTableAdapter.Fill(this.dBMethodistDataSet.З_РегИПам);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_ИЗО_Музыка_начальные". При необходимости она может быть перемещена или удалена.
            this.з_ИЗО_Музыка_начальныеTableAdapter.Fill(this.dBMethodistDataSet.З_ИЗО_Музыка_начальные);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_МХК_и_Технология". При необходимости она может быть перемещена или удалена.
            this.з_МХК_и_ТехнологияTableAdapter.Fill(this.dBMethodistDataSet.З_МХК_и_Технология);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_касетво_хак". При необходимости она может быть перемещена или удалена.
            this.з_касетво_хакTableAdapter.Fill(this.dBMethodistDataSet.З_касетво_хак);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBMethodistDataSet.З_История_Общество_Право". При необходимости она может быть перемещена или удалена.
            this.з_История_Общество_ПравоTableAdapter.Fill(this.dBMethodistDataSet.З_История_Общество_Право);
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void button_Click_1(object sender, EventArgs e)
        {
            HistorySociableRole hsr = new HistorySociableRole();
            hsr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RepViewerEducoints rvkhs = new RepViewerEducoints();
            rvkhs.ShowDialog();
            rvkhs.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EZOMusicSchool zms = new EZOMusicSchool();
            zms.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RepViewerMHKandTech rvmhkt = new RepViewerMHKandTech();
            rvmhkt.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RepViewerRegion rvreg = new RepViewerRegion();
            rvreg.ShowDialog();
        }
    }
}
