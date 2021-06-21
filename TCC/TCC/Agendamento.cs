using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCC
{
    public partial class Agendamento : Form
    {
        private int Cod_Atendente;
        private int Cod_Cliente;
        private int Cod_Servico;

        public Agendamento()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
        public int Agenda;
        private void cbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Agendamento_Load(object sender, EventArgs e)
        {
            GetAgendamentoRecord();
        }

        private void DropDownCodCliente() {

        }

        private void DropDownCodAtendente()
        {

        }

        private void DropDownCodServico()
        {

        }

        private void Calcular_Total()
        {

            try {
                SqlCommand cmd2 = new SqlCommand($"SELECT top 1 ((CAST(p.V_Produto AS INT) * CAST(s.Quantidade AS INT)) + CAST(s.Valor_Servico AS INT)) valor_final FROM Servico s JOIN Produto p on s.Cod_Produto = p.Cod_Produto WHERE s.Cod_Servico = '{Cod_Servico}';", con);

                DataTable dt2 = new DataTable();

                con.Open();

                SqlDataReader sdr2 = cmd2.ExecuteReader();
                dt2.Load(sdr2);

                if (dt2.Rows.Count > 0) {
                    var row = dt2.Rows[0];
                    txtValor.Text = row["valor_final"].ToString();
                }
            } finally {
                con.Close();
            }

        }

        private void GetAgendamentoRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I61O7G;Initial Catalog=BEATIFUL;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Agenda", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            AgendamentoRecordDataGridView.DataSource = dt;


            GetAtendente(con, dt);
            GetCliente(con, dt);
            GetServico(con, dt);
        }

        private void GetServico(SqlConnection con, DataTable dt)
        {
            SqlCommand cmd4 = new SqlCommand("Select Tipo_Servico, Cod_Servico from Servico", con);
            DataTable dt4 = new DataTable();

            con.Open();

            SqlDataReader sdr4 = cmd4.ExecuteReader();
            dt4.Load(sdr4);
            con.Close();

            comboServico.DataSource = dt4;
            comboServico.ValueMember = "Tipo_Servico";
        }

        private void GetCliente(SqlConnection con, DataTable dt)
        {
            SqlCommand cmd3 = new SqlCommand("Select N_Cliente, Cod_Cliente from Cliente", con);
            DataTable dt3 = new DataTable();

            con.Open();

            SqlDataReader sdr3 = cmd3.ExecuteReader();
            dt3.Load(sdr3);
            con.Close();

            comboCliente.DataSource = dt3;
            comboCliente.ValueMember = "N_Cliente";
        }

        private void GetAtendente(SqlConnection con, DataTable dt)
        {
            SqlCommand cmd2 = new SqlCommand("Select N_Atendente from Atendente", con);
            DataTable dt2 = new DataTable();

            con.Open();

            SqlDataReader sdr2 = cmd2.ExecuteReader();
            dt2.Load(sdr2);
            con.Close();

            comboAtendente.DataSource = dt2;
            comboAtendente.ValueMember = "N_Atendente";
        }

        private void comboServico_DropDown(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand($"Select top 1 Tipo_Servico, Cod_Servico from Servico WHERE Tipo_Servico = '{comboServico.Text}'", con);
            DataTable dt4 = new DataTable();

            con.Open();

            SqlDataReader sdr4 = cmd4.ExecuteReader();
            dt4.Load(sdr4);
            con.Close();

            var row = dt4.Rows[0];
            Cod_Servico = (int)row["Cod_Servico"];
        }

        private void comboCliente_DropDown(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand($"Select top 1 Cod_Cliente from Cliente WHERE N_CLiente = '{comboCliente.Text}'", con);
            DataTable dt3 = new DataTable();

            con.Open();

            SqlDataReader sdr3 = cmd3.ExecuteReader();
            dt3.Load(sdr3);
            con.Close();

            var row = dt3.Rows[0];
            Cod_Cliente = (int)row["Cod_Cliente"];
        }

        private void comboAtendente_DropDown(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand($"Select top 1 Cod_Atendente from Atendente WHERE N_Atendente = '{comboAtendente.Text}'", con);
            DataTable dt2 = new DataTable();

            con.Open();

            SqlDataReader sdr2 = cmd2.ExecuteReader();
            dt2.Load(sdr2);
            con.Close();

            var row = dt2.Rows[0];
            Cod_Atendente = (int)row["Cod_Atendente"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                comboAtendente_DropDown(sender, e);
                comboCliente_DropDown(sender, e);
                comboServico_DropDown(sender, e);

                Calcular_Total();

                SqlCommand cmd = new SqlCommand("INSERT INTO Agenda VALUES (@data, @valor, @atendente, @servico, @cliente)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@data", dtData.Text + " " + dtHora.Text);
                cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                cmd.Parameters.AddWithValue("@atendente", Cod_Atendente);
                cmd.Parameters.AddWithValue("@servico", Cod_Servico);
                cmd.Parameters.AddWithValue("@cliente", Cod_Cliente);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Cadastro Efetuado", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAgendamentoRecord();
            }
        }
        private bool IsValid()
        {
            if (comboAtendente.Text == string.Empty)
            {
                MessageBox.Show("Insira o nome do atendente", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Agenda > 0)
            {
                comboAtendente_DropDown(sender, e);
                comboCliente_DropDown(sender, e);
                comboServico_DropDown(sender, e);

                Calcular_Total();

                SqlCommand cmd = new SqlCommand("UPDATE Agenda SET Data_Horario = @data, Valor = @valor, Cod_Atendente = @atendente, Cod_Servico = @servico, Cod_Cliente = @cliente WHERE Cod_Agenda = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@data", dtData.Text + " " + dtHora.Text);
                cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                cmd.Parameters.AddWithValue("@atendente", Cod_Atendente);
                cmd.Parameters.AddWithValue("@servico", Cod_Servico);
                cmd.Parameters.AddWithValue("@cliente", Cod_Cliente);
                cmd.Parameters.AddWithValue("@id", this.Agenda);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Alteração Efetuada", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAgendamentoRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum estudante para alterar sua informação", "Alterar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgendamentoRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Agenda = Convert.ToInt32(AgendamentoRecordDataGridView.SelectedRows[0].Cells[0].Value);
            var datahora = AgendamentoRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            var horadata = datahora.Split(' ');
            dtData.Text = horadata[0];
            dtHora.Text = horadata[1];
            txtValor.Text = AgendamentoRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            comboAtendente.Text = GetNome("Atendente", "N_Atendente", "Cod_Atendente", (int) AgendamentoRecordDataGridView.SelectedRows[0].Cells[3].Value, con);
            comboServico.Text = GetNome("Servico", "Tipo_Servico", "Cod_Servico", (int)AgendamentoRecordDataGridView.SelectedRows[0].Cells[4].Value, con);
            comboCliente.Text = GetNome("Cliente", "N_Cliente", "Cod_Cliente", (int)AgendamentoRecordDataGridView.SelectedRows[0].Cells[5].Value, con);
        }

        public static string GetNome(string tabela, string coluna, string codColuna, int cod, SqlConnection con)
        {
            SqlCommand cmd2 = new SqlCommand($"Select top 1 {coluna} from {tabela} where {codColuna} = {cod}", con);
            DataTable dt2 = new DataTable();

            con.Open();

            SqlDataReader sdr2 = cmd2.ExecuteReader();
            dt2.Load(sdr2);
            con.Close();

            var row = dt2.Rows[0];
            return (string)row[coluna];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Agenda > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Agenda WHERE Cod_Agenda = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.Agenda);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DialogResult dialogResult = MessageBox.Show("Excluido com sucesso", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAgendamentoRecord();
            }
            else
            {
                MessageBox.Show("Por favor selecione algum campo para excluir", "Deletar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataBuscar_ValueChanged(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand($"select* from Agenda where DATEDIFF(DAY, Data_Horario, @data) = 0 ", con);
            DataTable dt2 = new DataTable();

            cmd2.Parameters.AddWithValue("@data", dataBuscar.Text);

            con.Open();

            SqlDataReader sdr2 = cmd2.ExecuteReader();
            dt2.Load(sdr2);
            con.Close();

            AgendamentoRecordDataGridView.DataSource = dt2;
        }
    }
}
