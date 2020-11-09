using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace WindowsFormsMenus
{
    static class Program
    {
       public  static TagModositas tagModositas =null;
        public static TagUj tagUj =null;
        public static Form1 nyito = null;
        public static TagBefizetesUj tagbefizetesuj = null;
        public static TagBefizetesLekerdezes tagbefizeteslekerdezes = null;
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;
        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException myex)
            {
                Console.WriteLine(myex.Message);
                Console.ReadKey();
                Environment.Exit(0);
                throw;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             tagModositas = new TagModositas();
            tagUj = new TagUj();
            nyito = new Form1();
            tagbefizetesuj = new TagBefizetesUj();
            tagbefizeteslekerdezes = new TagBefizetesLekerdezes();
            Application.Run(nyito);
        }
    }
}
