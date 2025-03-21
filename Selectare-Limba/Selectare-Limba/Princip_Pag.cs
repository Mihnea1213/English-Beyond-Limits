using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selectare_Limba
{
    public partial class Princip_Pag : Form
    {
        public Princip_Pag()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Conectare css = new Conectare();
            this.Hide();
            css.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Start_Menu lss = new Start_Menu();
            this.Hide();
            lss.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Present_Perfect_Simple pts = new Present_Perfect_Simple();
            this.Hide();
            pts.ShowDialog();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Present_Simple ptt = new Present_Simple();
            this.Hide();
            ptt.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Princip_Pag_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Princip_Pag_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Present_Continuous p_tt = new Present_Continuous();
            this.Hide();
            p_tt.ShowDialog();
            this.Close();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Quizz qz = new Quizz();
            this.Hide();
            qz.ShowDialog();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Past_Simple pas = new Past_Simple();
            this.Hide();
            pas.ShowDialog();
            this.Close();
        }
    }
}
