using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{ 
	public partial class Agendamento : Form
    {
        Criar criar = new Criar();
		

		public Agendamento()
        {
            InitializeComponent();

			select();

        }

        public void btnAll_Click(object sender, EventArgs e)
        {
			CadProdutos1 cadp = new CadProdutos1();
			int posicao = 1;
			string text;
			string text1;
			text = dataBuscar.Value.ToString();
			text = text.Substring(6,4) + "/"+text.Substring(3, 2) +"/"+ text.Substring(0, 2);
			text1 = text.Substring(8, 2) + "/" + text.Substring(5, 2) + "/" + text.Substring(0, 4);

			SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MEBJL61\BRUNOPINHEIRO;Initial Catalog=BEATIFUL;User ID=Bruno;Password=321");
			DataSet ds = new DataSet();
			string coma = "select * from Produto";
			SqlDataAdapter da = new SqlDataAdapter(coma, conn);
			da.Fill(ds);
			//test = this.AcceptButton.ToString();
			if (sender.ToString().Contains("Editar"))
            {
				
				posicao = Convert.ToInt32(sender.ToString().Replace("System.Windows.Forms.Button, Text: Editar", ""));
				string val = ds.Tables[0].Rows[posicao].ItemArray[2].ToString();
				string prod = ds.Tables[0].Rows[posicao].ItemArray[1].ToString();
				string cod = ds.Tables[0].Rows[posicao].ItemArray[0].ToString();
				cadp.txtProd.Text = prod;
				cadp.txtVal.Text = val;
				cadp.lblCod.Text = cod;
				cadp.lblTitulo.Text = "Atualizar";
				cadp.btnFun.Text = "Atualizar";
				cadp.Show();
			}
			else if (sender.ToString().Contains("Deletar"))
            {
				posicao = Convert.ToInt32(sender.ToString().Replace("System.Windows.Forms.Button, Text: Deletar", ""));
			}
			
            label9.Text = posicao.ToString()+"  "+text.ToString()+"  "+ text1.ToString();
        }
		public void limparpainel()
        {
			panel1.Controls.Clear();
		}
		public void select()
        {
			limparpainel();
			panel1.Visible = false;

			SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MEBJL61\BRUNOPINHEIRO;Initial Catalog=BEATIFUL;User ID=Bruno;Password=321");
			DataSet ds = new DataSet();
			string coma = "select * from Produto";
			SqlDataAdapter da = new SqlDataAdapter(coma, conn);

			da.Fill(ds);

			for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
			{
				string valorp = ds.Tables[0].Rows[x].ItemArray[2].ToString();
				string nprod = ds.Tables[0].Rows[x].ItemArray[1].ToString();
				panel1.Controls.Add(gerarBotao("panel" + x, x, valorp, nprod));
			}
			panel1.Visible = true;
		}
		
			public void btn_Click(string text)
        {
            string test;
            test = text.ToString();
            label9.Text = test.ToString();

        }
		public Panel gerarBotao(string text, int num, string t1, string t2)
		{
			Panel pnNovo = new Panel();
			pnNovo.Text = text;
			pnNovo.Dock = DockStyle.Top;
			pnNovo.Size = new Size(100, 20);
			pnNovo.Name = text;
			pnNovo.Visible = true;
			pnNovo.BackColor = Color.White;
			pnNovo.BorderStyle = BorderStyle.FixedSingle;

			pnNovo.Controls.Add(gerarBtn("Deletar", num));
			pnNovo.Controls.Add(gerarBtn("Editar", num));

			pnNovo.Controls.Add(gerarText(t1));
			pnNovo.Controls.Add(gerarText(t2));

			return pnNovo;
		}
		public Label gerarText(string text)
		{
			Label txtNovo = new Label();
			txtNovo.Text = text;
			txtNovo.Dock = DockStyle.Left;
			txtNovo.Size = new Size(115, 100);
			txtNovo.ForeColor = Color.Red;
			txtNovo.BorderStyle = BorderStyle.FixedSingle;
			return txtNovo;
		}
		public Button gerarBtn(string text, int num)
		{
			Button btnNovo = new Button();
			btnNovo.Text = text + num;
			btnNovo.Dock = DockStyle.Left;
			btnNovo.Size = new Size(30, 100);
			btnNovo.ForeColor = Color.Red;
			btnNovo.Name = text + num;
			btnNovo.Click += btnAll_Click;
			if (text != "Editar")
            {
				btnNovo.BackColor = Color.Red;
			}
			else
            {
				btnNovo.BackColor = Color.Blue;
			}
			return btnNovo;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			CadProdutos1 cadp = new CadProdutos1();
			cadp.txtProd.Text = "";
			cadp.txtVal.Text = "";
			cadp.lblCod.Text = "";
			cadp.lblTitulo.Text = "Cadastrar";
			cadp.btnFun.Text = "Cadastrar";
			cadp.Show();
		}

        private void button2_Click(object sender, EventArgs e)
        {
			label9.Text = grid.SelectedCells.ToString();
			controle controlef = new controle();
			controlef.acessar(txtLogin.Text, txtSenha.Text);
			if (controlef.mensagem.Equals(""))
			{
				if (controlef.tem)
				{
					MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CadServiços tela = new CadServiços();
					tela.Show();
				}
				else
				{
					MessageBox.Show("Usuario ou senha estão incorretos");
				}
			}
			else
			{
				MessageBox.Show(controlef.mensagem);
			}
		}

        private void Agendamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bEATIFULDataSet1.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.bEATIFULDataSet1.Produto);
            // TODO: esta linha de código carrega dados na tabela 'bEATIFULDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.bEATIFULDataSet.Usuario);

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			label9.Text = grid.SelectedRows.ToString();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
			label9.Text = grid.SelectedRows.ToString();
			SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MEBJL61\BRUNOPINHEIRO;Initial Catalog=BEATIFUL;User ID=Bruno;Password=321");			
			DataSet ds = new DataSet();
			string coma = "select * from Produto";
			SqlDataAdapter da = new SqlDataAdapter(coma, conn);

			da.Fill(ds);
			//label9.Text = "des";
			//label9.Text = ds.Tables[0].Rows.Count.ToString();
			//label9.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
		}
    }
}
