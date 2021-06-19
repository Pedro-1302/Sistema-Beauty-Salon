
namespace TCC
{
    partial class CadProdutos1
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
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblVal = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(85, 33);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(100, 20);
            this.txtProd.TabIndex = 0;
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(85, 59);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(100, 20);
            this.txtVal.TabIndex = 1;
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(23, 36);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(47, 13);
            this.lblProd.TabIndex = 2;
            this.lblProd.Text = "Produto:";
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Location = new System.Drawing.Point(36, 62);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(34, 13);
            this.lblVal.TabIndex = 3;
            this.lblVal.Text = "Valor:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(191, 9);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(24, 13);
            this.lblCod.TabIndex = 4;
            this.lblCod.Text = "text";
            this.lblCod.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(98, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // btnFun
            // 
            this.btnFun.Location = new System.Drawing.Point(85, 92);
            this.btnFun.Name = "btnFun";
            this.btnFun.Size = new System.Drawing.Size(75, 23);
            this.btnFun.TabIndex = 6;
            this.btnFun.Text = "btn";
            this.btnFun.UseVisualStyleBackColor = true;
            this.btnFun.Click += new System.EventHandler(this.btnFun_Click);
            // 
            // CadProdutos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 127);
            this.Controls.Add(this.btnFun);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.txtProd);
            this.Name = "CadProdutos1";
            this.Text = "Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblVal;
        public System.Windows.Forms.TextBox txtProd;
        public System.Windows.Forms.TextBox txtVal;
        public System.Windows.Forms.Label lblCod;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Button btnFun;
    }
}