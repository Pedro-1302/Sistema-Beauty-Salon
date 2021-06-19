using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
    class controle
    {
		public bool tem;
		public String mensagem = "";

		public bool acessar(String email, String senha)
		{
			logincomandos logins = new logincomandos();
			tem = logins.verificarLogin(email, senha);
			if (!logins.mensagem.Equals(""))
			{
				this.mensagem = logins.mensagem;
			}
			return tem;
		}
		public String cadastrar(String email, String senha, String confsenha)
		{
			logincomandos logins = new logincomandos();
			mensagem = logins.cadastrar(email, senha, confsenha);

			if (logins.tem)
            {
				this.tem = true;
            }
			return mensagem;
		}
	}
}
