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

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento tela = new Agendamento();
            tela.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadProdutos tela = new CadProdutos();
            tela.Show();
        }
    }
}
