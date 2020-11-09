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
    public partial class TagModositas : Form
    {
        public TagModositas()
        {
            InitializeComponent();
        }

        private void button1_Modositas_Click(object sender, EventArgs e)
        {
            int azon2=Convert.ToInt32(textBox1_Azon.Text);
            if (String.IsNullOrWhiteSpace(textBox1_Azon.Text.Trim()))
            {
                MessageBox.Show("Kéreem adja meg az azonositot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string nev2=textBox2_Nev.Text.Trim();
            if (String.IsNullOrWhiteSpace(nev2))
            {
                MessageBox.Show("Kéremm addjon meg nevet", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            int szulev2=Convert.ToInt32(textBox3_Szulev.Text);
            if (String.IsNullOrWhiteSpace(textBox3_Szulev.Text.Trim()))
            {
                MessageBox.Show("Kérem addjon meg szuletesévet", "hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int irszam2=Convert.ToInt32(textBox4_irszam.Text);
            if (String.IsNullOrWhiteSpace(textBox4_irszam.Text.Trim()))
            {
                MessageBox.Show("Kérem addjon meg irszamot", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string orsz2=textBox5_Orsz.Text.Trim();
            if (String.IsNullOrEmpty(orsz2))
            {
                MessageBox.Show("Kéreem addjon országot", "Hib", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Program.sql.CommandText = "UPDATE `ugyfel` SET `azon`='"+azon2+"',`nev`='"+nev2+"',`szulev`='"+szulev2+"',`irszam`='"+irszam2+"',`orsz`='"+orsz2+"' WHERE 1";
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
        }

        private void TagModositas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }
    }
}
