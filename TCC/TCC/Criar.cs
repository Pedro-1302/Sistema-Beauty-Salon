using System.Drawing;
using System.Windows.Forms;

namespace TCC
{
	internal class Criar
	{
		
		public Panel gerarBotao(string text, int num)
		{
			Panel pnNovo = new Panel();
			pnNovo.Text = text;
			pnNovo.Dock = DockStyle.Top;
			pnNovo.Size = new Size(100, 20);
			pnNovo.Name = "paneltest";
			pnNovo.Visible = true;

			pnNovo.Controls.Add(gerarBtn("Deletar", num));
			pnNovo.Controls.Add(gerarBtn("Editar", num));
			
			for (int i = 4; i > 0; i--)
			{
				pnNovo.Controls.Add(gerarText("label" + i));
			}


			return pnNovo;
		}
		public Label gerarText(string text)
		{
			Label txtNovo = new Label();
			txtNovo.Text = text;
			txtNovo.Dock = DockStyle.Left;
			txtNovo.Size = new Size(115, 100);
			txtNovo.ForeColor = Color.Red;
			return txtNovo;
			
		}
		public Button gerarBtn(string text, int num)
		{
			Agendamento ag = new Agendamento();
			Button txtNovo = new Button();
			txtNovo.Text = text;
			txtNovo.Dock = DockStyle.Left;
			txtNovo.Size = new Size(115, 100);
			txtNovo.ForeColor = Color.Red;
			txtNovo.Name = text + num;
			txtNovo.Click += ag.btnAll_Click;
			return txtNovo;
		}
	}
}