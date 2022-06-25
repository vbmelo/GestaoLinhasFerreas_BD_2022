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
        SqlConnection CN = null;
        public TicketForm(SqlConnection CN)
        {
            InitializeComponent();
            this.CN = CN;
        }


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
            string strSql = "insert into Person (idper, firstname, lastname, CC, phone, age) values (@idper, @firstname, @lastname, @CC, @phone, @age)";
            SqlCommand comando = new SqlCommand(strSql, CN);

            var uniqueIdper = System.Guid.NewGuid().ToString();

            comando.Parameters.AddWithValue("@idper", uniqueIdper);
            comando.Parameters.Add("@firstname", SqlDbType.VarChar, 50).Value = txtFirstname;
            comando.Parameters.Add("@lastname", SqlDbType.VarChar, 50).Value = txtLastname;
            comando.Parameters.Add("@cc", SqlDbType.VarChar, 50).Value = mskCC;
            comando.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = mskPhone;
            comando.Parameters.Add("@age", SqlDbType.VarChar, 50).Value = txtAge;

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com Sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
     
        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string strSql = "select * from person where idper=@idper";
            SqlCommand comando = new SqlCommand(strSql, CN);

            //comando.Parameters.Add("idper", SqlDbType.VarChar).Value = tstIdBuscar.Text;
            comando.Parameters.AddWithValue("@idper", tstIdBuscar.Text);

            try
            {
                if (tstIdBuscar.Text == string.Empty)
                {
                    throw new Exception("Voce precisa digitar um id!");
                }

      

                SqlDataReader dr = comando.ExecuteReader();

                dr.Read();

                if (dr.HasRows == false)
                {
                    throw new Exception("Id não cadastrado!");
                }

                txtId.Text = Convert.ToString(dr["idper"]);
                txtFirstname.Text = Convert.ToString(dr["firstname"]);
                txtLastname.Text = Convert.ToString(dr["lastname"]);
                mskCC.Text = Convert.ToString(dr["CC"]);
                mskPhone.Text = Convert.ToString(dr["phone"]);
                // txtAge.Text = Convert.ToString(dr["age"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
            
        }
    }
}
