using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace principal
{
    class CadCompra
    {
        private Conexao objConexao;

        public CadCompra(Conexao conexao)
        {
            objConexao = conexao;
        }
        public void Incluir(Compra compra)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into compra(comp_numeroNota, comp_data, cli_cpf ) values(@numeroNota, @data, @cpf); select @@IDENTITY"; //com @ são parametros que serão passados 
            cmd.Parameters.AddWithValue("@numeroNota", compra.NotaFiscal);
            cmd.Parameters.AddWithValue("@data", compra.Data);
            cmd.Parameters.AddWithValue("@cpf", compra.Cpf);
            objConexao.Conectar();
            compra.NotaFiscal = Convert.ToString(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }
        public void Alterar(Compra compra)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "update compra comp_numeroNota = @numeroNota, comp_data = @data, cli_cpf = @cpf where comp_numeroNota = @numeroNota "; //com @ são parametros que serão passados 
            cmd.Parameters.AddWithValue("@numeroNota", compra.NotaFiscal);
            cmd.Parameters.AddWithValue("@data", compra.Data);
            cmd.Parameters.AddWithValue("@cpf", compra.Cpf);

            objConexao.Conectar();
            compra.NotaFiscal = Convert.ToString(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }

        public void Excluir(string notaFiscal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "delete from compra where comp_numeroNota = @numeroNota";
            cmd.Parameters.AddWithValue("@numeroNota", notaFiscal);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from compra where comp_numeroNota  like '%" +
            valor + "%'", objConexao.StringConexao);
            da.Fill(tabela); //executa o comando do dataAdapter
            return tabela;
        }

        public Compra carregaCompra(string codigo)
        {
            Compra modelo = new Compra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "select * from compra where comp_numeroNota = '" + codigo.ToString() + "'";
            objConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader(); //recebe todos os dados do banco
            if (registro.HasRows)
            {
                registro.Read();//faz leitura do data read
                modelo.NotaFiscal = Convert.ToString(registro["comp_numeroNota"]);
                modelo.Data = Convert.ToString(registro["comp_data"]);
                modelo.Cpf = Convert.ToString(registro["cli_cpf"]);
            }
            objConexao.Desconectar();
            return modelo;
            
        }
    }
}
