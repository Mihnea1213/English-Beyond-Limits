using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Selectare_Limba
{
    public partial class Quizz : Form
    {
        public Quizz()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Princip_Pag pgg = new Princip_Pag();
            this.Hide();
            pgg.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Start_Menu lss = new Start_Menu();
            this.Hide();
            lss.ShowDialog();
            this.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numar;
            bool alfa = true;
            numar = textBox1.Text;
            if (numar.Length > 2)
            {
                Eroare_Introducere ei = new Eroare_Introducere();
                ei.Show();
            }
            else
            {
                int myint = int.Parse(numar);
                if (myint == 0)
                {
                    Eroare_Introducere ei = new Eroare_Introducere();
                    ei.Show();
                }
                else
                {
                    if (numar.Contains("qwertyuiopasdfghjklzxcvbnm") == true)
                    {
                        Eroare_Introducere ei = new Eroare_Introducere();
                        ei.Show();
                    }
                    else
                    {
                        radioButton1.Enabled = true;
                        radioButton2.Enabled = true;
                        radioButton3.Enabled = true;
                        radioButton4.Enabled = true;
                        string connectionString = "Data Source=DESKTOP-PC5B09U\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();
                        SqlCommand command = new SqlCommand("SELECT Întrebare,[Răspuns 1],[Răspuns 2],[Răspuns 3], [Răspuns 4] FROM [dbo].[Întrebare] WHERE Id = '" + int.Parse(textBox1.Text) + "'", connection);
                        SqlDataReader srd = command.ExecuteReader();
                        while (srd.Read())
                        {
                            label2.Text = srd.GetString(0).ToString();
                            radioButton1.Text = srd.GetValue(1).ToString();
                            radioButton2.Text = srd.GetValue(2).ToString();
                            radioButton3.Text = srd.GetValue(3).ToString();
                            radioButton4.Text = srd.GetValue(4).ToString();

                        }
                        connection.Close();
                    }
                }
            }
        }
    

        private void Quizz_Load(object sender, EventArgs e)
        {

        }

        int punctaj = 0, con = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            string Răspuns_1, Răspuns_2, Răspuns_3, Răspuns_4, Răspuns_cor;
            string connectionString = "Data Source=DESKTOP-PC5B09U\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command1 = new SqlCommand("SELECT [Răspuns 1],[Răspuns 2],[Răspuns 3], [Răspuns 4],Răspuns_corect, Motivare FROM [dbo].[Întrebare] WHERE Id = @Rasp", connection);

            SqlDataReader reader = null;
            try
            {
                command1.Parameters.AddWithValue("@Rasp", int.Parse(textBox1.Text));
                reader = command1.ExecuteReader();
            }
            catch (Exception ex)
            {
                Eroare_Conect ecc = new Eroare_Conect();
                ecc.ShowDialog();

            }
            while (reader.Read())
            {
                Răspuns_1 = (string)reader.GetValue(0);
                Răspuns_2 = (string)reader.GetValue(1);
                Răspuns_3 = (string)reader.GetValue(2);
                Răspuns_4 = (string)reader.GetValue(3);
                Răspuns_cor = (string)reader.GetValue(4);
                label3.Text = reader.GetString(5);
                if (Răspuns_1 == Răspuns_cor && radioButton1.Checked == true)
                {
                    Corect cr = new Corect();
                    cr.Show();
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    radioButton4.Enabled = false;
                    con++;
                    punctaj++;
                }
                else
                {
                    if (Răspuns_2 == Răspuns_cor && radioButton2.Checked == true)
                    {
                        Corect cr = new Corect();
                        cr.Show();
                        radioButton1.Enabled = false;
                        radioButton2.Enabled = false;
                        radioButton3.Enabled = false;
                        radioButton4.Enabled = false;
                        con++;
                        punctaj++;
                    }
                    else
                    {
                        if (Răspuns_3 == Răspuns_cor && radioButton3.Checked == true)
                        {
                            Corect cr = new Corect();
                            cr.Show();
                            radioButton1.Enabled = false;
                            radioButton2.Enabled = false;
                            radioButton3.Enabled = false;
                            radioButton4.Enabled = false;
                            con++;
                            punctaj++;
                        }
                        else
                        {
                            if (Răspuns_4 == Răspuns_cor && radioButton4.Checked == true)
                            {
                                Corect cr = new Corect();
                                cr.Show();
                                radioButton1.Enabled = false;
                                radioButton2.Enabled = false;
                                radioButton3.Enabled = false;
                                radioButton4.Enabled = false;
                                con++;
                                punctaj++;
                            }
                            else
                            {
                                Gresit gs = new Gresit();
                                gs.Show();
                                radioButton1.Enabled = false;
                                radioButton2.Enabled = false;
                                radioButton3.Enabled = false;
                                radioButton4.Enabled = false;
                                con++;
                            }
                        }
                    }
                }
            }
            if (con == 10)
            {
                int calculator = punctaj * 10;
                    Rezultat rezultatFormn = new Rezultat();
                    rezultatFormn.Punctaj = calculator;
                    this.Hide();
                    rezultatFormn.ShowDialog();
                    this.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
