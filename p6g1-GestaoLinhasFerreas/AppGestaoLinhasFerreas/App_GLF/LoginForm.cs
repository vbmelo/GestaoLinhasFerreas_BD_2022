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
using System.Runtime.InteropServices;

namespace App_GLF
{
    public partial class loginPanel : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int widthEllipse,
            int nHeightEllipse
            );

        SqlConnection CN = null;

        public loginPanel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            /*
             Conexão automática com a BD, retirar para o login
             FEITO
             */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void server_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbServer = server.Text;
            string useraNme = username.Text;
            string passWord = password.Text;
            /*Alterar a string de parâmetro para a vossa base de dados.*/
            this.CN = AutoConnectDB("DESKTOP-77GBOEO", "Comboios5");
            this.Hide();
            LoadIndex();
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void fundoComboios_Click(object sender, EventArgs e)
        {

        }

        private void LoadIndex()
        {
            Index index = new Index(CN);
            index.Dock = DockStyle.Fill;
            index.Tag = index;
            index.FormBorderStyle = FormBorderStyle.None;
            index.Show();
        }

        private SqlConnection AutoConnectDB(string dbServer, string initialCatalog)
        {
            SqlConnection CN = new SqlConnection("Data Source = " + dbServer + "; Initial Catalog=" + initialCatalog + "; Integrated Security=SSPI;");

            try
            {
                CN.Open();
                if (CN.State == ConnectionState.Open)
                {
                    MessageBox.Show("Successful connection to database " + CN.Database + " on the " + CN.DataSource + " server", "Connection Test", MessageBoxButtons.OK);
                    /*Se a conexão foi bem sucedida, carregue o outro form de Index!*/
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
            }

            if (CN.State == ConnectionState.Open)
                return CN;
            return null;
        }



        private SqlConnection TestDBConnection(string dbServer, string userName, string userPass)
        {
            SqlConnection CN = new SqlConnection("Data Source = " + dbServer + "; uid = " + userName + ";" + "password = " + userPass);

            try
            {
                CN.Open();
                if (CN.State == ConnectionState.Open)
                {
                    MessageBox.Show("Successful connection to database " + CN.Database + " on the " + CN.DataSource + " server", "Connection Test", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
            }

            if (CN.State == ConnectionState.Open)
                return CN;
            return null;
        }


        private string getTableContent(SqlConnection CN)
        {
            string str = "";

            try
            {
                CN.Open();
                if (CN.State == ConnectionState.Open)
                {
                    int cnt = 1;
                    SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Hello", CN);
                    SqlDataReader reader;
                    reader = sqlcmd.ExecuteReader();

                    while (reader.Read())
                    {
                        str += cnt.ToString() + " - " + reader.GetInt32(reader.GetOrdinal("MsgID")) + ", ";
                        str += reader.GetString(reader.GetOrdinal("MsgSubject"));
                        str += "\n";
                        cnt += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Error", MessageBoxButtons.OK);
            }

            if (CN.State == ConnectionState.Open)
                CN.Close();

            return str;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
