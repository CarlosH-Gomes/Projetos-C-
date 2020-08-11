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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente n = new CadastroCliente();
            n.Show();
        }

        private void novoCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCarro nc = new CadastroCarro();
            nc.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_consultaCarro fc = new frm_consultaCarro();
            fc.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_consultaCliente fcl = new frm_consultaCliente();
         
            fcl.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_compra com = new frm_compra();
            com.Show();
        }

        private void consultaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_consultaCompra com = new frm_consultaCompra();
            com.Show();
        }
    }
}
