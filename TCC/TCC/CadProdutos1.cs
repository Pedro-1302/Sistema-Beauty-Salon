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
    public partial class CadProdutos1 : Form
    {
		SqlCommand comando = new SqlCommand();
		conexao conexao = new conexao();
		public CadProdutos1()
        {
            InitializeComponent();
        }

		private void btnFun_Click(object sender, EventArgs e)
		{
			string prod = txtProd.Text.ToString();
			string val = txtVal.Text.ToString();


			if (btnFun.Text == "Cadastrar")
			{
				comando.CommandText = "INSERT INTO tabela values (@prod, @val);";
				comando.Parameters.AddWithValue("@prod", prod);
				comando.Parameters.AddWithValue("@val", val);
				try
				{
					comando.Connection = conexao.conectar();
					comando.ExecuteNonQuery();
					conexao.desconectar();
					MessageBox.Show("Cadastrado com sucesso");
				}
				catch (SqlException)
				{
					MessageBox.Show("Erro");
				}
				Agendamento ag = new Agendamento();
				ag.select();
			}
			else
			{
				int cod = Convert.ToInt32(lblCod.Text);
				comando.CommandText = "UPDATE Produto SET  N_Produto  = @prod, V_Produto = @val WHERE Cod_Produto = @cod;";
				comando.Parameters.AddWithValue("@prod", prod);
				comando.Parameters.AddWithValue("@val", val);
				comando.Parameters.AddWithValue("@cod", cod);
				try
				{
					comando.Connection = conexao.conectar();
					comando.ExecuteNonQuery();
					conexao.desconectar();
					MessageBox.Show("Atualizado com sucesso");
				}
				catch (SqlException)
				{
					MessageBox.Show("Erro");
				}
				Agendamento ag = new Agendamento();
				ag.select();
				this.Close();
			}
		}
    }
}
