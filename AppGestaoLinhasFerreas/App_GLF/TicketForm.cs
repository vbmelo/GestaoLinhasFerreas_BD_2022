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
            carregarRotas();
        }

        SqlConnection sqlCon = null;
        private string strCon = @"Data Source=DESKTOP-77GBOEO;Initial Catalog=Comboios3;Integrated Security=True";
        private string strSql = string.Empty;

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
            strSql = "insert into Person (idper, firstname, lastname, CC, phone) values (@idper, @firstname, @lastname, @CC, @phone)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            /*Gerar ID unico*/
            string uniqueIdper = Guid.NewGuid().ToString();
            MessageBox.Show("Novo ID Gerado Com Sucesso:   " + uniqueIdper);
            txtId.Text = uniqueIdper;

            comando.Parameters.Add("@idper", SqlDbType.VarChar).Value = txtId.Text;
            comando.Parameters.Add("@firstname", SqlDbType.VarChar).Value = txtFirstname.Text;
            comando.Parameters.Add("@lastname", SqlDbType.VarChar).Value = txtLastname.Text;
            comando.Parameters.Add("@CC", SqlDbType.VarChar).Value = mskCC.Text;
            comando.Parameters.Add("@phone", SqlDbType.VarChar).Value = mskPhone.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
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
            strSql = "select * from person where idper=@idper";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            //comando.Parameters.Add("idper", SqlDbType.VarChar).Value = tstIdBuscar.Text;
            comando.Parameters.AddWithValue("@idper", idParaBuscar.Text);

            try
            {
                if (idParaBuscar.Text == string.Empty)
                {
                    throw new Exception("Voce precisa digitar um id!");
                }

                sqlCon.Open();

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
            finally
            {
                sqlCon.Close();
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
            strSql = "select * from route";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            sqlCon.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                listaRotas.Items.Add(dr["name"]);
            }

            sqlCon.Close();
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
            strSql = "update Person set idper=@idper, firstname=@firstname, lastname=@lastname, CC=@CC, phone=@phone where idper=@IdBuscar";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@IdBuscar", SqlDbType.VarChar).Value = txtId.Text;

            comando.Parameters.Add("@idper", SqlDbType.VarChar).Value = txtId.Text;
            comando.Parameters.Add("@firstname", SqlDbType.VarChar).Value = txtFirstname.Text;
            comando.Parameters.Add("@lastname", SqlDbType.VarChar).Value = txtLastname.Text;
            comando.Parameters.Add("@CC", SqlDbType.VarChar).Value = mskCC.Text;
            comando.Parameters.Add("@phone", SqlDbType.VarChar).Value = mskPhone.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Atualizado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
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
                strSql = "delete from Person where idper=@idper";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@idper", SqlDbType.VarChar).Value = txtId.Text;
                try
                {
                    sqlCon.Open();
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
                    sqlCon.Close();
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
    }
}
