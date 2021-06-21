using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TCC
{
    public partial class CadFornecedor : Form
    {
        public CadFornecedor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
        public int Fornecedor;

        private void CadFornecedor_Load(object sender, EventArgs e)
        {
            GetFornecedorRecord();
        }

        private void GetFornecedorRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Fornecedor", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            FornecedorRecordDataGridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Fornecedor VALUES (@name, @endereco, @bairro, @cidade, @estado, @celular, @cnpj, @incest) ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtNomeForn.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairroForn.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidadeForn.Text);
                cmd.Parameters.AddWithValue("@estado", comboEstForn.Text);
                cmd.Parameters.AddWithValue("@celular", txtCelForn.Text);
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                cmd.Parameters.AddWithValue("@incest", txtIncEst.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Cadastro Efetuado", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetFornecedorRecord();
            }
        }
        private bool IsValid()
        {
            if (txtNomeForn.Text == string.Empty)
            {
                MessageBox.Show("Insira o nome do atendente", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void FornecedorRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fornecedor = Convert.ToInt32(FornecedorRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtNomeForn.Text = FornecedorRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtEndereco.Text = FornecedorRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtBairroForn.Text = FornecedorRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtCidadeForn.Text = FornecedorRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            comboEstForn.Text = FornecedorRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            txtCelForn.Text = FornecedorRecordDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            txtCNPJ.Text = FornecedorRecordDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            txtIncEst.Text = FornecedorRecordDataGridView.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Fornecedor > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Fornecedor SET N_Fornecedor = @n, Endereco = @e, Bairro = @b, Cidade = @c, Estado = @est, Fone = @cel, CNPJ = @cnpj, Inc_Est = @in WHERE Cod_Fornecedor = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@n", txtNomeForn.Text);
                cmd.Parameters.AddWithValue("@e", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@b", txtBairroForn.Text);
                cmd.Parameters.AddWithValue("@c", txtCidadeForn.Text);
                cmd.Parameters.AddWithValue("@est", comboEstForn.Text);
                cmd.Parameters.AddWithValue("@cel", txtCelForn.Text);
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                cmd.Parameters.AddWithValue("@in", txtIncEst.Text);
                cmd.Parameters.AddWithValue("@id", this.Fornecedor);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Alteração Efetuada", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetFornecedorRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum estudante para alterar sua informação", "Alterar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Fornecedor > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Fornecedor WHERE Cod_Fornecedor = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.Fornecedor);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Excluido com sucesso", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetFornecedorRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum campo para excluir", "Deletar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
