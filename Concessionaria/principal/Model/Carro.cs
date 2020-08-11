using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principal
{
    class Carro
    {
        public Carro()
        {
            this.Codigo = 0;
            this.Modelo = "";
            this.Marca = "";
            this.Ano = "";
            this.Cor = "";
            this.Placa = "";
            this.Chassi = "";
            this.Renavam = "";
            this.Valor = "";
            this.Ipva = "";
            this.Licenciamento = "";   
        }
        public Carro(int codigo,string modelo, string marca, string ano, string cor, string placa, string chassi, string renavam, string valor, string ipva, string licenciamento)
        {
            this.Codigo = codigo;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Ano = ano;
            this.Cor = cor;
            this.Placa = placa;
            this.Chassi = chassi;
            this.Renavam = renavam;
            this.Valor = valor;
            this.Ipva = ipva;
            this.Licenciamento = licenciamento;
        }
        private int car_codigo;
        public int Codigo
        {
            get
            {
                return this.car_codigo;
            }
            set
            {
                this.car_codigo = value;
            }
        }
        private string car_modelo;
        public string Modelo
        {
            get
            {
                return this.car_modelo;
            }
            set
            {
                this.car_modelo = value;
            }
        }
        private string car_marca;
        public string Marca
        {
            get
            {
                return this.car_marca;
            }
            set
            {
                this.car_marca = value;
            }
        }

        private string car_ano;
        public string Ano
        {
            get
            {
                return this.car_ano;
            }
            set
            {
                this.car_ano = value;
            }
        }

        private string car_cor;
        public string Cor
        {
            get
            {
                return this.car_cor;
            }
            set
            {
                this.car_cor = value;
            }
        }

        private string car_placa;
        public string Placa
        {
            get
            {
                return this.car_placa;
            }
            set
            {
                this.car_placa = value;
            }
        }

        private string car_chassi;
        public string Chassi
        {
            get
            {
                return this.car_chassi;
            }
            set
            {
                this.car_chassi = value;
            }
        }

        private string car_renavam;
        public string Renavam
        {
            get
            {
                return this.car_renavam;
            }
            set
            {
                this.car_renavam = value;
            }
        }

        private string car_valor;
        public string Valor
        {
            get
            {
                return this.car_valor;
            }
            set
            {
                this.car_valor = value;
            }
        }

        private string car_ipva;
        public string Ipva
        {
            get
            {
                return this.car_ipva;
            }
            set
            {
                this.car_ipva = value;
            }
        }

        private string car_licenciamento;
        public string Licenciamento
        {
            get
            {
                return this.car_licenciamento;
            }
            set
            {
                this.car_licenciamento = value;
            }
        }
    }
}
