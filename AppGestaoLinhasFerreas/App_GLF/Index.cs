using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace App_GLF
{
    public partial class Index : Form
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

        public Index()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void IndexPanel_Load(object sender, EventArgs e)
        {

        }
        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void LoadTicket()
        {
            TicketForm ticket = new TicketForm();
            ticket.TopLevel = false;
            ticket.Dock = DockStyle.Right;
            ticket.Tag = ticket;
            ticket.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(ticket);
            ticket.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnTickets.Height;
            PnlNav.Top = btnTickets.Top;
            PnlNav.Left = btnTickets.Left;
            btnTickets.BackColor = Color.FromArgb(46, 51, 73);
            LoadTicket();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnPesquisa.Height;
            PnlNav.Top = btnPesquisa.Top;
            PnlNav.Left = btnPesquisa.Left;
            btnPesquisa.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnComboios_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnComboios.Height;
            PnlNav.Top = btnComboios.Top;
            PnlNav.Left = btnComboios.Left;
            btnComboios.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnLogout.Height;
            PnlNav.Top = btnLogout.Top;
            PnlNav.Left = btnLogout.Left;
            btnLogout.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnTickets_Leave(object sender, EventArgs e)
        {
            btnTickets.BackColor = Color.FromArgb(20, 20, 20);
            
        }

        private void btnPesquisa_Leave(object sender, EventArgs e)
        {
            btnPesquisa.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void btnComboios_Leave(object sender, EventArgs e)
        {
            btnComboios.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
