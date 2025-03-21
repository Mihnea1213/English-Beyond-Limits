using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selectare_Limba
{
    public partial class Present_Simple : Form
    {
        public Present_Simple()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Princip_Pag pgg = new Princip_Pag();
            this.Hide();
            pgg.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Start_Menu lss = new Start_Menu();
            this.Hide();
            lss.ShowDialog();
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Present_Continuous p_tt = new Present_Continuous();
            this.Hide();
            p_tt.ShowDialog();
            this.Close();
        }
    }
}
