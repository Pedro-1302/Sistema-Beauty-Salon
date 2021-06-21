using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCC
{
    public partial class CadLogin : Form
    {
        public CadLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
        public int Login;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CadLogin_Load(object sender, EventArgs e)
        {
            GetLoginRecord();
        }

        private void GetLoginRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Usuario", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            LoginRecordDataGridView.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Usuario VALUES (@user, @mail, @pass) ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Cadastro Efetuado", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetLoginRecord();
            }
        }

        private bool IsValid()
        {
            if (txtUser.Text == string.Empty)
            {
                MessageBox.Show("Insira o nome do atendente", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Login > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Usuario SET N_Usuario = @user, Email = @mail, Senha = @pass WHERE Cod_Usuario = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                cmd.Parameters.AddWithValue("@id", this.Login);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Alteração Efetuada", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetLoginRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum campo para alterar sua informação", "Alterar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Login = Convert.ToInt32(LoginRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtUser.Text = LoginRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtMail.Text = LoginRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtPass.Text = LoginRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Login > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE Cod_Usuario = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.Login);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Excluido com sucesso", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetLoginRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum campo para excluir", "Deletar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

