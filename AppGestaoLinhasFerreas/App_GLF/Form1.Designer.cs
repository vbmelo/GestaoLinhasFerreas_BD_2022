
namespace App_GLF
{
    partial class Form1
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
            this.tituloLogin = new System.Windows.Forms.Label();
            this.serverLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.btn_connect_db = new System.Windows.Forms.Button();
            this.logoDetiUa = new System.Windows.Forms.PictureBox();
            this.fundoComboios = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoDetiUa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundoComboios)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLogin
            // 
            this.tituloLogin.AutoSize = true;
            this.tituloLogin.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tituloLogin.Location = new System.Drawing.Point(724, 64);
            this.tituloLogin.Name = "tituloLogin";
            this.tituloLogin.Size = new System.Drawing.Size(484, 51);
            this.tituloLogin.TabIndex = 1;
            this.tituloLogin.Text = "Gestão de Linhas Férreas";
            this.tituloLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.serverLabel.Location = new System.Drawing.Point(728, 226);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(288, 29);
            this.serverLabel.TabIndex = 2;
            this.serverLabel.Text = "Endereço do Servidor SQL";
            this.serverLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernameLabel.Location = new System.Drawing.Point(728, 338);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(197, 29);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Nome de Usuário";
            this.usernameLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLabel.Location = new System.Drawing.Point(728, 445);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 29);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Senha";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // server
            // 
            this.server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.server.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server.ForeColor = System.Drawing.Color.White;
            this.server.Location = new System.Drawing.Point(733, 258);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(475, 27);
            this.server.TabIndex = 5;
            this.server.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(733, 370);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(475, 27);
            this.username.TabIndex = 6;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Montserrat", 12F);
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(733, 477);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(475, 27);
            this.password.TabIndex = 7;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // btn_connect_db
            // 
            this.btn_connect_db.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect_db.Location = new System.Drawing.Point(733, 570);
            this.btn_connect_db.Name = "btn_connect_db";
            this.btn_connect_db.Size = new System.Drawing.Size(475, 32);
            this.btn_connect_db.TabIndex = 8;
            this.btn_connect_db.Text = "connect";
            this.btn_connect_db.UseVisualStyleBackColor = true;
            this.btn_connect_db.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoDetiUa
            // 
            this.logoDetiUa.BackColor = System.Drawing.Color.Transparent;
            this.logoDetiUa.BackgroundImage = global::App_GLF.Properties.Resources.logoDetiUa_removebg_preview;
            this.logoDetiUa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoDetiUa.Location = new System.Drawing.Point(-1, -1);
            this.logoDetiUa.Name = "logoDetiUa";
            this.logoDetiUa.Size = new System.Drawing.Size(622, 93);
            this.logoDetiUa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoDetiUa.TabIndex = 9;
            this.logoDetiUa.TabStop = false;
            // 
            // fundoComboios
            // 
            this.fundoComboios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fundoComboios.Image = global::App_GLF.Properties.Resources.Fundo_Train_Preto_e_Branco;
            this.fundoComboios.Location = new System.Drawing.Point(-382, -1);
            this.fundoComboios.Name = "fundoComboios";
            this.fundoComboios.Size = new System.Drawing.Size(1003, 724);
            this.fundoComboios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundoComboios.TabIndex = 0;
            this.fundoComboios.TabStop = false;
            this.fundoComboios.Click += new System.EventHandler(this.fundoComboios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1273, 721);
            this.Controls.Add(this.logoDetiUa);
            this.Controls.Add(this.btn_connect_db);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.server);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.tituloLogin);
            this.Controls.Add(this.fundoComboios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoDetiUa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundoComboios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fundoComboios;
        private System.Windows.Forms.Label tituloLogin;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btn_connect_db;
        private System.Windows.Forms.PictureBox logoDetiUa;
    }
}

