using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principal
{
    class Cliente
    {
        public Cliente()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.Cpf = "";
            this.Rg = "";
            this.Telefone = "";
            this.Sexo = "";
            this.EstadoCivil = "";
            this.Rua = "";
            this.Cidade = "";
            this.Cep = "";
            this.Estado = "";
            this.Numero = "";
            this.Complemento = "";
            this.Banco = "";
            this.CodAgencia = "";
            this.NomeAgencia = "";
            this.ContaCorrente = "";
        }
        public Cliente(int codigo, string nome, string cpf, string rg, string telefone, string sexo, string estadoCivil, string rua, string cidade, string cep, string estado, string numero, string complemento, string banco, string codAgencia, string nomeAgencia, string contaCorrente)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Telefone = telefone;
            this.Sexo = sexo;
            this.EstadoCivil = estadoCivil;
            this.Rua = rua;
            this.Cidade = cidade;
            this.Cep = cep;
            this.Estado = estado;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Banco = banco;
            this.CodAgencia = codAgencia;
            this.NomeAgencia = nomeAgencia;
            this.ContaCorrente = contaCorrente;
        }

        private int cli_cod;
        public int Codigo
        {
            get
            {
                return this.cli_cod;
            }
            set
            {
                this.cli_cod = value;
            }
        }
        private string cli_nome;
        public string Nome
        {
            get
            {
                return this.cli_nome;
            }
            set
            {
                this.cli_nome = value;
            }
        }

        private string cli_cpf;
        public string Cpf
        {
            get
            {
                return this.cli_cpf;
            }
            set
            {
                this.cli_cpf = value;
            }
        }

        private string cli_rg;
        public string Rg
        {
            get
            {
                return this.cli_rg;
            }
            set
            {
                this.cli_rg = value;
            }
        }

        private string cli_telefone;
        public string Telefone
        {
            get
            {
                return this.cli_telefone;
            }
            set
            {
                this.cli_telefone = value;
            }
        }

        private string cli_sexo;
        public string Sexo
        {
            get
            {
                return this.cli_sexo;
            }
            set
            {
                this.cli_sexo = value;
            }
        }

        private string cli_estadoCivil;
        public string EstadoCivil
        {
            get
            {
                return this.cli_estadoCivil;
            }
            set
            {
                this.cli_estadoCivil = value;
            }
        }

        private string cli_rua;
        public string Rua
        {
            get
            {
                return this.cli_rua;
            }
            set
            {
                this.cli_rua = value;
            }
        }

        private string cli_cidade;
        public string Cidade
        {
            get
            {
                return this.cli_cidade;
            }
            set
            {
                this.cli_cidade = value;
            }
        }

        private string cli_cep;
        public string Cep
        {
            get
            {
                return this.cli_cep;
            }
            set
            {
                this.cli_cep = value;
            }
        }

        private string cli_estado;
        public string Estado
        {
            get
            {
                return this.cli_estado;
            }
            set
            {
                this.cli_estado = value;
            }
        }

        private string cli_numero;
        public string Numero
        {
            get
            {
                return this.cli_numero;
            }
            set
            {
                this.cli_numero = value;
            }
        }

        private string cli_complemento;
        public string Complemento
        {
            get
            {
                return this.cli_complemento;
            }
            set
            {
                this.cli_complemento = value;
            }
        }

        private string cli_banco;
        public string Banco
        {
            get
            {
                return this.cli_banco;
            }
            set
            {
                this.cli_banco = value;
            }
        }

        private string cli_codAgencia;
        public string CodAgencia
        {
            get
            {
                return this.cli_codAgencia;
            }
            set
            {
                this.cli_codAgencia = value;
            }
        }

        private string cli_nomeAgencia;
        public string NomeAgencia
        {
            get
            {
                return this.cli_nomeAgencia;
            }
            set
            {
                this.cli_nomeAgencia = value;
            }
        }

        private string cli_contaCorrente;
        public string ContaCorrente
        {
            get
            {
                return this.cli_contaCorrente;
            }
            set
            {
                this.cli_contaCorrente = value;
            }
        }

    }
}
