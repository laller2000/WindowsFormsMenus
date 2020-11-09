using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsMenus
{
    public partial class TagUj : Form
    {
        public TagUj()
        {
            InitializeComponent();
        }

        private void TagUj_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        private void button1_Felvetel_Click(object sender, EventArgs e)
        {
            int azon=Convert.ToInt32(textBox1_Azon.Text);
            if (String.IsNullOrWhiteSpace(textBox1_Azon.Text.Trim()))
            {
                MessageBox.Show("Kéremm addjon meg azonositot", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1_Azon.Focus();
                return;
            }
            string nev=textBox1_Nev.Text.Trim();
            if (String.IsNullOrWhiteSpace(nev))
            {
                MessageBox.Show("Kéremm addjon meg nevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1_Nev.Focus();
                return;
            }
           int szulev=Convert.ToInt32(textBox2_Szulev.Text);
            if (String.IsNullOrWhiteSpace(textBox2_Szulev.Text.Trim()))
            {
                MessageBox.Show("Kéremm addjon meg szuletési évet", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2_Szulev.Focus();
                return;
            }
            int irszam=Convert.ToInt32(textBox3_Irszam.Text);
            if (String.IsNullOrWhiteSpace(textBox3_Irszam.Text.Trim()))
            {
                MessageBox.Show("Kéremm addjon meg irszamot", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3_Irszam.Focus();
                return;
            }
            string orsz=textBox2_Orsz.Text.Trim();
            if (String.IsNullOrWhiteSpace(orsz))
            {
                MessageBox.Show("Kéremm addjon meg országot de itt kettő Nagy beűtt adjon meg", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3_Irszam.Focus();
                return;
            }
            Program.sql.CommandText = "INSERT INTO `ugyfel`(`azon`, `nev`, `szulev`, `irszam`, `orsz`) VALUES ('"+azon+"','"+nev+"','"+szulev+"','"+irszam+"','"+orsz+"')";
            try
            {
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
                return;
            }
            textBox1_Azon.Text = "";
            textBox1_Nev.Text = "";
            textBox2_Orsz.Text = "";
            textBox2_Szulev.Text = "";
            textBox3_Irszam.Text = "";
        }
    }
}
