namespace Selectare_Limba
{
    public partial class Select_Language : Form
    {
        public Select_Language()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start_Menu f2 = new Start_Menu();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void Select_Language_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Princip_Pag pgg = new Princip_Pag();
            this.Hide();
            pgg.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Present_Simple ptt = new Present_Simple();
            this.Hide();
            ptt.ShowDialog();
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Past_Simple past = new Past_Simple();
            this.Hide();
            past.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Present_Simple ligma = new Present_Simple();
            this.Hide();
            ligma.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Quizz qzz = new Quizz();
            this.Hide();
            qzz.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start_Menu_fr smf = new Start_Menu_fr();
            this.Hide();
            smf.ShowDialog();
            this.Close();
        }
    }
}