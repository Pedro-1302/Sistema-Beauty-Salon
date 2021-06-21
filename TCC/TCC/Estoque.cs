using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCC
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select N_Produto from Produto", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            cbProduto.DataSource = dt;
            cbProduto.ValueMember = "N_Produto";
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
        public int Baixa;

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQTD3.Text) && !string.IsNullOrEmpty(cbProduto.Text))
            {
                var txtqtd = txtQTD3.Text;
                if (txtqtd.Contains(","))
                    txtqtd = txtqtd.Split(',')[0];

                txtValorEst.Text = (GetValorProduto(cbProduto.Text) * Int32.Parse(txtqtd)).ToString();
            }
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("Select N_Produto from Produto", con);
            //DataTable dt = new DataTable();

            //con.Open();

            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            //con.Close();

            //cbProduto.DataSource = dt;
            //cbProduto.ValueMember = "N_Produto";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            GetEstoqueRecord();
        }

        private void GetEstoqueRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Baixa", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            EstoqueRecordDataGridView.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Baixa VALUES (@prod, @valor, @qtd) ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@prod", GetCodProduto(cbProduto.Text));
                cmd.Parameters.AddWithValue("@qtd", txtQTD3.Text);
                cmd.Parameters.AddWithValue("@valor", txtValorEst.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Cadastro Efetuado", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetEstoqueRecord();
            }
        }

        private int GetCodProduto(string NomeProduto)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select Cod_Produto from Produto WHERE N_Produto = @nome", con);
            DataTable dt = new DataTable();
            cmd.Parameters.AddWithValue("@nome", NomeProduto);
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            var row = dt.Rows[0];
            return (int)row["Cod_Produto"];
        }

        private int GetValorProduto(string NomeProduto)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select V_Produto from Produto WHERE N_Produto = @nome", con);
            DataTable dt = new DataTable();
            cmd.Parameters.AddWithValue("@nome", NomeProduto);
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                return Int32.Parse(row["V_Produto"].ToString().Trim());
            }
            return 0;
        }



        private bool IsValid()
        {
            if (cbProduto.Text == string.Empty)
            {
                MessageBox.Show("Insira o nome do atendente", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void txtQTD3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQTD3.Text) && !string.IsNullOrEmpty(cbProduto.Text))
            {
                var txtqtd = txtQTD3.Text;
                if (txtqtd.Contains(","))
                    txtqtd = txtqtd.Split(',')[0];

                txtValorEst.Text = (GetValorProduto(cbProduto.Text) * Int32.Parse(txtqtd)).ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Baixa > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Baixa SET Cod_Produto = @codp, Valor_Produto = @vp, Quantidade = @qtd WHERE Cod_Baixa = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@codp", GetCodProduto(cbProduto.Text));
                cmd.Parameters.AddWithValue("@vp", txtValorEst.Text);
                cmd.Parameters.AddWithValue("@qtd", txtQTD3.Text);
                cmd.Parameters.AddWithValue("@id", this.Baixa);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Alteração Efetuada", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetEstoqueRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum estudante para alterar sua informação", "Alterar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstoqueRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var text = EstoqueRecordDataGridView;
            Baixa = Convert.ToInt32(EstoqueRecordDataGridView.SelectedRows[0].Cells[0].Value);
            cbProduto.Text = Agendamento.GetNome("Produto", "N_Produto", "Cod_Produto", (int)EstoqueRecordDataGridView.SelectedRows[0].Cells[1].Value, con);
            txtValorEst.Text = EstoqueRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtQTD3.Text = EstoqueRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Baixa > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Baixa WHERE Cod_Baixa = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.Baixa);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Excluido com sucesso", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetEstoqueRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum campo para excluir", "Deletar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
