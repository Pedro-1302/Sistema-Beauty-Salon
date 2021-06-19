using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
    class logincomandos
    {
		public bool tem = false;
		public String mensagem = "";
		SqlCommand comando = new SqlCommand();
		conexao conexao = new conexao();
		SqlDataReader dr;
		SqlDataReader dr1;
		SqlDependency sd;

		public bool verificarLogin(String login, String senha)
		{
			comando.CommandText = "select * from Usuario where Email = @login and Senha = @senha";
			comando.Parameters.AddWithValue("@login", login);
			comando.Parameters.AddWithValue("@senha", senha);

			try
			{

				comando.Connection = conexao.conectar();
				dr = comando.ExecuteReader();

				if (dr.HasRows)
				{
					tem = true;
				}
			
				conexao.desconectar();
				dr.Close();
				
			}
			catch (SqlException)
			{
				this.mensagem = "Erro";
			}
			return tem;
		}

		public String cadastrar(String email, String senha, String confsenha)
		{
			tem = false;
			if (senha.Equals(confsenha))
			{
				comando.CommandText = "INSERT INTO tabela values (@usuario, @senha);";
				comando.Parameters.AddWithValue("@usuario", email);
				comando.Parameters.AddWithValue("@senha", senha);

				try
				{
					comando.Connection = conexao.conectar();
					comando.ExecuteNonQuery();
					conexao.desconectar();
					this.mensagem = "Cadastrado com sucesso";
					tem = true;
				}
				catch (SqlException)
				{
					this.mensagem = "Erro";
				}
			}
			else
			{
				this.mensagem = "As senhas não correspondem";
			}
			return mensagem;
		}
	}
}
