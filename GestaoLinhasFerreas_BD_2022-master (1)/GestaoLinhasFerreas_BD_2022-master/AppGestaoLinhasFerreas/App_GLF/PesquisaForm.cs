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

        SqlConnection CN = null;
        public PesquisaForm(SqlConnection CN)
        {
            InitializeComponent();
            this.CN = CN;

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var role = selecaoRole.SelectedItem.ToString();
            if (role == "Condutor")
            {
                this.roleQuery = "Driver";
            }
            else if (role == "Funcionario") {
                this.roleQuery = "Employee";
            }
            else {
                this.roleQuery = "Passenger";
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)

        {

            var field = selecaoRole.SelectedItem.ToString();
            if (field == "Nome")
            {
                this.fieldQuery = "firstname";
            }
            else if (field == "Apelido")
            {
                this.fieldQuery = "lastname";
            }
            else if (field == "CC")
            {
                this.fieldQuery = "cc";
            }
            else {

                this.fieldQuery = "idper";

            }

        }


        private void button9_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", CN);


        }


    }
}
