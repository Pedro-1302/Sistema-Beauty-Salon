using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCC
{
    public partial class CadProdutos : Form
    {
        public CadProdutos()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
        public int Produtos;

        private void CadProdutos_Load(object sender, EventArgs e)
        {
            GetProdutosRecord();
        }

        private void GetProdutosRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Produto", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            ProdutosRecordDataGridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Produto VALUES (@prod, @price)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@prod", txtProd.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Cadastro Efetuado", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetProdutosRecord();
            }
        }
        private bool IsValid()
        {
            if (txtProd.Text == string.Empty)
            {
                MessageBox.Show("Insira o nome do atendente", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ProdutosRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Produtos = Convert.ToInt32(ProdutosRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtProd.Text = ProdutosRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = ProdutosRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Produtos > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Produto SET N_produto = @prod, V_produto = @price WHERE Cod_Produto = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@prod", txtProd.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@id", this.Produtos);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Alteração Efetuada", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetProdutosRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum estudante para alterar sua informação", "Alterar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Produtos > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Produto WHERE Cod_Produto = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.Produtos);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Excluido com sucesso", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetProdutosRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum campo para excluir", "Deletar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
