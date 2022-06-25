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
    public partial class ComboiosForms : Form
    {

        /*Alterar a string strCon para a vossa base de dados.*/
        private string strCon = @"Data Source=DESKTOP-77GBOEO;Initial Catalog=Comboios5;Integrated Security=True";
        private string strSql = string.Empty;
        /*Alterar a string CN para a vossa base de dados.*/
        SqlConnection CN = new SqlConnection(@"Data Source=DESKTOP-77GBOEO;Initial Catalog=Comboios5;Integrated Security=True");
        public ComboiosForms(SqlConnection CN)
        {
            InitializeComponent();
            carregarComboios();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgComboios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void carregarComboios()
        {
            String strSql = "select Train.[name] as Comboio, Train.capacity as Capacidade, Train.track as Linha, Station.[name] as Estação, [Route].[name] as Rota, [Route].preco, Horario.horaChegada, Horario.horaPartida from (Horario left outer join [Route] on Horario.idHora=[Route].idHora) join Station on [Route].rid=Station.rid join Train on [Route].rid=Train.rid where Horario.idHora is not NULL and [Route].rid is not NULL";
            SqlCommand comando = new SqlCommand(strSql, CN);
            CN.Open();
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(comando);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dgComboios.DataSource = dtRecord;
            CN.Close();
        }
    }
}
