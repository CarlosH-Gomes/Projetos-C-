namespace principal
{
    partial class frm_consultaCarro
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.dgv_dados1 = new System.Windows.Forms.DataGridView();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Carro";
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(12, 45);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(89, 13);
            this.lbl_placa.TabIndex = 1;
            this.lbl_placa.Text = "Placa do Veículo";
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(107, 42);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(426, 20);
            this.txt_placa.TabIndex = 2;
            // 
            // dgv_dados1
            // 
            this.dgv_dados1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados1.Location = new System.Drawing.Point(15, 81);
            this.dgv_dados1.Name = "dgv_dados1";
            this.dgv_dados1.Size = new System.Drawing.Size(610, 261);
            this.dgv_dados1.TabIndex = 3;
            this.dgv_dados1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados1_CellContentClick);
            this.dgv_dados1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados1_CellContentClick);
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(550, 42);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisa.TabIndex = 4;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(458, 348);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 5;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(550, 348);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // frm_consultaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 375);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.dgv_dados1);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.label1);
            this.Name = "frm_consultaCarro";
            this.Text = "Consulta Carro";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.DataGridView dgv_dados1;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_sair;
    }
}