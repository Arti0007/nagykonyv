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
    public partial class FrmKonyv : Form
    {
        string connectionString;
        SqlConnection connection;
        public FrmKonyv(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void FrmKonyv_Load(object sender, EventArgs e)
        {
            string max_s;
            int max = 0;
            connection.Open();
            SqlDataReader command = new SqlCommand("SELECT MAX(ID) FROM konyv;", connection).ExecuteReader();
            while (command.Read())
            {
                max = Convert.ToInt32(command[0]);
            }
            max_s = Convert.ToString(max + 1);
            id_tb.Text = max_s;
            connection.Close();

            connection.Open();
            SqlDataReader command2 = new SqlCommand("SELECT nev FROM szerzo ORDER BY ID ASC;", connection).ExecuteReader();
            while (command2.Read())
            {
                szerzo_cb.Items.Add(command2[0]);
            }
            connection.Close();

            if (FrmLista.Next== true)
            {
                rogzit.Enabled = true;
                FrmLista.Next = false;
            }

            if (FrmLista.Tb_sor == true)
            {
                rogzit.Enabled = false;
                modosit.Enabled = true;
                torles.Enabled = true;

                id_tb.Text = FrmLista.SelectedRow.Cells[0].Value.ToString();
                helyezes_tb.Text = FrmLista.SelectedRow.Cells[1].Value.ToString();
                szerzo_cb.Text = FrmLista.SelectedRow.Cells[2].Value.ToString();
                cim_tb.Text = FrmLista.SelectedRow.Cells[3].Value.ToString();

                FrmLista.Tb_sor = false;
            }
        }

        private void rogzit_Click(object sender, EventArgs e)
        {
            if (szerzo_cb.Text != "")
            {
                if (cim_tb.Text != "")
                {
                    if (helyezes_tb.Text != "")
                    {
                        if (MessageBox.Show("Biztosan rögzíti az adatokat?", "Rögzítés", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            string sz_id = "";
                            connection.Open();
                            SqlDataReader szerzoid = new SqlCommand("SELECT ID FROM szerzo WHERE nev='" + szerzo_cb.Text + "';", connection).ExecuteReader();
                            while (szerzoid.Read())
                            {
                                sz_id = Convert.ToString(szerzoid[0]);
                            }
                            connection.Close();

                            connection.Open();
                            SqlDataReader rogzit = new SqlCommand("SET IDENTITY_INSERT konyv ON; INSERT INTO konyv (ID, cim, szerzoID, helyezes) VALUES (" + id_tb.Text + ", '" + cim_tb.Text + "', " + sz_id + ", " + helyezes_tb.Text + "); SET IDENTITY_INSERT konyv OFF;", connection).ExecuteReader();
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kérem töltse ki a helyezés mezőt!", "Hiba");
                    }
                }
                else
                {
                    MessageBox.Show("Kérem töltse ki a cím mezőt!", "Hiba");
                }
            }
            else
            {
                MessageBox.Show("Kérem töltse ki a szerző mezőt!","Hiba");
            }
        }

        private void modosit_Click(object sender, EventArgs e)
        {
                if (szerzo_cb.Text != "")
                {
                    if (cim_tb.Text != "")
                    {
                        if (helyezes_tb.Text != "")
                        {
                            if (MessageBox.Show("Biztosan módosítja az adatokat?", "Módosítás", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                string sz_id = "";
                                connection.Open();
                                SqlDataReader szerzoid = new SqlCommand("SELECT ID FROM szerzo WHERE nev='" + szerzo_cb.Text + "';", connection).ExecuteReader();
                                while (szerzoid.Read())
                                {
                                    sz_id = Convert.ToString(szerzoid[0]);
                                }
                                connection.Close();

                                connection.Open();
                                SqlDataReader modosit = new SqlCommand("UPDATE konyv SET cim='" + cim_tb.Text + "', szerzoID=" + sz_id + ", helyezes=" + helyezes_tb.Text + " WHERE ID="+ id_tb.Text +";", connection).ExecuteReader();
                                connection.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kérem töltse ki a helyezés mezőt!", "Hiba");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kérem töltse ki a cím mezőt!", "Hiba");
                    }
                }
                else
                {
                    MessageBox.Show("Kérem töltse ki a szerző mezőt!", "Hiba");
                }
        }

        private void torles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan törli az adatokat?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.Open();
                SqlDataReader delete = new SqlCommand("DELETE FROM konyv WHERE konyv.ID=" + id_tb.Text + ";", connection).ExecuteReader();
                connection.Close();
            }
        }

        private void szerzo_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
}
