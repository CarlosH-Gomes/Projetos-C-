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
    public partial class frm_consultaCliente : Form
    {
        public int codigo = 0;
        
        public frm_consultaCliente()
        {
            InitializeComponent();
        
            
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao(@"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True");
            CadClin dal = new CadClin(cx);
            dgv_dados.DataSource = dal.Localizar(txt_cliente.Text);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
             
        }

        private void dgv_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_dados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
