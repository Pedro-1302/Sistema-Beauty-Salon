
namespace TCC
{
    partial class Agendamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.Label6 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.comboServico = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.dataBuscar = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.comboAtendente = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.AgendamentoRecordDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AgendamentoRecordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 133;
            this.label8.Text = "Codigo Atendente:";
            // 
            // dtHora
            // 
            this.dtHora.CustomFormat = "13:00";
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(596, 109);
            this.dtHora.Name = "dtHora";
            this.dtHora.ShowUpDown = true;
            this.dtHora.Size = new System.Drawing.Size(111, 20);
            this.dtHora.TabIndex = 132;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(549, 110);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(41, 16);
            this.Label6.TabIndex = 131;
            this.Label6.Text = "Hora:";
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(371, 110);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(99, 20);
            this.dtData.TabIndex = 130;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(325, 110);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(40, 16);
            this.Label5.TabIndex = 129;
            this.Label5.Text = "Data:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(178, 110);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(111, 20);
            this.txtValor.TabIndex = 127;
            this.txtValor.Text = "0";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(127, 111);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(43, 16);
            this.Label3.TabIndex = 128;
            this.Label3.Text = "Valor:";
            // 
            // comboServico
            // 
            this.comboServico.FormattingEnabled = true;
            this.comboServico.Location = new System.Drawing.Point(596, 73);
            this.comboServico.Name = "comboServico";
            this.comboServico.Size = new System.Drawing.Size(111, 21);
            this.comboServico.TabIndex = 125;
            this.comboServico.DropDown += new System.EventHandler(this.comboServico_DropDown);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(533, 74);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(57, 16);
            this.Label2.TabIndex = 126;
            this.Label2.Text = "Serviço:";
            // 
            // dataBuscar
            // 
            this.dataBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataBuscar.Location = new System.Drawing.Point(608, 31);
            this.dataBuscar.Name = "dataBuscar";
            this.dataBuscar.Size = new System.Drawing.Size(99, 20);
            this.dataBuscar.TabIndex = 124;
            this.dataBuscar.ValueChanged += new System.EventHandler(this.dataBuscar_ValueChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(549, 31);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(53, 16);
            this.Label4.TabIndex = 123;
            this.Label4.Text = "Buscar:";
            // 
            // comboAtendente
            // 
            this.comboAtendente.FormattingEnabled = true;
            this.comboAtendente.Location = new System.Drawing.Point(178, 73);
            this.comboAtendente.Name = "comboAtendente";
            this.comboAtendente.Size = new System.Drawing.Size(111, 21);
            this.comboAtendente.TabIndex = 119;
            this.comboAtendente.DropDown += new System.EventHandler(this.comboAtendente_DropDown);
            this.comboAtendente.SelectedIndexChanged += new System.EventHandler(this.cbFuncionario_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(100, 74);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 16);
            this.Label1.TabIndex = 120;
            this.Label1.Text = "Atendente:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(313, 76);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(52, 16);
            this.Label7.TabIndex = 118;
            this.Label7.Text = "Cliente:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(130, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(56, 20);
            this.txtCodigo.TabIndex = 112;
            this.txtCodigo.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(191, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 167;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(299, 343);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 34);
            this.button5.TabIndex = 171;
            this.button5.Text = "Alterar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(407, 343);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 34);
            this.button6.TabIndex = 172;
            this.button6.Text = "Excluir";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(515, 343);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 34);
            this.button7.TabIndex = 173;
            this.button7.Text = "Sair";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(371, 73);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(111, 21);
            this.comboCliente.TabIndex = 174;
            this.comboCliente.DropDown += new System.EventHandler(this.comboCliente_DropDown);
            // 
            // AgendamentoRecordDataGridView
            // 
            this.AgendamentoRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgendamentoRecordDataGridView.Location = new System.Drawing.Point(54, 155);
            this.AgendamentoRecordDataGridView.Name = "AgendamentoRecordDataGridView";
            this.AgendamentoRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AgendamentoRecordDataGridView.Size = new System.Drawing.Size(692, 182);
            this.AgendamentoRecordDataGridView.TabIndex = 175;
            this.AgendamentoRecordDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgendamentoRecordDataGridView_CellClick);
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.AgendamentoRecordDataGridView);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.comboServico);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dataBuscar);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.comboAtendente);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Agendamento";
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.Agendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgendamentoRecordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.DateTimePicker dtHora;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DateTimePicker dtData;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtValor;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox comboServico;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker dataBuscar;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox comboAtendente;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        internal System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.DataGridView AgendamentoRecordDataGridView;
    }
}