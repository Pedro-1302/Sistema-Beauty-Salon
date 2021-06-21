using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCC
{
    public partial class CompraProdutos : Form
    {
        public CompraProdutos()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
        public int CompraProduto;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CompraProdutos_Load(object sender, EventArgs e)
        {
            GetCompraProdutosRecord();
        }

        private void GetCompraProdutosRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Compra_Produto", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            CompraProdutosRecordDataGridView.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string valor = txtValor.Text;
                string quant = txtQTD.Text;

                
                SqlCommand cmd = new SqlCommand("INSERT INTO Compra_Produto VALUES ("+valor+", "+quant+", @name)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtNome.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Cadastro Efetuado", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCompraProdutosRecord();
            }
        }
            private bool IsValid()
        {
            if (txtValor.Text == string.Empty)
            {
                MessageBox.Show("Insira o nome do atendente", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CompraProduto > 0)
            {
                string valor = txtValor.Text;
                string quant = txtQTD.Text;

                SqlCommand cmd = new SqlCommand("UPDATE Compra_Produto SET Valor_Unitario = " + valor+ ", Quantidade = " + quant + ", Nome = @name WHERE Cod_Compra = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtNome.Text);
                cmd.Parameters.AddWithValue("@id", this.CompraProduto);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Alteração Efetuada", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCompraProdutosRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum estudante para alterar sua informação", "Alterar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompraProdutosRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CompraProduto = Convert.ToInt32(CompraProdutosRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtValor.Text = CompraProdutosRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtQTD.Text = CompraProdutosRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtNome.Text = CompraProdutosRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CompraProduto > 0)
            {
                string valor = txtValor.Text;
                string quant = txtQTD.Text;

                SqlCommand cmd = new SqlCommand("DELETE FROM Compra_Produto WHERE Cod_Compra = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.CompraProduto);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Excluido com sucesso", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCompraProdutosRecord();
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
