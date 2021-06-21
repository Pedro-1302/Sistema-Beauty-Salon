using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TCC
{
    public partial class CadClientes : Form
    {
        public CadClientes()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
        public int ClienteInt;

        private void CadClientes_Load(object sender, EventArgs e)
        {
            GetClientesRecord();
        }
        private void GetClientesRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Cliente", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            ClientesRecordDataGridView.DataSource = dt;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Cliente VALUES (@nome, @end, @bairro2, @cidade2, @est, @data, @sexo1, @fone1, @cpf2)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", txtNomeCli.Text);
                cmd.Parameters.AddWithValue("@end", txtEndCli.Text);
                cmd.Parameters.AddWithValue("@bairro2", txtBairroCli.Text);
                cmd.Parameters.AddWithValue("@cidade2", txtCidadeCli.Text);
                cmd.Parameters.AddWithValue("@est", comboEstCli.Text);
                cmd.Parameters.AddWithValue("@data", dtDataCli.Text);
                cmd.Parameters.AddWithValue("@sexo1", comboSexCli.Text);
                cmd.Parameters.AddWithValue("@fone1", txtFoneCli.Text);
                cmd.Parameters.AddWithValue("@cpf2", txtCPFCli.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Cadastro efetuado com sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetClientesRecord();
            }
        }
        private bool IsValid()
        {
            if (txtNomeCli.Text == string.Empty)
            {
                MessageBox.Show("Campo requirido", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ClientesRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteInt = Convert.ToInt32(ClientesRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtNomeCli.Text = ClientesRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtEndCli.Text = ClientesRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtBairroCli.Text = ClientesRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtCidadeCli.Text = ClientesRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            comboEstCli.Text = ClientesRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            dtDataCli.Text = ClientesRecordDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            comboSexCli.Text = ClientesRecordDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            txtFoneCli.Text = ClientesRecordDataGridView.SelectedRows[0].Cells[8].Value.ToString();
            txtCPFCli.Text = ClientesRecordDataGridView.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ClienteInt > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Cliente SET N_Cliente = @cli, Endereco = @endereco, Bairro = @bairro, Cidade = @cidade, Estado = @estado, Data_Nasc = @data, Sexo = @sex, Fone = @celular, CPF = @cpf WHERE Cod_Cliente = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cli", txtNomeCli.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndCli.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairroCli.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidadeCli.Text);
                cmd.Parameters.AddWithValue("@estado", comboEstCli.Text);
                cmd.Parameters.AddWithValue("@data", dtDataCli.Text);
                cmd.Parameters.AddWithValue("@sex", comboSexCli.Text);
                cmd.Parameters.AddWithValue("@celular", txtFoneCli.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPFCli.Text);
                cmd.Parameters.AddWithValue("@id", this.ClienteInt);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Alteração Efetuada", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetClientesRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum estudante para alterar sua informação", "Alterar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ClienteInt > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Agenda WHERE Cod_Cliente = @id ; DELETE FROM Cliente WHERE Cod_Cliente = @id", con);
                
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.ClienteInt);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Excluido com sucesso", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetClientesRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum campo para excluir", "Deletar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
