using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TCC
{
    public partial class CadAtendente : Form
    {
        public CadAtendente()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
        public int Atendente;

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadAtendente_Load(object sender, EventArgs e)
        {
            GetAtendenteRecord();
        }

        private void GetAtendenteRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Atendente", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            AtendenteRecordDataGridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Atendente VALUES (@name, @endereco, @bairro, @cidade, @estado, @celular, @cpf) ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtNomeAtd.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndAtd.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairroAtd.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidadeAtd.Text);
                cmd.Parameters.AddWithValue("@estado", comboEstAtd.Text);
                cmd.Parameters.AddWithValue("@celular", txtFoneAtd.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPFAtd.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Cadastro Efetuado", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAtendenteRecord();
            }
        }

        private bool IsValid()
        {
            if (txtNomeAtd.Text == string.Empty)
            {
                MessageBox.Show("Insira o nome do atendente", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AtendenteRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Atendente = Convert.ToInt32(AtendenteRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtNomeAtd.Text = AtendenteRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtEndAtd.Text = AtendenteRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtBairroAtd.Text = AtendenteRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtCidadeAtd.Text = AtendenteRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            comboEstAtd.Text = AtendenteRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            txtFoneAtd.Text = AtendenteRecordDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            txtCPFAtd.Text = AtendenteRecordDataGridView.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Atendente > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Atendente SET N_Atendente = @name, Endereco = @endereco, Bairro = @bairro, Cidade = @cidade, Estado = @estado, Celular = @celular, CPF = @cpf WHERE Cod_Atendente = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtNomeAtd.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndAtd.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairroAtd.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidadeAtd.Text);
                cmd.Parameters.AddWithValue("@estado", comboEstAtd.Text);
                cmd.Parameters.AddWithValue("@celular", txtFoneAtd.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPFAtd.Text);
                cmd.Parameters.AddWithValue("@id", this.Atendente);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Alteração Efetuada", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAtendenteRecord();
            }
            else 
            {
                MessageBox.Show("Por favor selecione algum estudante para alterar sua informação", "Alterar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Atendente > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Atendente WHERE Cod_Atendente = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.Atendente);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Excluido com sucesso", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAtendenteRecord();
            }
            else 
            {
                MessageBox.Show("Por favor selecione algum campo para excluir", "Deletar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
