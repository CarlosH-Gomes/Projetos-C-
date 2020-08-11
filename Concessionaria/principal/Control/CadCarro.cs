using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace principal
{
    class CadCarro
    {
        private Conexao objConexao;

        public CadCarro(Conexao conexao)
        {
            objConexao = conexao;
        }
        public void Incluir(Carro carro)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into carro(car_modelo, car_marca, car_ano, car_cor, car_placa, car_chassi, car_renavam, car_valor, car_ipva, car_licenciamento) values(@modelo, @marca, @ano, @cor, @placa, @chassi, @renavam, @valor, @ipva, @licenciamento); select @@IDENTITY"; //com @ são parametros que serão passados 
            cmd.Parameters.AddWithValue("@modelo", carro.Modelo);
            cmd.Parameters.AddWithValue("@marca", carro.Marca);
            cmd.Parameters.AddWithValue("@ano", carro.Ano);
            cmd.Parameters.AddWithValue("@cor", carro.Cor);
            cmd.Parameters.AddWithValue("@placa", carro.Placa);
            cmd.Parameters.AddWithValue("@chassi", carro.Chassi);
            cmd.Parameters.AddWithValue("@renavam", carro.Renavam);
            cmd.Parameters.AddWithValue("@valor", carro.Valor);
            cmd.Parameters.AddWithValue("@ipva", carro.Ipva);
            cmd.Parameters.AddWithValue("@licenciamento", carro.Licenciamento);
            objConexao.Conectar();
            carro.Codigo = Convert.ToInt32(cmd.ExecuteScalar()); 
            objConexao.Desconectar();
        }
        public void Alterar(Carro carro)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "update carro car_modelo = @modelo, car_marca = marca, car_ano = @ano, car_cor = @cor, car_placa = @placa, car_chassi = @chassi, car_renavam = @renavam, car_valor = @valor, car_ipva = @ipva, car_licenciamento = @licenciamento where car_placa = @placa "; //com @ são parametros que serão passados 
            cmd.Parameters.AddWithValue("@modelo", carro.Modelo);
            cmd.Parameters.AddWithValue("@marca", carro.Marca);
            cmd.Parameters.AddWithValue("@ano", carro.Ano);
            cmd.Parameters.AddWithValue("@cor", carro.Cor);
            cmd.Parameters.AddWithValue("@placa", carro.Placa);
            cmd.Parameters.AddWithValue("@chassi", carro.Chassi);
            cmd.Parameters.AddWithValue("@renavam", carro.Renavam);
            cmd.Parameters.AddWithValue("@valor", carro.Valor);
            cmd.Parameters.AddWithValue("@ipva", carro.Ipva);
            cmd.Parameters.AddWithValue("@licenciamento", carro.Licenciamento);
            objConexao.Conectar();
            carro.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }

        public void Excluir(string placa)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "delete from carro where car_placa = @placa";
            cmd.Parameters.AddWithValue("@placa", placa);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from carro where car_placa like '%" +
            valor + "%'", objConexao.StringConexao);
            da.Fill(tabela); //executa o comando do dataAdapter
            return tabela;
        }

        public Carro carregaCarro(int codigo)
        {
            Carro modelo = new Carro();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "select * from carro where car_cod = " + codigo.ToString();
            objConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader(); //recebe todos os dados do banco
            if (registro.HasRows)
            {
                registro.Read();//faz leitura do data read
                modelo.Modelo = Convert.ToString(registro["car_modelo"]);
                modelo.Marca = Convert.ToString(registro["car_marca"]);
                modelo.Ano = Convert.ToString(registro["car_ano"]);
                modelo.Placa = Convert.ToString(registro["car_placa"]);
                modelo.Cor = Convert.ToString(registro["car_cor"]);
                modelo.Chassi = Convert.ToString(registro["car_chassi"]);
                modelo.Renavam = Convert.ToString(registro["car_renavam"]);
                modelo.Valor = Convert.ToString(registro["car_valor"]);
                modelo.Ipva = Convert.ToString(registro["car_ipva"]);
                modelo.Licenciamento = Convert.ToString(registro["car_licenciamento"]);
            }
            return modelo;
        }
    }
}
