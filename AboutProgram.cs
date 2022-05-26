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
    public partial class AboutProgram : Form
    {
        public AboutProgram()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void AboutProgram_Load(object sender, EventArgs e)
        {
            this.Text = "О программе";
        }
    }
}
