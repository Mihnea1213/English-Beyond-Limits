using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selectare_Limba
{
    public partial class Conectare : Form
    {
        public Conectare()
        {
            InitializeComponent();
        }

        private void Conectare_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email, parola;
            email = textBox1.Text;
            parola = textBox3.Text;
            string connectionString = "Data Source=DESKTOP-PC5B09U\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Player WHERE Parola = @Parola and Email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", textBox1.Text);
                command.Parameters.AddWithValue("@Parola", textBox3.Text);

                Debug.Print(command.Parameters[0].Value.ToString());
                Debug.Print(command.Parameters[1].Value.ToString());
                Debug.Print(command.Parameters[0].ToString());

                SqlDataReader reader = command.ExecuteReader();
                if (email.Length == 0 || parola.Length == 0)
                {
                    Eroare2 err = new Eroare2();
                    err.Show();
                }
                else
                {
                    if (reader.HasRows)
                    {
                        Princip_Pag pgg = new Princip_Pag();
                        this.Hide();
                        pgg.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Eroare_Conect erx = new Eroare_Conect();
                        erx.Show();
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
