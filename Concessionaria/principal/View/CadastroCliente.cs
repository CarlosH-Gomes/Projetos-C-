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
    public partial class CadastroCliente : Form
    {
        public string operacao = "";

        public CadastroCliente()
        {
            InitializeComponent();
        }
        public void AlteraBotoes(int op)
        {
            pdados1.Enabled = false;
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
                pdados1.Enabled = true;
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
            txt_nome.Clear();
            txt_cpf.Clear();
            txt_rg.Clear();
            txt_tel.Clear();
            txt_cidade.Clear();
            txt_rua.Clear();
            txt_cep.Clear();
            txt_numCasa.Clear();
            txt_compCasa.Clear();
            txt_codAgencia.Clear();
            txt_nomeAgencia.Clear();
            txt_contaCorrente.Clear();
            txt_banco.Clear();
        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cb_estado.Items.Add("AC","AL","AP","AM","BA","CE","DF","ES","GO","MA","MT","MS","MG","PA","PB","PR","PE","PI","RJ","RN","RS","RO","RR","SC","SP","SE","TO");
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            try//validação simples
            {
                Cliente contato = new Cliente();
                if (txt_nome.Text.Length <= 0)
                {
                    MessageBox.Show("Nome Obrigatorio");
                    return;
                }
                contato.Nome = txt_nome.Text;
                contato.Cpf = txt_cpf.Text;
                contato.Rg = txt_rg.Text;
                contato.Telefone = txt_tel.Text;
                contato.Sexo = txt_sex.Text;
                contato.EstadoCivil = txt_estadoCivil.Text;
                contato.Estado = "";//arrumar
                contato.Rua = txt_rua.Text;
                contato.Cep = txt_cep.Text;
                contato.Cidade = txt_cidade.Text;
                contato.Numero = txt_numCasa.Text;
                contato.Complemento = txt_compCasa.Text;
                contato.Banco = txt_banco.Text;
                contato.CodAgencia = txt_codAgencia.Text;
                contato.NomeAgencia = txt_nomeAgencia.Text;
                contato.ContaCorrente = txt_contaCorrente.Text;
                String strConexao = @"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True";
                Conexao conexao = new Conexao(strConexao);
                CadClin dal = new CadClin(conexao);
                if (this.operacao == "inserir")
                {

                    try
                    {
                        dal.Incluir(contato);
                        MessageBox.Show("O codigo gerado foi: " + contato.Codigo.ToString());

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }
                }
                else 
                {
                    try
                    {
                       
                        dal.Alterar(contato);
                        MessageBox.Show("Registro alterado ");
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }
                }
                this.AlteraBotoes(1);
                this.LimpaCampos();
            }
            catch (Exception erro)//
            {
                MessageBox.Show(erro.Message);
            }
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

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
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
            CadClin dal = new CadClin(conexao);
            dal.Excluir(txt_cpf.Text);
            this.AlteraBotoes(1);
            this.LimpaCampos();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            frm_consultaCliente f = new frm_consultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                String strConexao = @"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True";
                Conexao conexao = new Conexao(strConexao);
                CadClin dal = new CadClin(conexao);
                Cliente contato = dal.carregaContato(f.codigo);
                txt_cpf.Text = contato.Cpf;
                txt_rg.Text = contato.Rg;
                txt_tel.Text = contato.Telefone;
                //sexo e estado civil
                txt_nome.Text = contato.Nome;
                txt_cep.Text = contato.Cep;
                txt_cidade.Text = contato.Cidade;
                txt_numCasa.Text = contato.Numero;
                //txt_.Text = contato.Estado;
                txt_rua.Text = contato.Rua;
                txt_compCasa.Text = contato.Complemento;
                txt_banco.Text = contato.Banco;
                txt_codAgencia.Text = contato.CodAgencia;
                txt_nomeAgencia.Text = contato.NomeAgencia;
                txt_contaCorrente.Text = contato.ContaCorrente;
                this.AlteraBotoes(3);
            }
            f.Dispose();
        }
    }
}
