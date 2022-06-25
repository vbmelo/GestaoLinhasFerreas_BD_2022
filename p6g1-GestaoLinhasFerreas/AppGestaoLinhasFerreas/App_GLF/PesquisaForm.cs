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
    public partial class PesquisaForm : Form
    {
        String roleQuery;
        String fieldQuery;
        

        SqlConnection sqlCon = null;
        /*Alterar a string strCon para a vossa base de dados.*/
        private string strCon = @"Data Source=DESKTOP-77GBOEO;Initial Catalog=Comboios5;Integrated Security=True";
        private string strSql = string.Empty;

        SqlConnection CN = null;
        public PesquisaForm(SqlConnection CN)
        {
            InitializeComponent();
            this.CN = CN;

        }

        public void setRoleQuery(String s)
        {
            this.roleQuery = s;
        }
        public void setFieldQuery(String s)
        {
            this.fieldQuery = s;
        }


        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void button9_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            strSql = "SELECT * FROM ((SELECT * FROM "+ dropTable.SelectedItem.ToString() + ") AS T1 JOIN (SELECT * FROM Person WHERE " + dropField.SelectedItem.ToString() + "=@valorParaBusca) AS T2 ON (T1.idper = T2.idper))";
            sqlCon = new SqlConnection(strCon);

            SqlCommand cmd = new SqlCommand(strSql, sqlCon);

            //cmd.Parameters.AddWithValue("@table", dropTable.SelectedItem.ToString());
            //cmd.Parameters.AddWithValue("@field", dropField.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@valorParaBusca", valorParaBusca.Text);

            try
            {
                sqlCon.Open();
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                dgv1.DataSource = dtRecord;

                /*
                sqlCon.Open();
                cmd.Connection = sqlCon;
                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                DataTable dtb1 = new DataTable();
                dtb1.Load(dr);
                dgv1.DataSource = dtb1;
                */

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

        private void listBox7_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void selecaoRole_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PesquisaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comboios5DataSet.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.comboios5DataSet.Driver);

        }

        private void dropField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dropTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
