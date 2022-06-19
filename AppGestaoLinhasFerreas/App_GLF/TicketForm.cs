using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App_GLF
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        private string strCon = @"data source=Data Source=DESKTOP-77GBOEO;Initial Catalog=Comboios2;Integrated Security=True";
        private string strSql = string.Empty;

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void da_Click(object sender, EventArgs e)
        {

        }

        private void destino_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tstIdBuscar_Click(object sender, EventArgs e)
        {

        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into Person (idper, firstname, lastname, CC, phone, age) values (@idper, @firstname, @lastname, @CC, @phone, @age)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            var uniqueIdper = System.Guid.NewGuid().ToString();

            comando.Parameters.AddWithValue("@idper", uniqueIdper);
            comando.Parameters.Add("@firstname", SqlDbType.VarChar, 50).Value = txtFirstname;
            comando.Parameters.Add("@lastname", SqlDbType.VarChar, 50).Value = txtLastname;
            comando.Parameters.Add("@cc", SqlDbType.VarChar, 50).Value = mskCC;
            comando.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = mskPhone;
            comando.Parameters.Add("@age", SqlDbType.VarChar, 50).Value = txtAge;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com Sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
