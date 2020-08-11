using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace principal
{
    class CadClin
    {
        private Conexao objConexao;

        public CadClin(Conexao conexao)
        {
            objConexao = conexao;
        }
        public void Incluir(Cliente contato)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into cliente(cli_nome, cli_cpf, cli_rg, cli_telefone, cli_sexo, cli_estadoCivil, cli_rua, cli_cidade, cli_cep, cli_estado, cli_numero, cli_complemento, cli_banco, cli_codAgencia, cli_nomeAgencia, cli_contaCorrente) values(@nome, @cpf, @rg, @telefone, @sexo, @estadoCivil, @rua, @cidade, @cep, @estado, @numero, @complemento, @banco, @codAgencia, @nomeAgencia, @contaCorrente ); select @@IDENTITY"; //com @ são parametros que serão passados 
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@cpf", contato.Cpf);
            cmd.Parameters.AddWithValue("@rg", contato.Rg);
            cmd.Parameters.AddWithValue("@telefone", contato.Telefone);
            cmd.Parameters.AddWithValue("@sexo", contato.Sexo);
            cmd.Parameters.AddWithValue("@estadoCivil", contato.EstadoCivil);
            cmd.Parameters.AddWithValue("@rua", contato.Rua);
            cmd.Parameters.AddWithValue("@cidade", contato.Cidade);
            cmd.Parameters.AddWithValue("@cep", contato.Cep);
            cmd.Parameters.AddWithValue("@estado", contato.Estado);
            cmd.Parameters.AddWithValue("@numero", contato.Numero);
            cmd.Parameters.AddWithValue("@complemento", contato.Complemento);
            cmd.Parameters.AddWithValue("@banco", contato.Banco);
            cmd.Parameters.AddWithValue("@codAgencia", contato.CodAgencia);
            cmd.Parameters.AddWithValue("@nomeAgencia", contato.NomeAgencia);
            cmd.Parameters.AddWithValue("@contaCorrente", contato.ContaCorrente);
            objConexao.Conectar();
            contato.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }
        public void Alterar(Cliente contato)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "update cliente set cli_nome = @nome, cli_cpf = @cpf, cli_rg = @rg, cli_telefone = @telefone, cli_sexo = @sexo, cli_estadoCivil = @estadoCivil, cli_rua = @rua, cli_cidade = @cidade, cli_cep = @cep, cli_estado = @estado, cli_numero = @numero, cli_complemento = @complemento, cli_banco = @banco, cli_codAgencia = @codAgencia, cli_nomeAgencia = @nomeAgencia, cli_contaCorrente = @contaCorrente where cli_cpf = @cpf"; //com @ são parametros que serão passados 
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@cpf", contato.Cpf);
            cmd.Parameters.AddWithValue("@rg", contato.Rg);
            cmd.Parameters.AddWithValue("@telefone", contato.Telefone);
            cmd.Parameters.AddWithValue("@sexo", contato.Sexo);
            cmd.Parameters.AddWithValue("@estadoCivil", contato.EstadoCivil);
            cmd.Parameters.AddWithValue("@rua", contato.Rua);
            cmd.Parameters.AddWithValue("@cidade", contato.Cidade);
            cmd.Parameters.AddWithValue("@cep", contato.Cep);
            cmd.Parameters.AddWithValue("@estado", contato.Estado);
            cmd.Parameters.AddWithValue("@numero", contato.Numero);
            cmd.Parameters.AddWithValue("@complemento", contato.Complemento);
            cmd.Parameters.AddWithValue("@banco", contato.Banco);
            cmd.Parameters.AddWithValue("@codAgencia", contato.CodAgencia);
            cmd.Parameters.AddWithValue("@nomeAgencia", contato.NomeAgencia);
            cmd.Parameters.AddWithValue("@contaCorrente", contato.ContaCorrente);
            objConexao.Conectar();
            contato.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }

        public void Excluir(string cpf)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "delete from cliente where cli_cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from cliente where cli_nome like '%" +
            valor + "%'", objConexao.StringConexao);
            da.Fill(tabela); //executa o comando do dataAdapter
            return tabela;
        }

        public Cliente carregaContato(int cod)
        {
            Cliente modelo = new Cliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where cli_cod = " + cod.ToString();
            objConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader(); //recebe todos os dados do banco
            if (registro.HasRows)
            {
                registro.Read();//faz leitura do data read
                modelo.Codigo = Convert.ToInt32(registro["cli_cod"]);
                modelo.Cpf = Convert.ToString(registro["cli_cpf"]);
                modelo.Nome = Convert.ToString(registro["cli_nome"]);
                modelo.Rg = Convert.ToString(registro["cli_rg"]);
                modelo.Telefone = Convert.ToString(registro["cli_telefone"]);
                modelo.Sexo = Convert.ToString(registro["cli_sexo"]);
                modelo.EstadoCivil = Convert.ToString(registro["cli_estadoCivil"]);
                modelo.Cidade = Convert.ToString(registro["cli_cidade"]);
                modelo.Estado = Convert.ToString(registro["cli_estado"]);
                modelo.Cep = Convert.ToString(registro["cli_cep"]);
                modelo.Rua = Convert.ToString(registro["cli_rua"]);
                modelo.Numero = Convert.ToString(registro["cli_numero"]);
                modelo.Complemento = Convert.ToString(registro["cli_complemento"]);
                modelo.Banco = Convert.ToString(registro["cli_banco"]);
                modelo.CodAgencia = Convert.ToString(registro["cli_codAgencia"]);
                modelo.NomeAgencia = Convert.ToString(registro["cli_nomeAgencia"]);
                modelo.ContaCorrente = Convert.ToString(registro["cli_contaCorrente"]);
            }
            return modelo;
        }
        public Cliente carregaContato(string cod)
        {
            Cliente modelo = new Cliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where cli_cod = '" + cod.ToString() +"'";
            objConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader(); //recebe todos os dados do banco
            if (registro.HasRows)
            {
                registro.Read();//faz leitura do data read
                modelo.Codigo = Convert.ToInt32(registro["cli_cod"]);
                modelo.Cpf = Convert.ToString(registro["cli_cpf"]);
                modelo.Nome = Convert.ToString(registro["cli_nome"]);
               
            }
            return modelo;
        }
    }
}
