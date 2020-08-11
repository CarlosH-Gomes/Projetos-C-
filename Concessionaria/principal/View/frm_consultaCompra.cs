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
    public partial class frm_consultaCompra : Form
    {
        public string codigo = "";
        public frm_consultaCompra()
        {
            InitializeComponent();
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao(@"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True");
            CadCompra dal = new CadCompra(cx);
            dgv_dados.DataSource = dal.Localizar(txt_cliente.Text);
        }
        private void dgv_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                this.codigo = Convert.ToString(dgv_dados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
