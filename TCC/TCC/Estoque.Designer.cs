
namespace TCC
{
    partial class Estoque
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
            this.txtQTD3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValorEst = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.EstoqueRecordDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueRecordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQTD3
            // 
            this.txtQTD3.Location = new System.Drawing.Point(315, 60);
            this.txtQTD3.Name = "txtQTD3";
            this.txtQTD3.Size = new System.Drawing.Size(45, 20);
            this.txtQTD3.TabIndex = 109;
            this.txtQTD3.Text = "0";
            this.txtQTD3.TextChanged += new System.EventHandler(this.txtQTD3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 108;
            this.label6.Text = "Codigo Baixa";
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(94, 60);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(131, 21);
            this.cbProduto.TabIndex = 106;
            this.cbProduto.SelectedIndexChanged += new System.EventHandler(this.cbProduto_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(39, 64);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 16);
            this.Label1.TabIndex = 107;
            this.Label1.Text = "Produto:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(366, 61);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(43, 16);
            this.Label3.TabIndex = 105;
            this.Label3.Text = "Valor:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(134, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(56, 20);
            this.txtCodigo.TabIndex = 99;
            this.txtCodigo.Visible = false;
            // 
            // txtValorEst
            // 
            this.txtValorEst.Location = new System.Drawing.Point(415, 60);
            this.txtValorEst.Name = "txtValorEst";
            this.txtValorEst.Size = new System.Drawing.Size(45, 20);
            this.txtValorEst.TabIndex = 97;
            this.txtValorEst.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(231, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(81, 16);
            this.Label2.TabIndex = 98;
            this.Label2.Text = "Quantidade:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(459, 336);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 34);
            this.button7.TabIndex = 212;
            this.button7.Text = "Sair";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(351, 336);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 34);
            this.button6.TabIndex = 211;
            this.button6.Text = "Excluir";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(243, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 34);
            this.button5.TabIndex = 210;
            this.button5.Text = "Alterar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(135, 336);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 34);
            this.button8.TabIndex = 209;
            this.button8.Text = "Cadastrar";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // EstoqueRecordDataGridView
            // 
            this.EstoqueRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstoqueRecordDataGridView.Location = new System.Drawing.Point(42, 87);
            this.EstoqueRecordDataGridView.Name = "EstoqueRecordDataGridView";
            this.EstoqueRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstoqueRecordDataGridView.Size = new System.Drawing.Size(604, 243);
            this.EstoqueRecordDataGridView.TabIndex = 214;
            this.EstoqueRecordDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstoqueRecordDataGridView_CellClick);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 386);
            this.Controls.Add(this.EstoqueRecordDataGridView);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtQTD3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtValorEst);
            this.Controls.Add(this.Label2);
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueRecordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtQTD3;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox cbProduto;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.TextBox txtValorEst;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView EstoqueRecordDataGridView;
    }
}