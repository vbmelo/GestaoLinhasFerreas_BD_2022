
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
            this.components = new System.ComponentModel.Container();
            this.button9 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.valorParaBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dropField = new System.Windows.Forms.ComboBox();
            this.comboios5DataSet = new App_GLF.Comboios5DataSet();
            this.comboios5DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableAdapter = new App_GLF.Comboios5DataSetTableAdapters.DriverTableAdapter();
            this.dropTable = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboios5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboios5DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(893, 673);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 26);
            this.button9.TabIndex = 11;
            this.button9.Text = "Pesquisar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label15.Location = new System.Drawing.Point(298, 30);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 22);
            this.label15.TabIndex = 9;
            this.label15.Text = "Pesquisar por:";
            // 
            // valorParaBusca
            // 
            this.valorParaBusca.Font = new System.Drawing.Font("Montserrat", 12F);
            this.valorParaBusca.Location = new System.Drawing.Point(719, 32);
            this.valorParaBusca.Margin = new System.Windows.Forms.Padding(4);
            this.valorParaBusca.Name = "valorParaBusca";
            this.valorParaBusca.Size = new System.Drawing.Size(286, 27);
            this.valorParaBusca.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tipo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label2.Location = new System.Drawing.Point(656, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "inserir:";
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(26, 90);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(979, 562);
            this.dgv1.TabIndex = 29;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // dropField
            // 
            this.dropField.FormattingEnabled = true;
            this.dropField.Items.AddRange(new object[] {
            "Whole Table Content",
            "idper",
            "firstname",
            "lastname",
            "CC",
            "phone",
            "age",
            "pid",
            "did",
            "idHora",
            "dia",
            "rid",
            "[name]",
            "[sid]",
            "trainid",
            "eid",
            "tid"});
            this.dropField.Location = new System.Drawing.Point(417, 32);
            this.dropField.Name = "dropField";
            this.dropField.Size = new System.Drawing.Size(232, 26);
            this.dropField.TabIndex = 31;
            this.dropField.SelectedIndexChanged += new System.EventHandler(this.dropField_SelectedIndexChanged);
            // 
            // comboios5DataSet
            // 
            this.comboios5DataSet.DataSetName = "Comboios5DataSet";
            this.comboios5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboios5DataSetBindingSource
            // 
            this.comboios5DataSetBindingSource.DataSource = this.comboios5DataSet;
            this.comboios5DataSetBindingSource.Position = 0;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.comboios5DataSetBindingSource;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // dropTable
            // 
            this.dropTable.FormattingEnabled = true;
            this.dropTable.Items.AddRange(new object[] {
            "Driver",
            "Employee",
            "Horario",
            "Passenger",
            "Person",
            "Route",
            "Station",
            "Ticket",
            "Train"});
            this.dropTable.Location = new System.Drawing.Point(74, 32);
            this.dropTable.Name = "dropTable";
            this.dropTable.Size = new System.Drawing.Size(217, 26);
            this.dropTable.TabIndex = 32;
            this.dropTable.SelectedIndexChanged += new System.EventHandler(this.dropTable_SelectedIndexChanged);
            // 
            // PesquisaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1030, 724);
            this.Controls.Add(this.dropTable);
            this.Controls.Add(this.dropField);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valorParaBusca);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label15);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PesquisaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisaForm";
            this.Load += new System.EventHandler(this.PesquisaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboios5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboios5DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox valorParaBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ComboBox dropField;
        private System.Windows.Forms.BindingSource comboios5DataSetBindingSource;
        private Comboios5DataSet comboios5DataSet;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private Comboios5DataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.ComboBox dropTable;
    }
}