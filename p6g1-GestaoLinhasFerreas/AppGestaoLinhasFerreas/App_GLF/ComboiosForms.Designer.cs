
namespace App_GLF
{
    partial class ComboiosForms
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
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dgComboios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgComboios)).BeginInit();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(903, 597);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 28);
            this.button8.TabIndex = 35;
            this.button8.Text = "Pesquisar";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(782, 597);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 28);
            this.button7.TabIndex = 34;
            this.button7.Text = "Limpar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(752, 94);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(186, 26);
            this.radioButton2.TabIndex = 33;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lugares disponiveis";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(748, 133);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 22);
            this.label14.TabIndex = 32;
            this.label14.Text = "Estação:";
            // 
            // listBox5
            // 
            this.listBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 22;
            this.listBox5.Items.AddRange(new object[] {
            "EstacaoDeLeiria",
            "EstacaoDeBraga",
            "EstacaoDeBraganca",
            "EstacaoDePorto",
            "EstacaoDeLisboa",
            "EstacaoDeSantarem",
            "EstacaoDeVilaReal",
            "EstacaoDeCoimbra",
            "EstacaoDeViseu",
            "EstacaoDeEvora",
            "EstacaoDeFaro",
            "EstacaoDeViana do Castelo",
            "EstacaoDeAveiro",
            "EstacaoDeBeja",
            "EstacaoDeGuarda",
            "EstacaoDeCastelo Branco",
            "EstacaoDeSetubal",
            "EstacaoDePortalegre"});
            this.listBox5.Location = new System.Drawing.Point(831, 133);
            this.listBox5.Margin = new System.Windows.Forms.Padding(4);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(186, 26);
            this.listBox5.TabIndex = 31;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(752, 64);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(209, 26);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Horários dos comboios";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dgComboios
            // 
            this.dgComboios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgComboios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComboios.Location = new System.Drawing.Point(12, 65);
            this.dgComboios.Name = "dgComboios";
            this.dgComboios.Size = new System.Drawing.Size(718, 560);
            this.dgComboios.TabIndex = 54;
            this.dgComboios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgComboios_CellContentClick);
            // 
            // ComboiosForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1030, 724);
            this.Controls.Add(this.dgComboios);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.radioButton1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ComboiosForms";
            this.Text = "ComboiosForms";
            ((System.ComponentModel.ISupportInitialize)(this.dgComboios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dgComboios;
    }
}