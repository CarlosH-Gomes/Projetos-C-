namespace principal
{
    partial class frm_consultaCliente
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
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(550, 345);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 13;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(458, 345);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 12;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(550, 39);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisa.TabIndex = 11;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // dgv_dados
            // 
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(15, 78);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.Size = new System.Drawing.Size(610, 261);
            this.dgv_dados.TabIndex = 10;
            this.dgv_dados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellContentClick);
            this.dgv_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellContentClick);
            this.dgv_dados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellContentClick);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(107, 39);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(426, 20);
            this.txt_cliente.TabIndex = 9;
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(12, 42);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(70, 13);
            this.lbl_placa.TabIndex = 8;
            this.lbl_placa.Text = "Nome Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consulta de Cliente";
            // 
            // frm_consultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 375);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.dgv_dados);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.label1);
            this.Name = "frm_consultaCliente";
            this.Text = "frm_consultaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.Label label1;
    }
}