using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace Autokak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string server;
        string database;
        string username;
        string password;
        string kapcsolatnev;
        string lekerdezes;


        void betoltes()
        {
            DGV.Rows.Clear();
            server = "linsql.verebely.dc";
            database = "diak36";
            username = "diak36";
            password = "BXGERT";
            kapcsolatnev = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password}";
            MySqlConnection con = new MySqlConnection(kapcsolatnev);
            con.Open();
            lekerdezes = "SELECT autok.* FROM autok";
            MySqlCommand parancs = new MySqlCommand(lekerdezes, con);
            MySqlDataReader mdr = parancs.ExecuteReader();
            DGV.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
            DGV.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd";
            while (mdr.Read())
            {
                DGV.Rows.Add(mdr["rendszam"], mdr["tipus"], mdr["uzembehelyezes"], mdr["tank"], mdr["futottkm"], mdr["kivonas"]);
            }
            con.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
            rb_n.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_rsz.TextLength == 0)
            {
                MessageBox.Show("Adjon meg rendszámot");
                tb_rsz.Focus();
            }
            else if (tb_tipus.TextLength == 0)
            {
                MessageBox.Show("Adjon meg típust");
                tb_tipus.Focus();
            }
            else if (tb_tank.TextLength == 0)
            {
                MessageBox.Show("Adjon meg ösztöndíjat");
                tb_tank.Focus();
            }
            else if (tb_futottkm.TextLength == 0)
            {
                MessageBox.Show("Adjon meg a fuott kilóméterek számát");
                tb_futottkm.Focus();
            }
            else
            {
                if (rb_i.Checked)
                {
                    if (dtp_ki.Value < dtp_uzem.Value)
                    {
                        MessageBox.Show("Az kivonás ideje nagyobbnak kell lennie az üzembe helyezés idejénél!");
                        dtp_ki.Focus();
                    }
                    else
                    {
                        try
                        {
                            server = "linsql.verebely.dc";
                            database = "diak36";
                            username = "diak36";
                            password = "BXGERT";
                            kapcsolatnev = $"Server={server};DATABASE={database};UID={username};PASSWORD={password}";
                            MySqlConnection con = new MySqlConnection(kapcsolatnev);
                            con.Open();
                            if (rb_i.Checked)
                            {
                                lekerdezes = $"INSERT INTO autok(rendszam,tipus,uzembehelyezes,tank,futottkm,kivonas)" +
                                    $"VALUES('{tb_rsz.Text}','{tb_tipus.Text}','{dtp_uzem.Text}','{tb_tank.Text}','{tb_futottkm.Text}','{dtp_ki.Text}')";
                            }
                            else
                            {
                                lekerdezes = $"INSERT INTO autok(rendszam,tipus,uzembehelyezes,tank,futottkm,kivonas)" +
                                    $"VALUES('{tb_rsz.Text}','{tb_tipus.Text}','{dtp_uzem.Text}','{tb_tank.Text}','{tb_futottkm.Text}',null)";
                            }
                            MySqlCommand command = new MySqlCommand(lekerdezes, con);
                            MySqlDataReader dr = command.ExecuteReader();
                            con.Close();
                            betoltes();
                        }
                        catch
                        {
                            MessageBox.Show("Létezik már ilyen autó");
                        }
                    }
                }
            }
        }

        private void tb_tank_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank.TextLength > 0)
            {
                try
                {
                    int a = int.Parse(tb_tank.Text);
                }
                catch
                {
                    MessageBox.Show("csak számot adjon meg");
                    tb_tank.Clear();
                    tb_tank.Focus();
                }
            }
        }

        private void rb_i_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_i.Checked)
            {
                dtp_ki.Visible = true;
            }
            else
            {
                dtp_ki.Visible = false;
            }
        }

        private void rb_n_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_i.Checked)
            {
                dtp_ki.Visible = true;
            }
            else
            {
                dtp_ki.Visible = false;
            }
        }

        private void tb_futottkm_TextChanged(object sender, EventArgs e)
        {
            if (tb_futottkm.TextLength > 0)
            {
                try
                {
                    int a = int.Parse(tb_futottkm.Text);
                }
                catch
                {
                    MessageBox.Show("csak számot adjon meg");
                    tb_futottkm.Clear();
                    tb_futottkm.Focus();
                }
            }
        }
    }
}
