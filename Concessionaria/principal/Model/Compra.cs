using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principal

{
    class Compra
    {
        public Compra()
        {
            this.NotaFiscal = "";
            this.Data = "";
            this.Cpf = "";
            this.Placa = "";
        }
        public Compra(string notaFiscal, string data, string cpf, string placa)
        {
            this.NotaFiscal = notaFiscal;
            this.Data = data;
            this.Cpf = cpf;
            this.Placa = placa;
        }

        private string comp_numeroNota;
        public string NotaFiscal
        {
            get
            {
                return this.comp_numeroNota;
            }
            set
            {
                this.comp_numeroNota = value;
            }
        }
        private string comp_data;
        public string Data
        {
            get
            {
                return this.comp_data;
            }
            set
            {
                this.comp_data = value;
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
    }
}
