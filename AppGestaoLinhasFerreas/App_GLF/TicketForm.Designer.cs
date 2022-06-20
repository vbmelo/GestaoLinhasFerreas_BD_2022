
namespace App_GLF
{
    partial class TicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            this.ticketFormTabs = new System.Windows.Forms.TabControl();
            this.ticketNovoUsuario = new System.Windows.Forms.TabPage();
            this.btnGenerateID = new System.Windows.Forms.Button();
            this.mskCC = new System.Windows.Forms.MaskedTextBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tstIdBuscar = new System.Windows.Forms.ToolStripLabel();
            this.idParaBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.idade = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.CC = new System.Windows.Forms.Label();
            this.apelido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ticketUsuarioExistente = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataViagem = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.listaRotas = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listaHorariosDasRotas = new System.Windows.Forms.ListBox();
            this.ticketFormTabs.SuspendLayout();
            this.ticketNovoUsuario.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ticketUsuarioExistente.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketFormTabs
            // 
            this.ticketFormTabs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ticketFormTabs.Controls.Add(this.ticketUsuarioExistente);
            this.ticketFormTabs.Controls.Add(this.ticketNovoUsuario);
            this.ticketFormTabs.Location = new System.Drawing.Point(12, 7);
            this.ticketFormTabs.Name = "ticketFormTabs";
            this.ticketFormTabs.SelectedIndex = 0;
            this.ticketFormTabs.Size = new System.Drawing.Size(976, 676);
            this.ticketFormTabs.TabIndex = 0;
            // 
            // ticketNovoUsuario
            // 
            this.ticketNovoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ticketNovoUsuario.Controls.Add(this.btnGenerateID);
            this.ticketNovoUsuario.Controls.Add(this.mskCC);
            this.ticketNovoUsuario.Controls.Add(this.mskPhone);
            this.ticketNovoUsuario.Controls.Add(this.txtId);
            this.ticketNovoUsuario.Controls.Add(this.label1);
            this.ticketNovoUsuario.Controls.Add(this.toolStrip1);
            this.ticketNovoUsuario.Controls.Add(this.txtAge);
            this.ticketNovoUsuario.Controls.Add(this.txtLastname);
            this.ticketNovoUsuario.Controls.Add(this.txtFirstname);
            this.ticketNovoUsuario.Controls.Add(this.idade);
            this.ticketNovoUsuario.Controls.Add(this.phone);
            this.ticketNovoUsuario.Controls.Add(this.CC);
            this.ticketNovoUsuario.Controls.Add(this.apelido);
            this.ticketNovoUsuario.Controls.Add(this.label4);
            this.ticketNovoUsuario.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketNovoUsuario.ForeColor = System.Drawing.Color.White;
            this.ticketNovoUsuario.Location = new System.Drawing.Point(4, 22);
            this.ticketNovoUsuario.Name = "ticketNovoUsuario";
            this.ticketNovoUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.ticketNovoUsuario.Size = new System.Drawing.Size(968, 650);
            this.ticketNovoUsuario.TabIndex = 0;
            this.ticketNovoUsuario.Text = "NovoUsuario";
            this.ticketNovoUsuario.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnGenerateID
            // 
            this.btnGenerateID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateID.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.btnGenerateID.Location = new System.Drawing.Point(302, 56);
            this.btnGenerateID.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateID.Name = "btnGenerateID";
            this.btnGenerateID.Size = new System.Drawing.Size(111, 27);
            this.btnGenerateID.TabIndex = 52;
            this.btnGenerateID.Text = "Gerar ID";
            this.btnGenerateID.UseVisualStyleBackColor = true;
            this.btnGenerateID.Click += new System.EventHandler(this.button7_Click);
            // 
            // mskCC
            // 
            this.mskCC.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCC.Location = new System.Drawing.Point(118, 195);
            this.mskCC.Mask = "999-000-0000";
            this.mskCC.Name = "mskCC";
            this.mskCC.Size = new System.Drawing.Size(295, 27);
            this.mskCC.TabIndex = 51;
            this.mskCC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // mskPhone
            // 
            this.mskPhone.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPhone.Location = new System.Drawing.Point(118, 244);
            this.mskPhone.Mask = "999-000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(295, 27);
            this.mskPhone.TabIndex = 50;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(118, 56);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(176, 27);
            this.txtId.TabIndex = 49;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.toolStrip1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbCancelar,
            this.tsbSalvar,
            this.tsbAlterar,
            this.tsbExcluir,
            this.tstIdBuscar,
            this.idParaBuscar,
            this.tsbBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(962, 25);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(23, 22);
            this.tsbNovo.Text = "Novo";
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Image = global::App_GLF.Properties.Resources.cancel__Custom_;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelar.Text = "Cancelar";
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.Image")));
            this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(23, 22);
            this.tsbSalvar.Text = "Salvar";
            this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
            // 
            // tsbAlterar
            // 
            this.tsbAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlterar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlterar.Image")));
            this.tsbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterar.Name = "tsbAlterar";
            this.tsbAlterar.Size = new System.Drawing.Size(23, 22);
            this.tsbAlterar.Text = "Alterar";
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(23, 22);
            this.tsbExcluir.Text = "Excluir";
            // 
            // tstIdBuscar
            // 
            this.tstIdBuscar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstIdBuscar.ForeColor = System.Drawing.Color.White;
            this.tstIdBuscar.Name = "tstIdBuscar";
            this.tstIdBuscar.Size = new System.Drawing.Size(99, 22);
            this.tstIdBuscar.Text = "Buscar por ID:";
            this.tstIdBuscar.Click += new System.EventHandler(this.tstIdBuscar_Click);
            // 
            // idParaBuscar
            // 
            this.idParaBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.idParaBuscar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idParaBuscar.ForeColor = System.Drawing.Color.White;
            this.idParaBuscar.Name = "idParaBuscar";
            this.idParaBuscar.Size = new System.Drawing.Size(100, 25);
            this.idParaBuscar.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(118, 291);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(295, 27);
            this.txtAge.TabIndex = 33;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(118, 146);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(295, 27);
            this.txtLastname.TabIndex = 30;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(118, 101);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(295, 27);
            this.txtFirstname.TabIndex = 29;
            // 
            // idade
            // 
            this.idade.AutoSize = true;
            this.idade.Location = new System.Drawing.Point(24, 291);
            this.idade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(59, 22);
            this.idade.TabIndex = 28;
            this.idade.Text = "Idade:";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(24, 244);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(66, 22);
            this.phone.TabIndex = 27;
            this.phone.Text = "Phone:";
            // 
            // CC
            // 
            this.CC.AutoSize = true;
            this.CC.Location = new System.Drawing.Point(24, 194);
            this.CC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(37, 22);
            this.CC.TabIndex = 26;
            this.CC.Text = "CC:";
            // 
            // apelido
            // 
            this.apelido.AutoSize = true;
            this.apelido.Location = new System.Drawing.Point(24, 153);
            this.apelido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apelido.Name = "apelido";
            this.apelido.Size = new System.Drawing.Size(74, 22);
            this.apelido.TabIndex = 25;
            this.apelido.Text = "Apelido:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nome:";
            // 
            // ticketUsuarioExistente
            // 
            this.ticketUsuarioExistente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ticketUsuarioExistente.Controls.Add(this.listaHorariosDasRotas);
            this.ticketUsuarioExistente.Controls.Add(this.button6);
            this.ticketUsuarioExistente.Controls.Add(this.button5);
            this.ticketUsuarioExistente.Controls.Add(this.button4);
            this.ticketUsuarioExistente.Controls.Add(this.textBox11);
            this.ticketUsuarioExistente.Controls.Add(this.label13);
            this.ticketUsuarioExistente.Controls.Add(this.label12);
            this.ticketUsuarioExistente.Controls.Add(this.dataViagem);
            this.ticketUsuarioExistente.Controls.Add(this.label11);
            this.ticketUsuarioExistente.Controls.Add(this.listaRotas);
            this.ticketUsuarioExistente.Controls.Add(this.label9);
            this.ticketUsuarioExistente.Controls.Add(this.textBox10);
            this.ticketUsuarioExistente.Controls.Add(this.label8);
            this.ticketUsuarioExistente.Font = new System.Drawing.Font("Montserrat", 12F);
            this.ticketUsuarioExistente.ForeColor = System.Drawing.Color.White;
            this.ticketUsuarioExistente.Location = new System.Drawing.Point(4, 22);
            this.ticketUsuarioExistente.Name = "ticketUsuarioExistente";
            this.ticketUsuarioExistente.Padding = new System.Windows.Forms.Padding(3);
            this.ticketUsuarioExistente.Size = new System.Drawing.Size(968, 650);
            this.ticketUsuarioExistente.TabIndex = 1;
            this.ticketUsuarioExistente.Text = "Comprar Ticket";
            this.ticketUsuarioExistente.Click += new System.EventHandler(this.ticketUsuarioExistente_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.button6.Location = new System.Drawing.Point(740, 550);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 39);
            this.button6.TabIndex = 38;
            this.button6.Text = "Comprar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.button5.Location = new System.Drawing.Point(562, 550);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 39);
            this.button5.TabIndex = 37;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.button4.Location = new System.Drawing.Point(387, 550);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 39);
            this.button4.TabIndex = 36;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(479, 466);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(150, 27);
            this.textBox11.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(396, 466);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 22);
            this.label13.TabIndex = 34;
            this.label13.Text = "Preço:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 189);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 22);
            this.label12.TabIndex = 33;
            this.label12.Text = "Hora:";
            // 
            // dataViagem
            // 
            this.dataViagem.Location = new System.Drawing.Point(479, 133);
            this.dataViagem.Margin = new System.Windows.Forms.Padding(4);
            this.dataViagem.MaxDate = new System.DateTime(2050, 12, 25, 0, 0, 0, 0);
            this.dataViagem.Name = "dataViagem";
            this.dataViagem.Size = new System.Drawing.Size(300, 27);
            this.dataViagem.TabIndex = 30;
            this.dataViagem.Value = new System.DateTime(2022, 6, 20, 0, 0, 0, 0);
            this.dataViagem.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(396, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 22);
            this.label11.TabIndex = 32;
            this.label11.Text = "Data:";
            // 
            // listaRotas
            // 
            this.listaRotas.FormattingEnabled = true;
            this.listaRotas.ItemHeight = 22;
            this.listaRotas.Items.AddRange(new object[] {
            "Selecionar Rota"});
            this.listaRotas.Location = new System.Drawing.Point(479, 84);
            this.listaRotas.Margin = new System.Windows.Forms.Padding(4);
            this.listaRotas.Name = "listaRotas";
            this.listaRotas.Size = new System.Drawing.Size(300, 26);
            this.listaRotas.TabIndex = 27;
            this.listaRotas.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "Rota:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(126, 89);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(128, 27);
            this.textBox10.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "CC:";
            // 
            // listaHorariosDasRotas
            // 
            this.listaHorariosDasRotas.FormattingEnabled = true;
            this.listaHorariosDasRotas.ItemHeight = 22;
            this.listaHorariosDasRotas.Items.AddRange(new object[] {
            "Selecionar Rota"});
            this.listaHorariosDasRotas.Location = new System.Drawing.Point(479, 189);
            this.listaHorariosDasRotas.Margin = new System.Windows.Forms.Padding(4);
            this.listaHorariosDasRotas.Name = "listaHorariosDasRotas";
            this.listaHorariosDasRotas.Size = new System.Drawing.Size(300, 26);
            this.listaHorariosDasRotas.TabIndex = 39;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1030, 724);
            this.ControlBox = false;
            this.Controls.Add(this.ticketFormTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketForm";
            this.ticketFormTabs.ResumeLayout(false);
            this.ticketNovoUsuario.ResumeLayout(false);
            this.ticketNovoUsuario.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ticketUsuarioExistente.ResumeLayout(false);
            this.ticketUsuarioExistente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ticketFormTabs;
        private System.Windows.Forms.TabPage ticketNovoUsuario;
        private System.Windows.Forms.TabPage ticketUsuarioExistente;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label idade;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label CC;
        private System.Windows.Forms.Label apelido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dataViagem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listaRotas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private System.Windows.Forms.ToolStripButton tsbAlterar;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.ToolStripLabel tstIdBuscar;
        private System.Windows.Forms.ToolStripTextBox idParaBuscar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCC;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.Button btnGenerateID;
        private System.Windows.Forms.ListBox listaHorariosDasRotas;
    }
}