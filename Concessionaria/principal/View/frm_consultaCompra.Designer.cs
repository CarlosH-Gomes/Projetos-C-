namespace principal
{
    partial class frm_consultaCompra
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
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.lbl_placa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Consulta Compra";
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(547, 57);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisa.TabIndex = 15;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // dgv_dados
            // 
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(12, 96);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.Size = new System.Drawing.Size(610, 261);
            this.dgv_dados.TabIndex = 14;
            this.dgv_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellContentClick);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(130, 57);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(400, 20);
            this.txt_cliente.TabIndex = 13;
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(9, 60);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(115, 13);
            this.lbl_placa.TabIndex = 12;
            this.lbl_placa.Text = "Número da Nota Fiscal";
            // 
            // frm_consultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 391);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.dgv_dados);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.label1);
            this.Name = "frm_consultaCompra";
            this.Text = "frm_consultaCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label lbl_placa;
    }
}