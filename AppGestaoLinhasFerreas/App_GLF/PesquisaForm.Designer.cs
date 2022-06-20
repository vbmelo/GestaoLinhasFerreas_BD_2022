
namespace App_GLF
{
    partial class PesquisaForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Texto de teste");
            this.button9 = new System.Windows.Forms.Button();
            this.listaTipoDados = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.listaTabelas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textoParaBusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(823, 148);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 36);
            this.button9.TabIndex = 7;
            this.button9.Text = "Pesquisar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // listaTipoDados
            // 
            this.listaTipoDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listaTipoDados.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaTipoDados.FormattingEnabled = true;
            this.listaTipoDados.ItemHeight = 22;
            this.listaTipoDados.Items.AddRange(new object[] {
            "id",
            "Cartão de Cidadão",
            "Nome",
            "Sobrenome"});
            this.listaTipoDados.Location = new System.Drawing.Point(430, 92);
            this.listaTipoDados.Margin = new System.Windows.Forms.Padding(4);
            this.listaTipoDados.Name = "listaTipoDados";
            this.listaTipoDados.Size = new System.Drawing.Size(210, 26);
            this.listaTipoDados.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(308, 92);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 22);
            this.label15.TabIndex = 5;
            this.label15.Text = "tipo de dado:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // listaTabelas
            // 
            this.listaTabelas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listaTabelas.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaTabelas.FormattingEnabled = true;
            this.listaTabelas.ItemHeight = 22;
            this.listaTabelas.Items.AddRange(new object[] {
            "Estação",
            "----------",
            "Condutor",
            "",
            "",
            "Funcionário ",
            "Passageiro"});
            this.listaTabelas.Location = new System.Drawing.Point(134, 92);
            this.listaTabelas.Margin = new System.Windows.Forms.Padding(4);
            this.listaTabelas.Name = "listaTabelas";
            this.listaTabelas.Size = new System.Drawing.Size(166, 26);
            this.listaTabelas.TabIndex = 4;
            this.listaTabelas.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pesquisar Por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textoParaBusca
            // 
            this.textoParaBusca.Location = new System.Drawing.Point(759, 97);
            this.textoParaBusca.Margin = new System.Windows.Forms.Padding(4);
            this.textoParaBusca.Name = "textoParaBusca";
            this.textoParaBusca.Size = new System.Drawing.Size(176, 23);
            this.textoParaBusca.TabIndex = 50;
            this.textoParaBusca.Text = "dado";
            this.textoParaBusca.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(660, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "Introduzir:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(17, 203);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(918, 443);
            this.listView1.TabIndex = 52;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // PesquisaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1030, 724);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoParaBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.listaTipoDados);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listaTabelas);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PesquisaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListBox listaTipoDados;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listaTabelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoParaBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
    }
}