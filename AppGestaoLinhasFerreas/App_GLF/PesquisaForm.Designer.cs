
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
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(731, 92);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 26);
            this.button9.TabIndex = 7;
            this.button9.Text = "Pesquisar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // listBox7
            // 
            this.listBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 22;
            this.listBox7.Items.AddRange(new object[] {
            "levar na base de dados"});
            this.listBox7.Location = new System.Drawing.Point(433, 92);
            this.listBox7.Margin = new System.Windows.Forms.Padding(4);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(210, 26);
            this.listBox7.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(334, 92);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 22);
            this.label15.TabIndex = 5;
            this.label15.Text = "Rota/Role:";
            // 
            // listBox6
            // 
            this.listBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 22;
            this.listBox6.Items.AddRange(new object[] {
            "Condutor",
            "Funcionário ",
            "Passageiro"});
            this.listBox6.Location = new System.Drawing.Point(40, 92);
            this.listBox6.Margin = new System.Windows.Forms.Padding(4);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(256, 26);
            this.listBox6.TabIndex = 4;
            // 
            // PesquisaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1030, 724);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listBox6);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ListBox listBox6;
    }
}