using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMenus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagUj.Show();
        }

        private void módositásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagModositas.Show();
        }

        private void újToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagbefizetesuj.Show();
        }

        private void lekérdezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagbefizeteslekerdezes.Show();
        }
    }
}
