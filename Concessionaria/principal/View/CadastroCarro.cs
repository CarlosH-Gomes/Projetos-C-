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
    public partial class CadastroCarro : Form
    {
        public string operacao = "";
        public CadastroCarro()
        {
            InitializeComponent();
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
            txt_modelo.Clear();
            txt_marca.Clear();
            txt_ano.Clear();
            txt_cor.Clear();
            txt_placa.Clear();
            txt_chassi.Clear();
            txt_renavam.Clear();
            txt_valor.Clear();
            txt_ipva.Clear();
            txt_lice.Clear();
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            try//validação simples
            {
                Carro carro = new Carro();
                if (txt_placa.Text.Length <= 0)
                {
                    MessageBox.Show("Placa Obrigatorio");
                    return;
                }
                carro.Placa = txt_placa.Text;
                carro.Modelo = txt_modelo.Text;
                carro.Marca = txt_marca.Text;
                carro.Ano = txt_ano.Text;
                carro.Cor = txt_cor.Text;
                carro.Chassi = txt_chassi.Text;
                carro.Renavam = txt_renavam.Text;
                carro.Valor = txt_valor.Text;
                carro.Ipva = txt_ipva.Text;
                carro.Licenciamento = txt_lice.Text;
                String strConexao = @"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True";
                Conexao conexao = new Conexao(strConexao);
                CadCarro dal = new CadCarro(conexao);
                if (this.operacao == "inserir")
                {

                    try
                    {
                        dal.Incluir(carro);
                        MessageBox.Show("Cadastrado");

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }
                }
                else
                {
                    dal.Alterar(carro);
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
            CadCarro dal = new CadCarro(conexao);
            dal.Excluir(txt_placa.Text);
            this.AlteraBotoes(1);
            this.LimpaCampos();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            frm_consultaCarro f = new frm_consultaCarro();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                String strConexao = @"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True";
                Conexao conexao = new Conexao(strConexao);
                CadCarro dal = new CadCarro(conexao);
                Carro car = dal.carregaCarro(f.codigo);
                txt_modelo.Text = car.Modelo;
                txt_marca.Text = car.Marca;
                txt_ano.Text = car.Ano;
                txt_cor.Text = car.Cor;
                txt_placa.Text = car.Placa;
                txt_chassi.Text = car.Chassi;
                txt_renavam.Text = car.Renavam;
                txt_valor.Text = car.Valor;
                txt_ipva.Text = car.Ipva;
                txt_lice.Text = car.Licenciamento;
                this.AlteraBotoes(3);

            }
            f.Dispose();
        }

        private void CadastroCarro_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            this.LimpaCampos();
        }
    }
}
