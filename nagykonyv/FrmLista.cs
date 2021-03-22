using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nagykonyv
{
    public partial class FrmLista : Form
    {
        //Kezdés: 10:00
        //Befejezés 12:25

        static string connectionString = @"Server = (localdb)\MSSQLLocalDB;" +
            @"AttachDbFileName=|DataDirectory|Resources\nagykonyv.mdf;";

        static SqlConnection connection = new SqlConnection(connectionString);

        public static DataGridViewRow SelectedRow { get; set; }

        private static bool next = false;
        public static Boolean Next
        {
            get { return next; }
            set { next = FrmLista.Next; }
        }

        private static bool tb_sor = false;
        public static Boolean Tb_sor
        {
            get { return tb_sor; }
            set { tb_sor = FrmLista.Next; }
        }
        public FrmLista()
        {
            InitializeComponent();
        }

        private void FrmLista_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataReader command = new SqlCommand("SELECT konyv.ID, konyv.helyezes, szerzo.nev, konyv.cim FROM konyv, szerzo WHERE konyv.szerzoID=szerzo.ID ORDER BY helyezes ASC;", connection).ExecuteReader();
            while (command.Read())
            {
                tabla1.Rows.Add(command[0], command[1], command[2], command[3]);
            }
            connection.Close();
        }

        private void újKönyvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            next = true;
            FrmKonyv konyvfrm = new FrmKonyv(connectionString);
            konyvfrm.Show();
        }

        private void kereso_TextChanged(object sender, EventArgs e)
        {
            tabla1.Rows.Clear();
            tabla1.Refresh();
            connection.Open();
            SqlDataReader command = new SqlCommand("SELECT konyv.ID, konyv.helyezes, szerzo.nev, konyv.cim FROM konyv, szerzo WHERE konyv.szerzoID=szerzo.ID AND (konyv.cim LIKE '" + kereso.Text + "%' OR szerzo.nev LIKE '" + kereso.Text + "%') ORDER BY helyezes ASC;", connection).ExecuteReader();
            while (command.Read())
            {
                tabla1.Rows.Add(command[0], command[1], command[2], command[3]);
            }
            connection.Close();
        }

        private void tabla1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRow = tabla1.Rows[e.RowIndex];

                tb_sor = true;

                FrmKonyv form2 = new FrmKonyv(connectionString);
                form2.Show();
            }
        }
    }
}
