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
    public partial class TagBefizetesLekerdezes : Form
    {
        public TagBefizetesLekerdezes()
        {
            InitializeComponent();
        }

        private void TagBefizetesLekerdezes_Load(object sender, EventArgs e)
        {
            dataGridView1_Befiz.ColumnCount = 3;
            dataGridView1_Befiz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Befiz.Columns[0].Name = "azon";
            dataGridView1_Befiz.Columns[0].HeaderText = "Azonosító";
            dataGridView1_Befiz.Columns[1].Name = "datum";
            dataGridView1_Befiz.Columns[1].HeaderText = "Dátum";
            dataGridView1_Befiz.Columns[2].Name = "osszeg";
            dataGridView1_Befiz.Columns[2].HeaderText = "Összeg";
            try
            {
                Program.sql.CommandText = "SELECT `azon`,`datum`,`osszeg` FROM `befiz` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        int uj_sor_idexe = dataGridView1_Befiz.Rows.Add();
                        DataGridViewRow uj_sor = dataGridView1_Befiz.Rows
                            [uj_sor_idexe];
                        uj_sor.Cells["azon"].Value = dr.GetInt32("azon");
                        uj_sor.Cells["datum"].Value = dr.GetDateTime("datum").ToString("yyy-MM-dd");
                        uj_sor.Cells["osszeg"].Value = dr.GetInt32("osszeg");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
                return;
            }
        }

        private void TagBefizetesLekerdezes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }
    }
}
