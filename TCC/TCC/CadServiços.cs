using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCC
{
    public partial class CadServiços : Form
    {
        private int Cod_Produto;


        public CadServiços()
        {
            InitializeComponent();


        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
        public int Servico;

        private void button8_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Servico VALUES (@tipo, @produto, @valorserv, @desc, @qtd) ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@tipo", txtNomeServico.Text);
                cmd.Parameters.AddWithValue("@desc", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@valorserv", txtValorServ.Text);
                cmd.Parameters.AddWithValue("@produto", Cod_Produto);
                cmd.Parameters.AddWithValue("@qtd", txtQuant.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Cadastro Efetuado", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetServicoRecord();
            }
        }

        private bool IsValid()
        {
            if (txtNomeServico.Text == string.Empty)
            {
                MessageBox.Show("Insira o nome do atendente", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void CadServiços_Load(object sender, EventArgs e)
        {
            GetServicoRecord();
        }

        private void GetServicoRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Servico", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            ServicoRecordDataGridView.DataSource = dt;

            SqlCommand cmd2 = new SqlCommand("Select N_Produto from Produto", con);
            DataTable dt2 = new DataTable();

            con.Open();

            SqlDataReader sdr2 = cmd2.ExecuteReader();
            dt2.Load(sdr2);
            con.Close();

            comboProdUsed.DataSource = dt2;
            comboProdUsed.ValueMember = "N_Produto";
        }

        private void comboProdUsed_DropDownClosed(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"Select top 1 V_Produto, Cod_Produto FROM Produto WHERE N_Produto = '{comboProdUsed.Text}'", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            var row = dt.Rows[0];
            txtValorProd.Text = row["V_Produto"].ToString();
            Cod_Produto = (int)row["Cod_Produto"];

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Servico > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Servico SET Tipo_Servico = @tipo, Cod_Produto = @produto, Valor_Servico = @valorserv, Descricao = @desc, Quantidade = @qtd WHERE Cod_Servico = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@tipo", txtNomeServico.Text);
                cmd.Parameters.AddWithValue("@desc", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@valorserv", txtValorServ.Text);
                cmd.Parameters.AddWithValue("@produto", Cod_Produto);
                cmd.Parameters.AddWithValue("@qtd", txtQuant.Text);
                cmd.Parameters.AddWithValue("@id", this.Servico);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Alteração Efetuada", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetServicoRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum estudante para alterar sua informação", "Alterar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ServicoRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Servico = Convert.ToInt32(ServicoRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtNomeServico.Text = ServicoRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtValorServ.Text = ServicoRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtDescricao.Text = ServicoRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtCodigo.Text = ServicoRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtQuant.Text = ServicoRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Servico > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Agenda WHERE Cod_Servico = @id ; DELETE FROM Servico WHERE Cod_Servico = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.Servico);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Excluido com sucesso", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetServicoRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum campo para excluir", "Deletar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
