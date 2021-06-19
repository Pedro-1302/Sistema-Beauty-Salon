using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
    class conexao
    {
		SqlConnection conexaob = new SqlConnection();

		public conexao()
		{
			conexaob.ConnectionString = @"Data Source=DESKTOP-MEBJL61\BRUNOPINHEIRO;Initial Catalog=BEATIFUL;User ID=Bruno;Password=321";
		}

		public SqlConnection conectar()
		{
			if (conexaob.State == System.Data.ConnectionState.Closed)
			{
				conexaob.Open();
			}
			return conexaob;
		}
		public void desconectar()
		{
			if (conexaob.State == System.Data.ConnectionState.Open)
			{
				conexaob.Close();
			}
		}
	}
}
