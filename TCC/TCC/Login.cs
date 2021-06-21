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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT N_Usuario, Senha FROM Usuario WHERE N_Usuario = @usuario and Senha = @senha", con);
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@usuario", txtLogin.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                TelaPrincipal novatela = new TelaPrincipal();
                novatela.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
