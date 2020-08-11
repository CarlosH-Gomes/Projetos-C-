namespace principal
{
    partial class CadastroCarro
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
            this.btn_cad = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.lbl_cor = new System.Windows.Forms.Label();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.lbl_chassi = new System.Windows.Forms.Label();
            this.txt_chassi = new System.Windows.Forms.TextBox();
            this.lbl_renavam = new System.Windows.Forms.Label();
            this.txt_renavam = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_ipva = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_ipva = new System.Windows.Forms.TextBox();
            this.lbl_licen = new System.Windows.Forms.Label();
            this.txt_lice = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.pdados = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pdados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cad
            // 
            this.btn_cad.Location = new System.Drawing.Point(545, 199);
            this.btn_cad.Name = "btn_cad";
            this.btn_cad.Size = new System.Drawing.Size(75, 23);
            this.btn_cad.TabIndex = 3;
            this.btn_cad.Text = "Salvar";
            this.btn_cad.UseVisualStyleBackColor = true;
            this.btn_cad.Click += new System.EventHandler(this.btn_cad_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(630, 199);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(464, 199);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 5;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE CARRO";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(6, 28);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(42, 13);
            this.lbl_modelo.TabIndex = 0;
            this.lbl_modelo.Text = "Modelo";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(54, 25);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(206, 20);
            this.txt_modelo.TabIndex = 1;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(282, 28);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_marca.TabIndex = 2;
            this.lbl_marca.Text = "Marca";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(330, 25);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(206, 20);
            this.txt_marca.TabIndex = 3;
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(557, 28);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(26, 13);
            this.lbl_ano.TabIndex = 4;
            this.lbl_ano.Text = "Ano";
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(589, 25);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(102, 20);
            this.txt_ano.TabIndex = 5;
            // 
            // lbl_cor
            // 
            this.lbl_cor.AutoSize = true;
            this.lbl_cor.Location = new System.Drawing.Point(22, 54);
            this.lbl_cor.Name = "lbl_cor";
            this.lbl_cor.Size = new System.Drawing.Size(23, 13);
            this.lbl_cor.TabIndex = 6;
            this.lbl_cor.Text = "Cor";
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(54, 51);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(102, 20);
            this.txt_cor.TabIndex = 7;
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(185, 54);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(34, 13);
            this.lbl_placa.TabIndex = 8;
            this.lbl_placa.Text = "Placa";
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(225, 51);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(102, 20);
            this.txt_placa.TabIndex = 9;
            // 
            // lbl_chassi
            // 
            this.lbl_chassi.AutoSize = true;
            this.lbl_chassi.Location = new System.Drawing.Point(362, 54);
            this.lbl_chassi.Name = "lbl_chassi";
            this.lbl_chassi.Size = new System.Drawing.Size(38, 13);
            this.lbl_chassi.TabIndex = 10;
            this.lbl_chassi.Text = "Chassi";
            // 
            // txt_chassi
            // 
            this.txt_chassi.Location = new System.Drawing.Point(402, 51);
            this.txt_chassi.Name = "txt_chassi";
            this.txt_chassi.Size = new System.Drawing.Size(102, 20);
            this.txt_chassi.TabIndex = 11;
            // 
            // lbl_renavam
            // 
            this.lbl_renavam.AutoSize = true;
            this.lbl_renavam.Location = new System.Drawing.Point(530, 54);
            this.lbl_renavam.Name = "lbl_renavam";
            this.lbl_renavam.Size = new System.Drawing.Size(53, 13);
            this.lbl_renavam.TabIndex = 12;
            this.lbl_renavam.Text = "Renavam";
            // 
            // txt_renavam
            // 
            this.txt_renavam.Location = new System.Drawing.Point(589, 51);
            this.txt_renavam.Name = "txt_renavam";
            this.txt_renavam.Size = new System.Drawing.Size(102, 20);
            this.txt_renavam.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_renavam);
            this.groupBox1.Controls.Add(this.lbl_renavam);
            this.groupBox1.Controls.Add(this.txt_chassi);
            this.groupBox1.Controls.Add(this.lbl_chassi);
            this.groupBox1.Controls.Add(this.txt_placa);
            this.groupBox1.Controls.Add(this.lbl_placa);
            this.groupBox1.Controls.Add(this.txt_cor);
            this.groupBox1.Controls.Add(this.lbl_cor);
            this.groupBox1.Controls.Add(this.txt_ano);
            this.groupBox1.Controls.Add(this.lbl_ano);
            this.groupBox1.Controls.Add(this.txt_marca);
            this.groupBox1.Controls.Add(this.lbl_marca);
            this.groupBox1.Controls.Add(this.txt_modelo);
            this.groupBox1.Controls.Add(this.lbl_modelo);
            this.groupBox1.Location = new System.Drawing.Point(3, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Carro";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(22, 22);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(31, 13);
            this.lbl_valor.TabIndex = 10;
            this.lbl_valor.Text = "Valor";
            // 
            // lbl_ipva
            // 
            this.lbl_ipva.AutoSize = true;
            this.lbl_ipva.Location = new System.Drawing.Point(188, 22);
            this.lbl_ipva.Name = "lbl_ipva";
            this.lbl_ipva.Size = new System.Drawing.Size(31, 13);
            this.lbl_ipva.TabIndex = 12;
            this.lbl_ipva.Text = "IPVA";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(54, 19);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(102, 20);
            this.txt_valor.TabIndex = 11;
            // 
            // txt_ipva
            // 
            this.txt_ipva.Location = new System.Drawing.Point(225, 19);
            this.txt_ipva.Name = "txt_ipva";
            this.txt_ipva.Size = new System.Drawing.Size(102, 20);
            this.txt_ipva.TabIndex = 13;
            // 
            // lbl_licen
            // 
            this.lbl_licen.AutoSize = true;
            this.lbl_licen.Location = new System.Drawing.Point(351, 22);
            this.lbl_licen.Name = "lbl_licen";
            this.lbl_licen.Size = new System.Drawing.Size(76, 13);
            this.lbl_licen.TabIndex = 14;
            this.lbl_licen.Text = "Licenciamento";
            // 
            // txt_lice
            // 
            this.txt_lice.Location = new System.Drawing.Point(434, 19);
            this.txt_lice.Name = "txt_lice";
            this.txt_lice.Size = new System.Drawing.Size(102, 20);
            this.txt_lice.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_lice);
            this.groupBox2.Controls.Add(this.lbl_licen);
            this.groupBox2.Controls.Add(this.txt_ipva);
            this.groupBox2.Controls.Add(this.txt_valor);
            this.groupBox2.Controls.Add(this.lbl_ipva);
            this.groupBox2.Controls.Add(this.lbl_valor);
            this.groupBox2.Location = new System.Drawing.Point(0, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 55);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(378, 199);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 34;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(211, 199);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 33;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_localizar
            // 
            this.btn_localizar.Location = new System.Drawing.Point(297, 199);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(75, 23);
            this.btn_localizar.TabIndex = 32;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // pdados
            // 
            this.pdados.Controls.Add(this.groupBox1);
            this.pdados.Controls.Add(this.groupBox2);
            this.pdados.Location = new System.Drawing.Point(12, 10);
            this.pdados.Name = "pdados";
            this.pdados.Size = new System.Drawing.Size(710, 183);
            this.pdados.TabIndex = 35;
            // 
            // CadastroCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 237);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.btn_localizar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_cad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pdados);
            this.Name = "CadastroCarro";
            this.Text = "CadastroCarro";
            this.Load += new System.EventHandler(this.CadastroCarro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pdados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cad;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.Label lbl_cor;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label lbl_chassi;
        private System.Windows.Forms.TextBox txt_chassi;
        private System.Windows.Forms.Label lbl_renavam;
        private System.Windows.Forms.TextBox txt_renavam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_ipva;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_ipva;
        private System.Windows.Forms.Label lbl_licen;
        private System.Windows.Forms.TextBox txt_lice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.Panel pdados;
    }
}