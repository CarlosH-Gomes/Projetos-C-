using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace principal
{
    class CadItemCompra
    {
        private Conexao objConexao;

        public CadItemCompra(Conexao conexao)
        {
            objConexao = conexao;
        }

        public void Incluir(Compra compra)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into item_compra(comp_numeroNota, car_placa ) values(@numeroNota, @placa); select @@IDENTITY"; //com @ são parametros que serão passados 
            cmd.Parameters.AddWithValue("@numeroNota", compra.NotaFiscal);
            cmd.Parameters.AddWithValue("@placa", compra.Placa);
            objConexao.Conectar();
            compra.NotaFiscal = Convert.ToString(cmd.ExecuteScalar());
            compra.Placa = Convert.ToString(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }
        public void Alterar(Compra compra)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "update item_compra comp_numeroNota = @numeroNota, car_placa  = @placa where comp_numeroNota = @numeroNota "; //com @ são parametros que serão passados 
            cmd.Parameters.AddWithValue("@numeroNota", compra.NotaFiscal);
            cmd.Parameters.AddWithValue("@placa", compra.Placa);
            objConexao.Conectar();
            compra.NotaFiscal = Convert.ToString(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }

        public void Excluir(string notaFiscal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "delete from item_compra where comp_numeroNota = @numeroNota";
            cmd.Parameters.AddWithValue("@numeroNota", notaFiscal);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

        }
    }
}
