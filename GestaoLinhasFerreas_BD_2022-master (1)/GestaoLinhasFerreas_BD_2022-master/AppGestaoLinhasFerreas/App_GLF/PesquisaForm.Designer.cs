
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
            this.button9 = new System.Windows.Forms.Button();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.selecaoRole = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(696, 95);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 26);
            this.button9.TabIndex = 7;
            this.button9.Text = "Pesquisar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // listBox7
            // 
            this.listBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 20;
            this.listBox7.Items.AddRange(new object[] {
            "Nome",
            "Apelido",
            "CC",
            "ID"});
            this.listBox7.Location = new System.Drawing.Point(424, 98);
            this.listBox7.Margin = new System.Windows.Forms.Padding(4);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(210, 24);
            this.listBox7.TabIndex = 6;
            this.listBox7.SelectedIndexChanged += new System.EventHandler(this.listBox7_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(315, 98);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "Pesquisar por:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // selecaoRole
            // 
            this.selecaoRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selecaoRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecaoRole.FormattingEnabled = true;
            this.selecaoRole.ItemHeight = 20;
            this.selecaoRole.Items.AddRange(new object[] {
            "Condutor",
            "Funcionário ",
            "Passageiro"});
            this.selecaoRole.Location = new System.Drawing.Point(40, 92);
            this.selecaoRole.Margin = new System.Windows.Forms.Padding(4);
            this.selecaoRole.Name = "selecaoRole";
            this.selecaoRole.Size = new System.Drawing.Size(256, 24);
            this.selecaoRole.TabIndex = 4;
            this.selecaoRole.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // PesquisaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1030, 724);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.selecaoRole);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox selecaoRole;
    }
}