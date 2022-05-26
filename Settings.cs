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
    public partial class Settings : Form
    {
        public Settings()
        {

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Main m = (Main)this.Owner;
                m.color_change();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackgroundImage = ProgramForMetodition.Properties.Resources.theme;
            Main m1 = (Main)this.Owner;
            m1.color_changed();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }
    }
}
