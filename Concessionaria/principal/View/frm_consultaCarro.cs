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
    public partial class frm_consultaCarro : Form
    {
        public frm_consultaCarro()
        {
            InitializeComponent();
        }
        public int codigo = 0;
        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao(@"Data Source = CARLOS\CARLOSBD; Initial Catalog = Concessionaria; Integrated Security = True");
            CadCarro dal = new CadCarro(cx);
            dgv_dados1.DataSource = dal.Localizar(txt_placa.Text);
        }
        private void dgv_dados1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_dados1.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
