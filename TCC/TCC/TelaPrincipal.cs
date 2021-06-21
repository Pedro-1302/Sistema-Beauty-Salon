using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadClientes novaform = new CadClientes();
            novaform.Show();
        }

        private void atendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadAtendente novaform1 = new CadAtendente();
            novaform1.Show();        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadServiços novaform2 = new CadServiços();
            novaform2.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadFornecedor novaform3 = new CadFornecedor();
            novaform3.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadLogin novaform4 = new CadLogin();
            novaform4.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadProdutos novaform5 = new CadProdutos();
            novaform5.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompraProdutos novaform6 = new CompraProdutos();
            novaform6.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque novaform7 = new Estoque();
            novaform7.Show();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento novaform8 = new Agendamento();
            novaform8.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
