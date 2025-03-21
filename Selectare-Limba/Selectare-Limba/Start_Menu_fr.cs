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
    public partial class Start_Menu_fr : Form
    {
        public Start_Menu_fr()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Select_Language sll = new Select_Language();
            this.Hide();
            sll.ShowDialog();
            this.Close();
        }

        private void Start_Menu_fr_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Înregistrare inn = new Înregistrare();
            this.Hide();
            inn.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conectare cnn = new Conectare();
            this.Hide();
            cnn.ShowDialog();
            this.Close();
        }
    }
}
