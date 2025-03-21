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
    public partial class Rezultat : Form
    {
        public int Punctaj { get; set; }

        public Rezultat()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Quizz qzz = new Quizz();
            this.Hide();
            qzz.ShowDialog();
            this.Close();
        }

        private void Rezultat_Load(object sender, EventArgs e)
        {
            punctajLabel.Text = Punctaj.ToString();
        }

        private void punctajLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}