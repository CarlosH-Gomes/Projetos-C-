namespace principal
{
    partial class frm_compra
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
            this.Carro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_pesquisaCpf = new System.Windows.Forms.Button();
            this.dgv_pesquisaCpf = new System.Windows.Forms.DataGridView();
            this.txt_pesquisaCpf = new System.Windows.Forms.TextBox();
            this.lbl__pesquisaCpf = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_pesqsuisaPlaca = new System.Windows.Forms.DataGridView();
            this.btn_pesquisaPlaca = new System.Windows.Forms.Button();
            this.txt_pesquisaPlaca = new System.Windows.Forms.TextBox();
            this.lbl_pesquisaPlaca = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nomeClin = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.txt_renavam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dataCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_notaFiscal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.pdados = new System.Windows.Forms.Panel();
            this.Carro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaCpf)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesqsuisaPlaca)).BeginInit();
            this.pdados.SuspendLayout();
            this.SuspendLayout();
            // 
            // Carro
            // 
            this.Carro.Controls.Add(this.tabPage1);
            this.Carro.Controls.Add(this.tabPage2);
            this.Carro.Location = new System.Drawing.Point(10, 27);
            this.Carro.Name = "Carro";
            this.Carro.SelectedIndex = 0;
            this.Carro.Size = new System.Drawing.Size(776, 159);
            this.Carro.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_pesquisaCpf);
            this.tabPage1.Controls.Add(this.dgv_pesquisaCpf);
            this.tabPage1.Controls.Add(this.txt_pesquisaCpf);
            this.tabPage1.Controls.Add(this.lbl__pesquisaCpf);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 133);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_pesquisaCpf
            // 
            this.btn_pesquisaCpf.Location = new System.Drawing.Point(436, 12);
            this.btn_pesquisaCpf.Name = "btn_pesquisaCpf";
            this.btn_pesquisaCpf.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisaCpf.TabIndex = 3;
            this.btn_pesquisaCpf.Text = "Pesquisar";
            this.btn_pesquisaCpf.UseVisualStyleBackColor = true;
            this.btn_pesquisaCpf.Click += new System.EventHandler(this.btn_pesquisaCpf_Click);
            // 
            // dgv_pesquisaCpf
            // 
            this.dgv_pesquisaCpf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesquisaCpf.Location = new System.Drawing.Point(6, 40);
            this.dgv_pesquisaCpf.Name = "dgv_pesquisaCpf";
            this.dgv_pesquisaCpf.Size = new System.Drawing.Size(752, 87);
            this.dgv_pesquisaCpf.TabIndex = 2;
            this.dgv_pesquisaCpf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pesquisaCpf_CellContentClick);
            this.dgv_pesquisaCpf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pesquisaCpf_CellContentClick);
            // 
            // txt_pesquisaCpf
            // 
            this.txt_pesquisaCpf.Location = new System.Drawing.Point(48, 14);
            this.txt_pesquisaCpf.Name = "txt_pesquisaCpf";
            this.txt_pesquisaCpf.Size = new System.Drawing.Size(372, 20);
            this.txt_pesquisaCpf.TabIndex = 1;
            // 
            // lbl__pesquisaCpf
            // 
            this.lbl__pesquisaCpf.AutoSize = true;
            this.lbl__pesquisaCpf.Location = new System.Drawing.Point(15, 17);
            this.lbl__pesquisaCpf.Name = "lbl__pesquisaCpf";
            this.lbl__pesquisaCpf.Size = new System.Drawing.Size(27, 13);
            this.lbl__pesquisaCpf.TabIndex = 0;
            this.lbl__pesquisaCpf.Text = "CPF";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_pesqsuisaPlaca);
            this.tabPage2.Controls.Add(this.btn_pesquisaPlaca);
            this.tabPage2.Controls.Add(this.txt_pesquisaPlaca);
            this.tabPage2.Controls.Add(this.lbl_pesquisaPlaca);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 133);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Carro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_pesqsuisaPlaca
            // 
            this.dgv_pesqsuisaPlaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesqsuisaPlaca.Location = new System.Drawing.Point(6, 38);
            this.dgv_pesqsuisaPlaca.Name = "dgv_pesqsuisaPlaca";
            this.dgv_pesqsuisaPlaca.Size = new System.Drawing.Size(753, 89);
            this.dgv_pesqsuisaPlaca.TabIndex = 3;
            this.dgv_pesqsuisaPlaca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pesqsuisaPlaca_CellClick);
            this.dgv_pesqsuisaPlaca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pesqsuisaPlaca_CellContentClick);
            // 
            // btn_pesquisaPlaca
            // 
            this.btn_pesquisaPlaca.Location = new System.Drawing.Point(428, 9);
            this.btn_pesquisaPlaca.Name = "btn_pesquisaPlaca";
            this.btn_pesquisaPlaca.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisaPlaca.TabIndex = 2;
            this.btn_pesquisaPlaca.Text = "Pesquisar";
            this.btn_pesquisaPlaca.UseVisualStyleBackColor = true;
            this.btn_pesquisaPlaca.Click += new System.EventHandler(this.btn_pesquisaPlaca_Click);
            // 
            // txt_pesquisaPlaca
            // 
            this.txt_pesquisaPlaca.Location = new System.Drawing.Point(47, 12);
            this.txt_pesquisaPlaca.Name = "txt_pesquisaPlaca";
            this.txt_pesquisaPlaca.Size = new System.Drawing.Size(363, 20);
            this.txt_pesquisaPlaca.TabIndex = 1;
            // 
            // lbl_pesquisaPlaca
            // 
            this.lbl_pesquisaPlaca.AutoSize = true;
            this.lbl_pesquisaPlaca.Location = new System.Drawing.Point(7, 14);
            this.lbl_pesquisaPlaca.Name = "lbl_pesquisaPlaca";
            this.lbl_pesquisaPlaca.Size = new System.Drawing.Size(34, 13);
            this.lbl_pesquisaPlaca.TabIndex = 0;
            this.lbl_pesquisaPlaca.Text = "Placa";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(16, 195);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // txt_nomeClin
            // 
            this.txt_nomeClin.Location = new System.Drawing.Point(69, 192);
            this.txt_nomeClin.Name = "txt_nomeClin";
            this.txt_nomeClin.ReadOnly = true;
            this.txt_nomeClin.Size = new System.Drawing.Size(447, 20);
            this.txt_nomeClin.TabIndex = 2;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(567, 192);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.ReadOnly = true;
            this.txt_cpf.Size = new System.Drawing.Size(220, 20);
            this.txt_cpf.TabIndex = 4;
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Location = new System.Drawing.Point(534, 195);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_Cpf.TabIndex = 3;
            this.lbl_Cpf.Text = "CPF";
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(326, 218);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.ReadOnly = true;
            this.txt_placa.Size = new System.Drawing.Size(182, 20);
            this.txt_placa.TabIndex = 8;
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(286, 221);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(34, 13);
            this.lbl_placa.TabIndex = 7;
            this.lbl_placa.Text = "Placa";
            // 
            // txt_renavam
            // 
            this.txt_renavam.Location = new System.Drawing.Point(69, 218);
            this.txt_renavam.Name = "txt_renavam";
            this.txt_renavam.ReadOnly = true;
            this.txt_renavam.Size = new System.Drawing.Size(211, 20);
            this.txt_renavam.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Renavam";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(567, 221);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.ReadOnly = true;
            this.txt_modelo.Size = new System.Drawing.Size(182, 20);
            this.txt_modelo.TabIndex = 10;
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(527, 224);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(42, 13);
            this.lbl_modelo.TabIndex = 9;
            this.lbl_modelo.Text = "Modelo";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(712, 279);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_cad
            // 
            this.btn_cad.Location = new System.Drawing.Point(631, 279);
            this.btn_cad.Name = "btn_cad";
            this.btn_cad.Size = new System.Drawing.Size(75, 23);
            this.btn_cad.TabIndex = 12;
            this.btn_cad.Text = "Salvar";
            this.btn_cad.UseVisualStyleBackColor = true;
            this.btn_cad.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nova compra";
            // 
            // txt_dataCompra
            // 
            this.txt_dataCompra.Location = new System.Drawing.Point(326, 244);
            this.txt_dataCompra.Name = "txt_dataCompra";
            this.txt_dataCompra.Size = new System.Drawing.Size(103, 20);
            this.txt_dataCompra.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data";
            // 
            // txt_notaFiscal
            // 
            this.txt_notaFiscal.Location = new System.Drawing.Point(123, 244);
            this.txt_notaFiscal.Name = "txt_notaFiscal";
            this.txt_notaFiscal.Size = new System.Drawing.Size(157, 20);
            this.txt_notaFiscal.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Numero Nota Fiscal";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(460, 279);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 38;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(293, 279);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 37;
            this.btn_inserir.Text = "Comprar";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_localizar
            // 
            this.btn_localizar.Location = new System.Drawing.Point(379, 279);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(75, 23);
            this.btn_localizar.TabIndex = 36;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(546, 279);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 35;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // pdados
            // 
            this.pdados.Controls.Add(this.label1);
            this.pdados.Controls.Add(this.Carro);
            this.pdados.Controls.Add(this.txt_nomeClin);
            this.pdados.Controls.Add(this.lbl_nome);
            this.pdados.Controls.Add(this.txt_dataCompra);
            this.pdados.Controls.Add(this.lbl_Cpf);
            this.pdados.Controls.Add(this.label3);
            this.pdados.Controls.Add(this.txt_cpf);
            this.pdados.Controls.Add(this.txt_notaFiscal);
            this.pdados.Controls.Add(this.label2);
            this.pdados.Controls.Add(this.label4);
            this.pdados.Controls.Add(this.txt_renavam);
            this.pdados.Controls.Add(this.lbl_placa);
            this.pdados.Controls.Add(this.txt_placa);
            this.pdados.Controls.Add(this.txt_modelo);
            this.pdados.Controls.Add(this.lbl_modelo);
            this.pdados.Location = new System.Drawing.Point(2, 0);
            this.pdados.Name = "pdados";
            this.pdados.Size = new System.Drawing.Size(796, 273);
            this.pdados.TabIndex = 39;
            // 
            // frm_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.btn_localizar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_cad);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.pdados);
            this.Name = "frm_compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.frm_compra_Load);
            this.Carro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaCpf)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesqsuisaPlaca)).EndInit();
            this.pdados.ResumeLayout(false);
            this.pdados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Carro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_pesquisaCpf;
        private System.Windows.Forms.TextBox txt_pesquisaCpf;
        private System.Windows.Forms.Label lbl__pesquisaCpf;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_pesquisaCpf;
        private System.Windows.Forms.DataGridView dgv_pesqsuisaPlaca;
        private System.Windows.Forms.Button btn_pesquisaPlaca;
        private System.Windows.Forms.TextBox txt_pesquisaPlaca;
        private System.Windows.Forms.Label lbl_pesquisaPlaca;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nomeClin;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox txt_renavam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dataCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_notaFiscal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Panel pdados;
    }
}