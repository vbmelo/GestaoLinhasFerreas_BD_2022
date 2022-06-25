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
        //SqlConnection CN = null;
        /*Alterar a string strCon para a vossa base de dados.*/
        private string strCon = @"Data Source=DESKTOP-77GBOEO;Initial Catalog=Comboios5;Integrated Security=True";
        private string strSql = string.Empty;
        /*Alterar a string CN para a vossa base de dados.*/
        SqlConnection CN = new SqlConnection(@"Data Source=DESKTOP-77GBOEO;Initial Catalog=Comboios5;Integrated Security=True");
        public TicketForm(SqlConnection CN)
        {
            InitializeComponent();
            carregarRotas();
            carregarUsuarios();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = true;
            txtId.Enabled = false;
            txtFirstname.Enabled = false;
            txtLastname.Enabled = false;
            txtAge.Enabled = false;
            mskCC.Enabled = false;
            mskPhone.Enabled = false;
            idParaBuscar.Enabled = true;

            txtId.Text = "";
            txtFirstname.Text = "";
            txtAge.Text = "";
            mskCC.Text = "";
            mskPhone.Text = "";
            txtLastname.Text = "";
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

            /*Gerar ID unico*/
            string uniqueIdper = Guid.NewGuid().ToString();
            MessageBox.Show("Novo ID Gerado Com Sucesso:   " + uniqueIdper);
            txtId.Text = uniqueIdper;

            comando.Parameters.Add("@idper", SqlDbType.VarChar,50).Value = txtId.Text;
            comando.Parameters.Add("@firstname", SqlDbType.VarChar, 50).Value = txtFirstname.Text;
            comando.Parameters.Add("@lastname", SqlDbType.VarChar, 50).Value = txtLastname.Text;
            comando.Parameters.Add("@cc", SqlDbType.VarChar, 50).Value = mskCC.Text;
            comando.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = mskPhone.Text;
            comando.Parameters.Add("@age", SqlDbType.VarChar, 50).Value = txtAge.Text;

            try
            {
                CN.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CN.Close();
            }
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = true;
            txtId.Enabled = false;
            txtFirstname.Enabled = false;
            txtLastname.Enabled = false;
            txtAge.Enabled = false;
            mskCC.Enabled = false;
            mskPhone.Enabled = false;
            idParaBuscar.Enabled = false;

            txtId.Text = "";
            txtFirstname.Text = "";
            txtAge.Text = "";
            mskCC.Text = "";
            mskPhone.Text = "";
            txtLastname.Text = "";
            idParaBuscar.Text = "";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string strSql = "select * from person where idper=@idper";
            SqlCommand comando = new SqlCommand(strSql, CN);

            comando.Parameters.AddWithValue("@idper", idParaBuscar.Text);

            try
            {
                CN.Open();
                if (tstIdBuscar.Text == string.Empty)
                {
                    throw new Exception("Voce precisa digitar um id!");
                }
                comando.Connection = CN;
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
                txtAge.Text = Convert.ToString(dr["age"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CN.Close();
            }
            tsbNovo.Enabled = false;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = true;
            tsbBuscar.Enabled = true;
            txtId.Enabled = true;
            txtFirstname.Enabled = true;
            txtLastname.Enabled = true;
            txtAge.Enabled = true;
            mskCC.Enabled = true;
            mskPhone.Enabled = true;
            idParaBuscar.Enabled = true;

            idParaBuscar.Text = "";
            txtFirstname.Focus();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            /*Gerar ID unico*/
            string uniqueIdper = Guid.NewGuid().ToString();
            MessageBox.Show("Novo ID Gerado Com Sucesso:   " + uniqueIdper);
            txtId.Text = uniqueIdper;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ticketUsuarioExistente_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void carregarRotas()
        {
            String strSql = "select * from route";
            SqlCommand comando = new SqlCommand(strSql, CN);
            CN.Open();
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                listaRotas.Items.Add(dr["name"]);
            }
            CN.Close();
        }

        private void carregarUsuarios()
        {
            String strSql = "select * from Person";
            SqlCommand comando = new SqlCommand(strSql, CN);
            CN.Open();
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(comando);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dgPessoas.DataSource = dtRecord;
            CN.Close();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dataViagem.MinDate = DateTime.Now;
            dataViagem.MaxDate = DateTime.Now.AddDays(15);


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            String strSql = "update Person set idper=@idper, firstname=@firstname, lastname=@lastname, CC=@CC, phone=@phone where idper=@IdBuscar";
            SqlCommand comando = new SqlCommand(strSql, CN);

            comando.Parameters.Add("@IdBuscar", SqlDbType.VarChar).Value = txtId.Text;
            comando.Parameters.Add("@idper", SqlDbType.VarChar).Value = txtId.Text;
            comando.Parameters.Add("@firstname", SqlDbType.VarChar).Value = txtFirstname.Text;
            comando.Parameters.Add("@lastname", SqlDbType.VarChar).Value = txtLastname.Text;
            comando.Parameters.Add("@CC", SqlDbType.VarChar).Value = mskCC.Text;
            comando.Parameters.Add("@phone", SqlDbType.VarChar).Value = mskPhone.Text;

            try
            {
                CN.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Atualizado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CN.Close();
            }
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = true;
            txtId.Enabled = false;
            txtFirstname.Enabled = false;
            txtLastname.Enabled = false;
            txtAge.Enabled = false;
            mskCC.Enabled = false;
            mskPhone.Enabled = false;
            idParaBuscar.Enabled = false;

            txtId.Text = "";
            txtFirstname.Text = "";
            txtAge.Text = "";
            mskCC.Text = "";
            mskPhone.Text = "";
            txtLastname.Text = "";
            idParaBuscar.Text = "";
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente excluir esta Pessoa?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operacao Cancelada!");
            }
            else
            {
                String strSql  = "delete from Person where idper=@idper";
                SqlCommand comando = new SqlCommand(strSql, CN);

                comando.Parameters.Add("@idper", SqlDbType.VarChar).Value = txtId.Text;
                try
                {
                    CN.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Pessoal deletado com Sucesso!");
                    txtId.Text = "";
                    txtFirstname.Text = "";
                    txtLastname.Text = "";
                    mskCC.Text = "";
                    mskPhone.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CN.Close();
                }
            }

            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = true;
            txtId.Enabled = false;
            txtFirstname.Enabled = false;
            txtLastname.Enabled = false;
            txtAge.Enabled = false;
            mskCC.Enabled = false;
            mskPhone.Enabled = false;
            idParaBuscar.Enabled = false;

            txtId.Text = "";
            txtFirstname.Text = "";
            txtAge.Text = "";
            mskCC.Text = "";
            mskPhone.Text = "";
            txtLastname.Text = "";
            idParaBuscar.Text = "";
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = false;
            tsbSalvar.Enabled = true;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = false;
            txtId.Enabled = true;
            txtFirstname.Enabled = true;
            txtLastname.Enabled = true;
            txtAge.Enabled = true;
            mskCC.Enabled = true;
            mskPhone.Enabled = true;

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = true;
            txtId.Enabled = false;
            txtFirstname.Enabled = false;
            txtLastname.Enabled = false;
            txtAge.Enabled = false;
            mskCC.Enabled = false;
            mskPhone.Enabled = false;
            idParaBuscar.Enabled = true;

            txtId.Text = "";
            txtFirstname.Text = "";
            txtAge.Text = "";
            mskCC.Text = "";
            mskPhone.Text = "";
            txtLastname.Text = "";
            idParaBuscar.Text = "";
        }

        private void dgPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}