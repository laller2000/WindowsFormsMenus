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
    public partial class TagBefizetesUj : Form
    {
        public TagBefizetesUj()
        {
            InitializeComponent();
        }

        private void button1_felvetel_Click(object sender, EventArgs e)
        {
            int azon=Convert.ToInt32(textBox1_azon.Text);
            if (String.IsNullOrWhiteSpace(textBox1_azon.Text.Trim()))
            {
                MessageBox.Show("Addjon meg azonosítót!!!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1_azon.Focus();
                return;
            }
            DateTime datum=dateTimePicker1_datum.Value;
            int osszeg=Convert.ToInt32(textBox2_osszeg.Text);
            if (String.IsNullOrWhiteSpace(textBox2_osszeg.Text.Trim()))
            {
                MessageBox.Show("Kéremm addjon meg osszeget", "hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2_osszeg.Focus();
                return;
            }
            Program.sql.CommandText = "INSERT INTO `befiz`(`azon`, `datum`, `osszeg`) VALUES ('"+azon+"','"+datum+"','"+osszeg+"')";
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
            textBox1_azon.Text = "";
            textBox2_osszeg.Text = "";
        }
    }
}
