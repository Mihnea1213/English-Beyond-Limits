using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Selectare_Limba
{
    public partial class Înregistrare : Form
    {
        public Înregistrare()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Înregistrare_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Start_Menu f2 = new Start_Menu();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume, prenume, parola, confirmare_parola, email;
            nume = textBox1.Text;
            prenume = textBox2.Text;
            parola = textBox3.Text;
            confirmare_parola = textBox4.Text;
            email = textBox5.Text;
            bool alfa = false, beta = false, bravo = false, omega = true;
            if (parola != confirmare_parola)
            {
                Eroarex ex1 = new Eroarex();
                ex1.Show();
            }
            else if (nume.Length == 0 || prenume.Length == 0 || parola.Length == 0 || confirmare_parola.Length == 0 || email.Length == 0)
            {
                Eroare2 ex2 = new Eroare2();
                ex2.Show();
            }
            else if (parola.Length < 6)
            {
                Eroare3 ex3 = new Eroare3();
                ex3.Show();
            }
            else if (email.Contains("@gmail.com") == false && email.Contains("@yahoo.com") == false)
            {
                Eroare4 ex4 = new Eroare4();
                ex4.Show();
            }
            else
            {
                for (int i = 0; i < parola.Length; i++)
                {
                    if (parola[i] >= '0' && parola[i] <= '9')
                    {
                        alfa = true;
                        break;
                    }
                }

                for (int i = 0; i < parola.Length; i++)
                {
                    if (parola[i] >= 'A' && parola[i] <= 'Z')
                    {
                        beta = true;
                        break;
                    }
                }

                for (int i = 0; i < nume.Length; i++)
                {
                    if ((nume[i] >= 'A' && nume[i] <= 'Z') || (nume[i] >= 'a' && nume[i] <= 'z') || nume[i] == ' ' || nume[i] == '-')
                    {
                        continue;
                    }
                    else
                    {
                        omega = false;
                        break;
                    }
                }

                if (omega == true)
                {
                    for (int i = 0; i < prenume.Length; i++)
                    {
                        if ((prenume[i] >= 'A' && prenume[i] <= 'Z') || (prenume[i] >= 'a' && prenume[i] <= 'z') || prenume[i] == ' ' || prenume[i] == '-')
                        {
                            continue;
                        }
                        else
                        {
                            omega = false;
                            break;
                        }
                    }
                }

                if (alfa == false)
                {
                    Eroare5 ex5 = new Eroare5();
                    ex5.Show();
                }
                else if (beta == false)
                {
                    Eroare6 ex6 = new Eroare6();
                    ex6.Show();
                }
                else if (omega == false)
                {
                    Eroare8 ex8 = new Eroare8();
                    ex8.Show();
                }
                else
                {
                    string connectionString = "Data Source=DESKTOP-PC5B09U\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM Player WHERE Email = @Email";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Email", textBox5.Text);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            Eroare7 ex7 = new Eroare7();
                            ex7.Show();
                        }
                        else
                        {
                            bravo = true;
                        }
                    }
                }
            }

            if (bravo == true)
            {
                Succes st = new Succes();
                Princip_Pag pgg = new Princip_Pag();
                this.Hide();
                st.ShowDialog();
                pgg.ShowDialog();
                string connectionString = "Data Source=DESKTOP-PC5B09U\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                string sql = "INSERT INTO Player (Nume, Prenume, Parola, Email) VALUES (@Nume,@Prenume,@Parola,@Email)";

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Nume", textBox1.Text);
                command.Parameters.AddWithValue("@Prenume", textBox2.Text);
                command.Parameters.AddWithValue("@Parola", textBox3.Text);
                command.Parameters.AddWithValue("@Email", textBox5.Text);
                command.ExecuteNonQuery();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
