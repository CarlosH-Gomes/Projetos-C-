using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace principal
{
    public partial class frm_compra : Form
    {
        int codigo = 0;
        public string operacao = "";
        public frm_compra()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            this.LimpaCampos();
        }
        public void AlteraBotoes(int op)
        {
            pdados.Enabled = false;
            btn_inserir.Enabled = false;
            btn_alterar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_localizar.Enabled = false;
            btn_cad.Enabled = false;
            btn_cancelar.Enabled = false;

            if (op == 1)
            {
                btn_inserir.Enabled = true;
                btn_localizar.Enabled = true;

            }
            if (op == 2)
            {
                pdados.Enabled = true;
                btn_cad.Enabled = true;
                btn_cancelar.Enabled = true;
            }
            if (op == 3)
            {
                btn_excluir.Enabled = true;
                btn_alterar.Enabled = true;
                btn_cancelar.Enabled = true;
            }
        }

        public void LimpaCampos()
        {
            txt_cpf.Clear();
            txt_dataCompra.Clear();
            txt_modelo.Clear();
            txt_nomeClin.Clear();
            txt_notaFiscal.Clear();
            txt_pesquisaCpf.Clear();
            txt_pesquisaPlaca.Clear();
            txt_placa.Clear();
            txt_renavam.Clear();
        }

       

        private void btn_pesquisaCpf_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao(@"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True");
            CadClin dal = new CadClin(cx);
            dgv_pesquisaCpf.DataSource = dal.Localizar(txt_pesquisaCpf.Text);
        }

        private void dgv_pesquisaCpf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_pesquisaCpf.Rows[e.RowIndex].Cells[0].Value);
                
                if (codigo != 0)
                {
                    String strConexao = @"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True";
                    Conexao conexao = new Conexao(strConexao);
                    CadClin dal = new CadClin(conexao);
                    Cliente contato = dal.carregaContato(codigo);
                    txt_cpf.Text = contato.Cpf;
                    txt_nomeClin.Text = contato.Nome;
                }
               
            }
        }

        private void btn_pesquisaPlaca_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao(@"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True");
            CadCarro dal = new CadCarro(cx);
            dgv_pesqsuisaPlaca.DataSource = dal.Localizar(txt_placa.Text);
        }

        private void dgv_pesqsuisaPlaca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_pesqsuisaPlaca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_pesqsuisaPlaca.Rows[e.RowIndex].Cells[0].Value);

                if (codigo != 0)
                {
                    String strConexao = @"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True";
                    Conexao conexao = new Conexao(strConexao);
                    CadCarro dal = new CadCarro(conexao);
                    Carro car = dal.carregaCarro(codigo);
                    txt_modelo.Text = car.Modelo;
                    txt_placa.Text = car.Placa;
                    txt_renavam.Text = car.Renavam;
                }

            }
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            try//validação simples
            {
                Compra compra = new Compra();
                if (txt_placa.Text.Length <= 0)
                {
                    MessageBox.Show("Número de Nota fiscal Obrigatorio");
                    return;
                }
                compra.NotaFiscal = txt_notaFiscal.Text;
                compra.Data = txt_dataCompra.Text;
                compra.Cpf = txt_cpf.Text;
                compra.Placa = txt_placa.Text;
                String strConexao = @"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True";
                Conexao conexao = new Conexao(strConexao);
                CadCompra dal = new CadCompra(conexao);

                if (this.operacao == "inserir")
                {

                    try
                    {
                        dal.Incluir(compra);
                        CadItemCompra aux = new CadItemCompra(conexao);
                        //aux.Incluir(compra);
                        MessageBox.Show("Cadastrado");

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }
                }
                else
                {
                    //aux.Alterar(compra);
                    dal.Alterar(compra);
                    MessageBox.Show("Registro alterado ");
                }
                this.AlteraBotoes(1);
                this.LimpaCampos();
            }
            catch (Exception erro)//
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlteraBotoes(2);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
            String strConexao = @"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True";
            Conexao conexao = new Conexao(strConexao);
            CadItemCompra aux = new CadItemCompra(conexao);
            CadCompra dal = new CadCompra(conexao);
           //aux.Excluir(txt_notaFiscal.Text);
            dal.Excluir(txt_notaFiscal.Text);
            this.AlteraBotoes(1);
            this.LimpaCampos();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            frm_consultaCompra f = new frm_consultaCompra();
            f.ShowDialog();
            if (String.IsNullOrEmpty(f.codigo) == false)
            {
                String strConexao = @"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True";
                Conexao conexao = new Conexao(strConexao);
                CadCompra dal2 = new CadCompra(conexao);
                Compra compra = dal2.carregaCompra(f.codigo);
                //CadCarro dal = new CadCarro(conexao);
                //Carro car = dal.carregaCarro(compra.Cpf);
                txt_dataCompra.Text = compra.Data;
                txt_notaFiscal.Text = compra.NotaFiscal;
                CadClin dal1 = new CadClin(conexao);
                Cliente cliente = dal1.carregaContato(compra.Cpf);
                txt_cpf.Text = cliente.Cpf;
                txt_nomeClin.Text = cliente.Nome;
                this.AlteraBotoes(3);

            }
            f.Dispose();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }

        private void frm_compra_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }
    }
}
